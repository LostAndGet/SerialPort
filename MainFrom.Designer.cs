namespace CShapeSerialPort
{
    partial class MainFrom
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
            this.btnOpenClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDKH = new System.Windows.Forms.ComboBox();
            this.comboBoxBTL = new System.Windows.Forms.ComboBox();
            this.comboBoxSJW = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxXYW = new System.Windows.Forms.ComboBox();
            this.comboBoxTZW = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.checkBoxHEX = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.chkBoxSendOntime = new System.Windows.Forms.CheckBox();
            this.btnSendOnce = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRecv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenClose
            // 
            this.btnOpenClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenClose.Location = new System.Drawing.Point(20, 315);
            this.btnOpenClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenClose.Name = "btnOpenClose";
            this.btnOpenClose.Size = new System.Drawing.Size(221, 48);
            this.btnOpenClose.TabIndex = 0;
            this.btnOpenClose.Text = "打开串口";
            this.btnOpenClose.UseVisualStyleBackColor = true;
            this.btnOpenClose.Click += new System.EventHandler(this.btnOpenClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // comboBoxDKH
            // 
            this.comboBoxDKH.FormattingEnabled = true;
            this.comboBoxDKH.Location = new System.Drawing.Point(80, 15);
            this.comboBoxDKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDKH.Name = "comboBoxDKH";
            this.comboBoxDKH.Size = new System.Drawing.Size(160, 23);
            this.comboBoxDKH.TabIndex = 3;
            // 
            // comboBoxBTL
            // 
            this.comboBoxBTL.FormattingEnabled = true;
            this.comboBoxBTL.Location = new System.Drawing.Point(80, 50);
            this.comboBoxBTL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxBTL.Name = "comboBoxBTL";
            this.comboBoxBTL.Size = new System.Drawing.Size(160, 23);
            this.comboBoxBTL.TabIndex = 4;
            // 
            // comboBoxSJW
            // 
            this.comboBoxSJW.FormattingEnabled = true;
            this.comboBoxSJW.Location = new System.Drawing.Point(80, 82);
            this.comboBoxSJW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSJW.Name = "comboBoxSJW";
            this.comboBoxSJW.Size = new System.Drawing.Size(160, 23);
            this.comboBoxSJW.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "数据位";
            // 
            // comboBoxXYW
            // 
            this.comboBoxXYW.FormattingEnabled = true;
            this.comboBoxXYW.Location = new System.Drawing.Point(80, 115);
            this.comboBoxXYW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxXYW.Name = "comboBoxXYW";
            this.comboBoxXYW.Size = new System.Drawing.Size(160, 23);
            this.comboBoxXYW.TabIndex = 7;
            // 
            // comboBoxTZW
            // 
            this.comboBoxTZW.FormattingEnabled = true;
            this.comboBoxTZW.Location = new System.Drawing.Point(80, 148);
            this.comboBoxTZW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTZW.Name = "comboBoxTZW";
            this.comboBoxTZW.Size = new System.Drawing.Size(160, 23);
            this.comboBoxTZW.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "校验位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "停止位";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.checkBoxHEX);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.chkBoxSendOntime);
            this.panel1.Controls.Add(this.btnSendOnce);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOpenClose);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxDKH);
            this.panel1.Controls.Add(this.comboBoxTZW);
            this.panel1.Controls.Add(this.comboBoxBTL);
            this.panel1.Controls.Add(this.comboBoxXYW);
            this.panel1.Controls.Add(this.comboBoxSJW);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(471, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 550);
            this.panel1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(51, 264);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = " ";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(20, 191);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(221, 48);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "清空收区";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // checkBoxHEX
            // 
            this.checkBoxHEX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxHEX.AutoSize = true;
            this.checkBoxHEX.Location = new System.Drawing.Point(20, 516);
            this.checkBoxHEX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxHEX.Name = "checkBoxHEX";
            this.checkBoxHEX.Size = new System.Drawing.Size(150, 19);
            this.checkBoxHEX.TabIndex = 15;
            this.checkBoxHEX.Text = "以16进制发送接收";
            this.checkBoxHEX.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 470);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "ms";
            // 
            // txtTime
            // 
            this.txtTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTime.Location = new System.Drawing.Point(124, 466);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(80, 25);
            this.txtTime.TabIndex = 13;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // chkBoxSendOntime
            // 
            this.chkBoxSendOntime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBoxSendOntime.AutoSize = true;
            this.chkBoxSendOntime.Location = new System.Drawing.Point(20, 470);
            this.chkBoxSendOntime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBoxSendOntime.Name = "chkBoxSendOntime";
            this.chkBoxSendOntime.Size = new System.Drawing.Size(89, 19);
            this.chkBoxSendOntime.TabIndex = 12;
            this.chkBoxSendOntime.Text = "定时发送";
            this.chkBoxSendOntime.UseVisualStyleBackColor = true;
            this.chkBoxSendOntime.CheckedChanged += new System.EventHandler(this.chkBoxSendOntime_CheckedChanged);
            // 
            // btnSendOnce
            // 
            this.btnSendOnce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSendOnce.Location = new System.Drawing.Point(20, 384);
            this.btnSendOnce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendOnce.Name = "btnSendOnce";
            this.btnSendOnce.Size = new System.Drawing.Size(221, 48);
            this.btnSendOnce.TabIndex = 11;
            this.btnSendOnce.Text = "串口发送";
            this.btnSendOnce.UseVisualStyleBackColor = true;
            this.btnSendOnce.Click += new System.EventHandler(this.btnSendOnce_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 550);
            this.panel2.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRecv);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(471, 315);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收区";
            // 
            // txtRecv
            // 
            this.txtRecv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtRecv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRecv.Location = new System.Drawing.Point(4, 22);
            this.txtRecv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRecv.Multiline = true;
            this.txtRecv.Name = "txtRecv";
            this.txtRecv.Size = new System.Drawing.Size(463, 289);
            this.txtRecv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSend);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 315);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(471, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送区";
            // 
            // txtSend
            // 
            this.txtSend.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSend.Location = new System.Drawing.Point(4, 22);
            this.txtSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(463, 209);
            this.txtSend.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口调试v1.0（ji_hua_cheng@163.com）";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDKH;
        private System.Windows.Forms.ComboBox comboBoxBTL;
        private System.Windows.Forms.ComboBox comboBoxSJW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxXYW;
        private System.Windows.Forms.ComboBox comboBoxTZW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSendOnce;
        private System.Windows.Forms.CheckBox chkBoxSendOntime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRecv;
        private System.Windows.Forms.CheckBox checkBoxHEX;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;

    }
}

