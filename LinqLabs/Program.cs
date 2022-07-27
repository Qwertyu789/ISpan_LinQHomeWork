
using MyHomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starter
{
    static class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //解決傳統的Windows Forms在高解析度（High DPI）設定下，所引發的文字模糊問題
            if (System.Environment.OSVersion.Version.Major >= 6) { SetProcessDPIAware(); }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Application.Run(new FrmHelloLinq());

            //Application.Run(new FrmLangForLINQ());
            //Application.Run(new FrmLINQ架構介紹_InsideLINQ());
            //Application.Run(new FrmLINQ_To_XXX());
            //Application.Run(new FrmLinq_To_Entity());

            Application.Run(new Frm作業_1()); 
        }
    }
}
