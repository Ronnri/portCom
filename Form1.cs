using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace portCom
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//取消跨线程调用警报
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)//串口数据接收事件
        {
            try
            {
                if (TEXTbutton.Checked)//文本模式
                {
                    int ilen = serialPort1.BytesToRead;
                    byte[] bytes = new byte[ilen];
                    serialPort1.Read(bytes, 0, ilen);
                    string str = System.Text.Encoding.Default.GetString(bytes);
         
                    portTextOut.AppendText(GetTimeStamp() + "  " + str +"\r\n");


                }
                else if (HEXbutton.Checked)//16进制模式
                {
                    int ilen = serialPort1.BytesToRead;
                    byte[] bytes = new byte[ilen];
                    serialPort1.Read(bytes, 0, ilen);
                    portTextOut.AppendText(GetTimeStamp());
                    for (int i = 0; i < ilen; i++)
                    {
                        string str = Convert.ToString(bytes[i], 16).ToUpper();
                        portTextOut.AppendText(" 0x" + (str.Length == 1 ? "0" + str : str) + " ");//空位补“0”   
                    }
                    portTextOut.AppendText("\r\n");
                }
            }
            catch
            {
                InforOut.AppendText(GetTimeStamp() + " 串口接收数据出错 " + "\r\n");
            }
            
        }


        private void connect_Click(object sender, EventArgs e)
        {
            
            if (connect.Text == "连接")
            {
                try
                {
                    serialPort1.PortName = portBox.Text;
                    serialPort1.BaudRate = Convert.ToInt32(BaudrateBox.Text);
                    serialPort1.Open();
                    connect.Text = "断开连接";
                    InforOut.AppendText(GetTimeStamp() + " 串口连接成功！ " + "\r\n");
                    portBox.Enabled = false;
                    BaudrateBox.Enabled = false;
                    searchPort.Enabled = false;
                }
                catch
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Close();
                    }
                    connect.Text = "连接";
                    InforOut.AppendText(GetTimeStamp() + " 串口连接失败！ " + "\r\n");


                }
                
            }
            else if(connect.Text == "断开连接")
            {
                connect.Text = "连接";
                InforOut.AppendText(GetTimeStamp() + " 断开串口 " + "\r\n");
                portBox.Enabled = true;
                BaudrateBox.Enabled = true;
                searchPort.Enabled = true;
            }
        }

        public static string GetTimeStamp()
        {
            return DateTime.Now.ToLocalTime().ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            cmd.Text = "";

        }

        private void send_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//串口已经开启
            {
                if (TEXTbutton.Checked)//选择了字符串模式
                {
                    Encoding gb = System.Text.Encoding.GetEncoding("gb2312");
                    byte[] bytes = gb.GetBytes(cmd.Text);
                    if (bytes.Length == 0) { }//空串不发送
                    else
                    {
                        try
                        {
                            serialPort1.Write(bytes, 0, bytes.Length);
                            InforOut.AppendText(GetTimeStamp() + " [Send] " + cmd.Text + "\r\n");
                        }
                        catch
                        {
                            InforOut.AppendText(GetTimeStamp() + " 串口发送指令失败 " + "\r\n");
                            serialPort1.Close();
                        }
                    }
                }
                else if (HEXbutton.Checked)//选择了HEX模式
                {
                    byte[] Data = new byte[1];
                    for (int i = 0; i < (cmd.Text.Length - cmd.Text.Length % 2) / 2; i++)
                    {
                        Data[0] = Convert.ToByte(cmd.Text.Substring(i * 2, 2), 16);
                        serialPort1.Write(Data, 0, 1);
                        InforOut.AppendText(GetTimeStamp() + " " + cmd.Text.Substring(i * 2, 2) + "\r\n");
                    }
                    if (cmd.Text.Length % 2 != 0)//剩下一位单独处理
                    {
                        Data[0] = Convert.ToByte(cmd.Text.Substring(cmd.Text.Length - 1, 1), 16);//单独发送B（0B）
                        serialPort1.Write(Data, 0, 1);//发送
                        InforOut.AppendText(GetTimeStamp() + " " + cmd.Text.Substring(cmd.Text.Length - 1, 1) + "\r\n");
                    }
                }
            }
            else//串口未连接
            {
                InforOut.AppendText(GetTimeStamp() + " 串口未连接 " + "\r\n");
            }       
        }

        private void cmdOutClear_Click(object sender, EventArgs e)
        {
            InforOut.Text = "";
        }

        private void portOutClear_Click(object sender, EventArgs e)
        {
            portTextOut.Text = "";
        }

        private void cmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (HEXbutton.Checked)//16进制模式，限制输入类型0-F X 和退格
            {
                //Regex reg = new Regex(@"^[0-9a-fA-FxX]$");
                if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b'
                    || e.KeyChar == 'A' || e.KeyChar == 'a' || e.KeyChar == 'B' || e.KeyChar == 'b'
                    || e.KeyChar == 'C' || e.KeyChar == 'c' || e.KeyChar == 'D' || e.KeyChar == 'd'
                    || e.KeyChar == 'e' || e.KeyChar == 'E' || e.KeyChar == 'F' || e.KeyChar == 'f'))
                {
                    e.Handled = true;
                }
                else
                {

                }
                
            }
            else if (TEXTbutton.Checked)//文本模式，无输入限制
            {

            }

        }

        private void searchPort_Click(object sender, EventArgs e)
        {
            foreach (string vPortName in SerialPort.GetPortNames())
            {
                this.portBox.Text = vPortName;
            }
        }

        private void HEXbutton_CheckedChanged(object sender, EventArgs e)
        {
            if(HEXbutton.Checked)
            {
                cmd.Text = "";
            }
        }

        private void TEXTbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (TEXTbutton.Checked)
            {
                cmd.Text = "";
            }
        }
    }
}
