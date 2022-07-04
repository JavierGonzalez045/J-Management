using Domain;
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
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
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

        public CustomMessageBox(string text, string caption, MessageBoxButtons buttons)
        {
            InitializeComponent();
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
        }

        public CustomMessageBox(string text, string caption, MessageBoxButtons buttons, EIcons icon)
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

        private void SetIcon(EIcons icon)
        {
            switch (icon)
            {
                case EIcons.Error: // Error icon
                    this.pictureBoxIcon.Image = Properties.Resources.error;
                    break;

                case EIcons.Chat: // Chat icon
                    this.pictureBoxIcon.Image = Properties.Resources.chat;
                    break;

                case EIcons.Exclamation: // Exclamation icon
                    this.pictureBoxIcon.Image = Properties.Resources.exclamation;
                    panelTitleBar.BackColor = RGBColors.darkRed;
                    btnCloseMessageBox.BackColor = RGBColors.darkRed;
                    break;

                case EIcons.Information: // Information icon
                    this.pictureBoxIcon.Image = Properties.Resources.information;
                    break;

                case EIcons.Question: // Question icon
                    this.pictureBoxIcon.Image = Properties.Resources.question;
                    panelTitleBar.BackColor = RGBColors.darkBlue;
                    btnCloseMessageBox.BackColor = RGBColors.darkBlue;
                    break;
            }
        }
        public void closeMessageBox()
        {
            this.Close();
        }
    }
}