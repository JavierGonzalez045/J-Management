using Presentation.MessageBoxForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    static class Program
    {
        //Structs
        public struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color lightRed = Color.FromArgb(252, 87, 83);
            public static Color darkRed = Color.FromArgb(213, 39, 53);
            public static Color lightYellow = Color.FromArgb(253, 188, 64);
            public static Color darkYellow = Color.FromArgb(242, 179, 65);
            public static Color lightGreen = Color.FromArgb(54, 200, 75);
            public static Color darkGreen = Color.FromArgb(18, 193, 30);
            public static Color gainsboroColor = Color.FromArgb(220, 220, 220);
            public static Color lightBlue = Color.FromArgb(0, 113, 236);
            public static Color darkBlue = Color.FromArgb(23, 43, 77);
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}