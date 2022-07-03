using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Presentation.Program;

namespace Presentation.MessageBoxForm
{
    public partial class LogoutMessageBox : Form
    {
        public LogoutMessageBox()
        {
            InitializeComponent();
        }

        private void btnCloseMessageBox_MouseHover(object sender, EventArgs e)
        {
            btnCloseMessageBox.BackColor = RGBColors.lightRed;
        }

        private void btnCloseMessageBox_MouseLeave(object sender, EventArgs e)
        {
            btnCloseMessageBox.BackColor = RGBColors.darkBlue;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void arrastrarMessageBox()
        {
            dragForm.ReleaseCapture();
            dragForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrarMessageBox();
        }

        private void btnCloseMessageBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNo_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}