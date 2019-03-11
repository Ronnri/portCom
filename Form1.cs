using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
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
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)//串口数据接收事件
        {
            if (TEXTbutton.Checked)//文本模式
            {
                int ilen = serialPort1.BytesToRead;
                byte[] bytes = new byte[ilen];
                serialPort1.Read(bytes, 0, ilen);
                string str = System.Text.Encoding.Default.GetString(bytes);

                portTextOut.AppendText(GetTimeStamp() + "  " + str + '\r' + '\n');//添加内容
 
  
            }
            else if (HEXbutton.Checked)//16进制模式
            {
                byte data;
                data = (byte)serialPort1.ReadByte();
                string str = Convert.ToString(data, 16).ToUpper();
                portTextOut.AppendText("0x" + (str.Length == 1 ? "0" + str : str) + " " + '\r' + '\n');//空位补“0”   
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
                    InforOut.AppendText(GetTimeStamp() + "连接串口" + "\r\n");
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
                InforOut.AppendText(GetTimeStamp() + "断开串口" + "\r\n");
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
                    try
                    {
                        serialPort1.Write(bytes, 0, bytes.Length);
                    }
                    catch
                    {
                        InforOut.AppendText(GetTimeStamp() + " 串口发送指令失败 " + "\r\n");
                        serialPort1.Close();
                    }
                    InforOut.AppendText(GetTimeStamp() + " [Send] " + cmd.Text + "\r\n");
                    cmd.Text = "";
                }
                else if (HEXbutton.Checked)//选择了HEX模式
                {

                }
                
            }
            else//串口未连接
            {
                InforOut.AppendText(GetTimeStamp() + " 串口未连接 " + "\r\n");
            }       
        }
    }
}
