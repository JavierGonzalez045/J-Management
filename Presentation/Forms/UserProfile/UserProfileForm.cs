using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace Presentation.Forms.UserProfile
{
    public partial class UserProfileForm : Form
    {
        public UserProfileForm()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            loadUserData();
            initializePassEditControls();
        }

        private void loadUserData()
        {
            // View
            lblUser.Text = UserCache.LoginName;
            lblName.Text = UserCache.FirsName;
            lblLastName.Text = UserCache.LastName;
            lblMail.Text = UserCache.Email;
            lblPosition.Text = UserCache.Position;

            // Edit panel
            txtUsername.Texts = UserCache.LoginName;
            txtFirstName.Texts = UserCache.FirsName;
            txtLastName.Texts = UserCache.LastName;
            txtEmail.Texts = UserCache.Email;
            txtPassword.Texts = UserCache.Password;
            txtConfirmPass.Texts = UserCache.Password;
            txtCurrentPassword.Texts = "";
        }

        private void initializePassEditControls()
        {
            linkEditPass.Text = "Edit";
            txtPassword.Enabled = false;
            txtPassword.PasswordChar = true;
            txtConfirmPass.Enabled = false;
            txtConfirmPass.PasswordChar = true;
        }

        private void reset()
        {
            loadUserData();
            initializePassEditControls();
        }

        private void linkEditProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Panel1.Visible = true;
            loadUserData();
        }

        private void linkEditPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkEditPass.Text == "Edit")
            {
                linkEditPass.Text = "Cancel";
                txtPassword.Enabled = true;
                txtPassword.Texts = "";
                txtPassword.ForeColor = Color.Black;
                txtConfirmPass.Enabled = true;
                txtConfirmPass.Texts = "";
                txtConfirmPass.ForeColor = Color.Black;
            }
            else if(linkEditPass.Text == "Cancel")
            {
                initializePassEditControls();
                txtPassword.Texts = UserCache.Password;
                txtConfirmPass.Texts = UserCache.Password;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Texts.Length >= 5)
            {
                if (txtPassword.Texts == txtConfirmPass.Texts)
                {
                    if (txtCurrentPassword.Texts == UserCache.Password)
                    {
                        var userModel = new UserModel(
                            idUser: UserCache.idUser,
                            loginName: txtUsername.Texts,
                            password: txtPassword.Texts,
                            firstName: txtFirstName.Texts,
                            lastName: txtFirstName.Texts,
                            position: null,
                            email: txtEmail.Texts);
                        var result = userModel.editUserProfile();
                        MessageBox.Show(result);
                        reset();
                        Panel1.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña actual incorrecta, intente nuevamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden, intente nuevamente.");
                }
            }
            else
            {
                MessageBox.Show("La contraseña debe tener una longitud minima de 5 caracteres.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            reset();
        }
    }
}