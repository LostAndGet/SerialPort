using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace CShapeSerialPort
{
    public partial class MainFrom : Form
    {
        private SerialPortUtil comPort = new SerialPortUtil();

        private System.Timers.Timer timer = new System.Timers.Timer();
        public MainFrom()
        {
            InitializeComponent();
        }

        private void COMOpen()
        {
            if (!comPort.IsOpen)
            {
                try
                {
                    comPort.OpenPort();
                    btnOpenClose.Text = "关闭串口";
                    label7.Text = comPort.PortName + "已打开";
                    label7.ForeColor = System.Drawing.Color.Green;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!comPort.IsOpen)
                {
                    btnOpenClose.Text = "打开串口";
                    label7.Text = " ";
                }
            }
        }

        private void COMSend()
        {
            try
            {
                if (checkBoxHEX.Checked)
                {
                    comPort.WriteData(SerialPortUtil.HexToByte(txtSend.Text));
                }
                else
                {
                    comPort.WriteData(txtSend.Text);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("发送错误：" + ex.Message);
            }

        }
        private void COMClose()
        {
            if (comPort.IsOpen)
            {
                try
                {
                    //comPort.DiscardBuffer();
                    //timer1.Enabled = false;
                    //chkBoxSendOntime.Checked = false;
                    comPort.ClosePort();
                    btnOpenClose.Text = "打开串口";
                    label7.Text = comPort.PortName + "已关闭";
                    label7.ForeColor = System.Drawing.Color.Red;
                }
                catch (System.Exception ex)
                {
                    btnOpenClose.Text = "关闭串口";
                    label7.Text = " ";
                    MessageBox.Show(ex.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            //comboBox设置数据
            
            SerialPortUtil.SetPortNameValues(comboBoxDKH);
            if (comboBoxDKH.Items.Count == 0)
            {
                MessageBox.Show("未扫描到该计算机的COM口，请添加硬件后重新打开程序！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            SerialPortUtil.SetBauRateValues(comboBoxBTL);
            SerialPortUtil.SetDataBitsValues(comboBoxSJW);
            SerialPortUtil.SetParityValues(comboBoxXYW);
            SerialPortUtil.SetStopBitValues(comboBoxTZW);

            
            
            
            comboBoxDKH.SelectedIndex = 0;
            comboBoxBTL.SelectedIndex = 8;
            comboBoxSJW.SelectedIndex = 3;
            comboBoxXYW.SelectedIndex = 0;
            comboBoxTZW.SelectedIndex = 1;
            comboBoxDKH.SelectedIndexChanged += (o, ex) => { COMClose(); comPort.PortName = comboBoxDKH.SelectedItem.ToString(); COMOpen(); };
            comboBoxBTL.SelectedIndexChanged += (o, ex) => { COMClose(); comPort.BaudRate = (SerialPortBaudRates)Convert.ToInt32(comboBoxBTL.SelectedItem); COMOpen(); };
            comboBoxSJW.SelectedIndexChanged += (o, ex) => { COMClose(); comPort.DataBits = (SerialPortDatabits)Convert.ToInt32(comboBoxSJW.SelectedItem.ToString()); COMOpen(); };
            comboBoxXYW.SelectedIndexChanged += (o, ex) => { COMClose(); comPort.Parity = (Parity)(comboBoxXYW.SelectedIndex); COMOpen(); };
            comboBoxTZW.SelectedIndexChanged += (o, ex) => { COMClose(); comPort.StopBits = (StopBits)(comboBoxTZW.SelectedIndex); COMOpen(); };
            comPort.DataReceived += new DataReceivedEventHandler(comPort_DataReceived);
            comPort.Error += new SerialErrorReceivedEventHandler(comPort_Error);;
            //COMOpen();
            comPort.PortName = comboBoxDKH.SelectedItem.ToString();
            comPort.BaudRate = (SerialPortBaudRates)Convert.ToInt32(comboBoxBTL.SelectedItem);
            comPort.DataBits = (SerialPortDatabits)Convert.ToInt32(comboBoxSJW.SelectedItem.ToString());
            comPort.Parity = (Parity)(comboBoxXYW.SelectedIndex);
            comPort.StopBits = (StopBits)(comboBoxTZW.SelectedIndex);

            chkBoxSendOntime.Checked = false;
            checkBoxHEX.Checked = true;
            txtTime.Text = "200";
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
        }

        void comPort_Error(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

       void comPort_DataReceived(DataReceivedEventArgs e)
        {
           this.txtRecv.BeginInvoke(
               new MethodInvoker(()=>{
                   if (checkBoxHEX.Checked)
                   {
                       this.txtRecv.AppendText(SerialPortUtil.ByteToHex(e.DataRecv));//输出到主窗口文本控件   
                   } 
                   else
                   {
                       this.txtRecv.AppendText(System.Text.Encoding.Default.GetString(e.DataRecv));//输出到主窗口文本控件   
                   }
               }
               )
            ); 
        }

        private void btnOpenClose_Click(object sender, EventArgs e)
        {
            if (comPort.IsOpen)
            {
                COMClose();
            }
            else
            {
                COMOpen();
            }
        }

        private void btnSendOnce_Click(object sender, EventArgs e)
        {
            COMSend();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chkBoxSendOntime.Checked)
            {
                if (txtTime.Text=="")
                {
                    timer1.Enabled = false;
                    MessageBox.Show("请输入时间！");
                } 
                else
                {
                    if (comPort.IsOpen)
                    {
                        COMSend();
                    }
                }
            }
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //throw new NotImplementedException();
            if (chkBoxSendOntime.Checked)
            {
                if (txtTime.Text == "")
                {
                    timer1.Enabled = false;
                    MessageBox.Show("请输入时间！");
                }
                else
                {
                    if (comPort.IsOpen)
                    {
                        COMSend();
                    }
                }
            }
        }

        private void chkBoxSendOntime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxSendOntime.Checked)
            {
                if (txtTime.Text == "")
                {
                    MessageBox.Show("请输入时间！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    chkBoxSendOntime.Checked = false;
                }
                else
                {
                    try
                    {
                        //timer1.Interval = Convert.ToInt32(txtTime.Text);
                        //timer1.Enabled = true;
                        timer.Interval = Convert.ToInt32(txtTime.Text);
                        timer.Enabled = true;
                    }
                    catch (System.Exception ex)
                    {
                        //timer1.Enabled = false;
                        timer.Enabled = false;
                        MessageBox.Show("时间输入错误：" + ex.Message);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRecv.Text = "";
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
//                 timer1.Interval = Convert.ToInt32(txtTime.Text);
//                 timer1.Enabled = true;
                timer.Interval = Convert.ToInt32(txtTime.Text);
                timer.Enabled = true;
            }
            catch (System.Exception ex)
            {
                //timer1.Enabled = false;
                timer.Enabled = false;
                MessageBox.Show("时间输入错误：" + ex.Message);
            }
        }

    }
}
