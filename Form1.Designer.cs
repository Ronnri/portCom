namespace portCom
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.portNum = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.connect = new System.Windows.Forms.Button();
            this.portTextOut = new System.Windows.Forms.TextBox();
            this.portText = new System.Windows.Forms.Label();
            this.Baudrate = new System.Windows.Forms.Label();
            this.BaudrateBox = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.HEXbutton = new System.Windows.Forms.RadioButton();
            this.TEXTbutton = new System.Windows.Forms.RadioButton();
            this.InforOut = new System.Windows.Forms.TextBox();
            this.infor = new System.Windows.Forms.Label();
            this.cmd = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // portNum
            // 
            this.portNum.AutoSize = true;
            this.portNum.Location = new System.Drawing.Point(84, 62);
            this.portNum.Name = "portNum";
            this.portNum.Size = new System.Drawing.Size(58, 24);
            this.portNum.TabIndex = 0;
            this.portNum.Text = "端口";
            // 
            // portBox
            // 
            this.portBox.FormattingEnabled = true;
            this.portBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15"});
            this.portBox.Location = new System.Drawing.Point(167, 59);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(121, 32);
            this.portBox.TabIndex = 1;
            this.portBox.Text = "COM1";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(88, 246);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(200, 51);
            this.connect.TabIndex = 4;
            this.connect.Text = "连接";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // portTextOut
            // 
            this.portTextOut.Location = new System.Drawing.Point(397, 96);
            this.portTextOut.Multiline = true;
            this.portTextOut.Name = "portTextOut";
            this.portTextOut.ReadOnly = true;
            this.portTextOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.portTextOut.Size = new System.Drawing.Size(637, 201);
            this.portTextOut.TabIndex = 5;
            // 
            // portText
            // 
            this.portText.AutoSize = true;
            this.portText.Location = new System.Drawing.Point(393, 59);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(106, 24);
            this.portText.TabIndex = 6;
            this.portText.Text = "串口输出";
            // 
            // Baudrate
            // 
            this.Baudrate.AutoSize = true;
            this.Baudrate.Location = new System.Drawing.Point(60, 141);
            this.Baudrate.Name = "Baudrate";
            this.Baudrate.Size = new System.Drawing.Size(82, 24);
            this.Baudrate.TabIndex = 7;
            this.Baudrate.Text = "波特率";
            // 
            // BaudrateBox
            // 
            this.BaudrateBox.FormattingEnabled = true;
            this.BaudrateBox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.BaudrateBox.Location = new System.Drawing.Point(167, 141);
            this.BaudrateBox.Name = "BaudrateBox";
            this.BaudrateBox.Size = new System.Drawing.Size(121, 32);
            this.BaudrateBox.TabIndex = 8;
            this.BaudrateBox.Text = "9600";
            // 
            // HEXbutton
            // 
            this.HEXbutton.AutoSize = true;
            this.HEXbutton.Location = new System.Drawing.Point(65, 198);
            this.HEXbutton.Name = "HEXbutton";
            this.HEXbutton.Size = new System.Drawing.Size(77, 28);
            this.HEXbutton.TabIndex = 9;
            this.HEXbutton.Text = "HEX";
            this.HEXbutton.UseVisualStyleBackColor = true;
            // 
            // TEXTbutton
            // 
            this.TEXTbutton.AutoSize = true;
            this.TEXTbutton.Checked = true;
            this.TEXTbutton.Location = new System.Drawing.Point(175, 198);
            this.TEXTbutton.Name = "TEXTbutton";
            this.TEXTbutton.Size = new System.Drawing.Size(113, 28);
            this.TEXTbutton.TabIndex = 10;
            this.TEXTbutton.TabStop = true;
            this.TEXTbutton.Text = "字符串";
            this.TEXTbutton.UseVisualStyleBackColor = true;
            // 
            // InforOut
            // 
            this.InforOut.Location = new System.Drawing.Point(397, 372);
            this.InforOut.Multiline = true;
            this.InforOut.Name = "InforOut";
            this.InforOut.ReadOnly = true;
            this.InforOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InforOut.Size = new System.Drawing.Size(637, 157);
            this.InforOut.TabIndex = 11;
            // 
            // infor
            // 
            this.infor.AutoSize = true;
            this.infor.Location = new System.Drawing.Point(393, 331);
            this.infor.Name = "infor";
            this.infor.Size = new System.Drawing.Size(58, 24);
            this.infor.TabIndex = 12;
            this.infor.Text = "状态";
            // 
            // cmd
            // 
            this.cmd.Location = new System.Drawing.Point(65, 372);
            this.cmd.Multiline = true;
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(282, 133);
            this.cmd.TabIndex = 13;
            this.cmd.Text = "input cmd";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(65, 529);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(115, 55);
            this.clear.TabIndex = 14;
            this.clear.Text = "清空";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(231, 529);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(115, 55);
            this.send.TabIndex = 15;
            this.send.Text = "发送";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(742, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Designed by Ronnri. For homework only. ALL RIGHTS RESERVERED.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 610);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.cmd);
            this.Controls.Add(this.infor);
            this.Controls.Add(this.InforOut);
            this.Controls.Add(this.TEXTbutton);
            this.Controls.Add(this.HEXbutton);
            this.Controls.Add(this.BaudrateBox);
            this.Controls.Add(this.Baudrate);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.portTextOut);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.portNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "串口通信上位机Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label portNum;
        private System.Windows.Forms.ComboBox portBox;
 
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox portTextOut;
        private System.Windows.Forms.Label portText;
        private System.Windows.Forms.Label Baudrate;
        private System.Windows.Forms.ComboBox BaudrateBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RadioButton HEXbutton;
        private System.Windows.Forms.RadioButton TEXTbutton;
        private System.Windows.Forms.TextBox InforOut;
        private System.Windows.Forms.Label infor;
        private System.Windows.Forms.TextBox cmd;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label1;
    }
}

