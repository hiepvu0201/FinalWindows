using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace QuanLyRapPhim_Final
{
    static class Program
    {
        public static Pen myPen;
        public static Color myColor;
        public static int hangGhe = 0;
        public static int soGhe = 0;
        public static string clickbtn = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            myColor = Color.Red;
            myPen = new Pen(Program.myColor, 1);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
