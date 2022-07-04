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

        public LogoutMessageBox(string text, string caption, MessageBoxButtons buttons)
        {
            InitializeComponent();
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
        }

        public LogoutMessageBox(string text, string caption, MessageBoxButtons buttons, Icons icon)
        {
            InitializeComponent();
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
            SetIcon(icon);
        }

        public void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            switch (buttons)
            {
                case MessageBoxButtons.YesNo:
                    //Yes Button
                    btnYes.Visible = true;
                    btnYes.Text = "Si";
                    btnYes.DialogResult = DialogResult.Yes;//Set DialogResult

                    //No Button
                    btnNo.Visible = true;
                    btnNo.Text = "No";
                    btnNo.DialogResult = DialogResult.No;//Set DialogResult
                    break;
                default:
                    break;
            }

        }

        private void SetIcon(Icons icon)
        {
            switch (icon)
            {
                case Icons.Error: //Error
                    this.pictureBoxIcon.Image = Properties.Resources.error;
                    //PrimaryColor = Color.FromArgb(224, 79, 95);
                    break;

                case Icons.Chat: //Error
                    this.pictureBoxIcon.Image = Properties.Resources.chat;
                    //PrimaryColor = Color.FromArgb(224, 79, 95);
                    break;

                case Icons.Exclamation: //Error
                    this.pictureBoxIcon.Image = Properties.Resources.exclamation;
                    //PrimaryColor = Color.FromArgb(224, 79, 95);
                    break;

                case Icons.Information: //Error
                    this.pictureBoxIcon.Image = Properties.Resources.information;
                    //PrimaryColor = Color.FromArgb(224, 79, 95);
                    break;

                case Icons.Question: //Error
                    this.pictureBoxIcon.Image = Properties.Resources.question;
                    //PrimaryColor = Color.FromArgb(224, 79, 95);
                    break;
            }
        }
        public void closeMessageBox()
        {
            this.Close();
        }
    }
}