using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CShapeSerialPort
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // .NET 9 默认编码为 UTF-8，注册 GB2312 编码支持以兼容串口数据
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrom());
        }
    }
}
