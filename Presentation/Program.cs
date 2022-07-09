using Presentation.Forms.UserProfile;
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

        /*  GUIA PARA USA EL CUSTOM DROPDOWN MENU
         * 
         *  CUANTO SE LE QUIERE ASIGNAR UN DROPDOWN PERSONALIZADO A UN BOTON, SE LE HACE DOBLE CLICK
         *  PARA ENTRAR AL EVENTO CLICK DEL BOTON Y SE ESCRIBE LO SIGUIENTE:
         *  
         *  jmCustomDropdownMenu1.Show(iconButton1, iconButton1.Width, 0);
         *  
         *  ESTO CREA EL DROPDOWN PERSONALIZADO, PERO ESTE SE VERA DE COLOR BLANCO, SI DESEA VERLO DE
         *  COLOR NEGRO, EN EL EVENTO LOAD DEL FORMULARIO SE ESCRIBE LO SIGUIENTE:
         *  
         *  jmCustomDropdownMenu1.IsMainMenu = true;
         *  
         *  ESTO VOLVERA EL DROPDOWN PERSONALIZADO DE COLOR NEGRO CON MORADO.
         *  
         *  POR ULTIMO, PARA CAMBIAR LOS COLORES DEL DROPDOWN PERSONALIZADO, EN EL EVENTO LOAD DEL FORMULARIO
         *  SE ESTABLECEN LOS COLORES QUE SE DESEAN USAR, POR EJEMPLO:
         *  
         *  jmCustomDropdownMenu1.IsMainMenu = true;
         *  jmCustomDropdownMenu1.PrimaryColor = Color.Red;
         *  jmCustomDropdownMenu1.MenuItemTextColor = Color.Blue;
         *  
         *  
         *  FIN DE LA GUIA.
         */

        //Structs
        public struct RGBColors
        {
            public static Color lightRed = Color.FromArgb(252, 87, 83);
            public static Color darkRed = Color.FromArgb(213, 39, 53);
            public static Color lightYellow = Color.FromArgb(253, 188, 64);
            public static Color darkYellow = Color.FromArgb(242, 179, 65);
            public static Color lightGreen = Color.FromArgb(54, 200, 75);
            public static Color darkGreen = Color.FromArgb(18, 193, 30);
            public static Color gainsboroColor = Color.FromArgb(220, 220, 220);
            public static Color lightBlue = Color.FromArgb(0, 113, 236);
            public static Color darkBlue = Color.FromArgb(23, 43, 77);
            public static Color customBorderColor = Color.FromArgb(30, 140, 236);
            public static Color customBorderColor2 = Color.FromArgb(32, 128, 119);

            // WHITE THEME
            public static Color lightGray = Color.FromArgb(189, 194, 196);
            public static Color panelShadowLight = Color.FromArgb(126, 129, 130);
            public static Color panelChildFormLight = Color.FromArgb(227, 227, 226);
            public static Color panelSidebarLight = Color.FromArgb(0, 153, 254);
            public static Color anotherShadeOfBlue = Color.FromArgb(0, 102, 255);
            public static Color deepSkyBlue = Color.FromArgb(0, 191, 255);

            // DARK THEME
            public static Color panelShadowDark = Color.FromArgb(26, 24, 58);
            public static Color panelChildFormDark = Color.FromArgb(5, 17, 58);
            public static Color panelSidebarDark = Color.FromArgb(14, 14, 35);
            public static Color panelSubMenusDark = Color.FromArgb(35, 32, 39);
            public static Color activeDarkBlue = Color.FromArgb(13, 8, 20);
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