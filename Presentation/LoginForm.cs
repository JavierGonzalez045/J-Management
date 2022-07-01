using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;
using Common.Cache;

namespace Presentation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // CON ESTO PODEMOS ARRASTRAR LOS FORMULARIOS
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // CON ESTO AL MOMENTO DE HACER CLICK EN EL INPUT DE USUARIO, EL TEXTO DESAPACERE, SIMULANDO UN PLACEHOLDER
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        // CON ESTO AL MOMENTO DE HACER CLICK EN OTRO INPUT, EL TEXTO DEL CAMPO USUARIO APARECE NUEVAMENTE, SIMULANDO UN PLACEHOLDER
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        // CON ESTO AL MOMENTO DE HACER CLICK EN EL INPUT DE CONTRASEÑA, EL TEXTO DESAPACERE, SIMULANDO UN PLACEHOLDER
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Trim() == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        // CON ESTO AL MOMENTO DE HACER CLICK EN OTRO INPUT, EL TEXTO DEL CAMPO CONTRASEÑA APARECE NUEVAMENTE, SIMULANDO UN PLACEHOLDER
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Trim() == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        // AL HACER CLICK EN ICONO DE LA X, SE CIERRA EL PROGRAMA
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // AL HACER CLICK EN ICONO DE GUION (-), SE MINIMIZA LA PANTALLA DE LOGIN
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // FUNCIÓN PARA ARRASTRAR LOS FORMULARIOS DE WINDOWS.
        private void arrastrarLogin()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrarLogin();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrarLogin();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "Usuario")
            {
                if (txtContraseña.Text != "Contraseña")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUsuario.Text.Trim(), txtContraseña.Text.Trim());
                    
                    if (validLogin == true)
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        mainForm.FormClosed += cerrarSesion;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Nombre de usuario o contraseña incorrecta.\nPor favor intente nuevamente.");
                        txtContraseña.Text = "Contraseña";
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    msgError("Debe ingresar la contraseña.");
                } 
            }
            else
            {
                msgError("Debe ingresar el nombre de usuario.");
            }
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = msg;
            lblErrorMessage.Visible = true;
            alertIcon.Visible = true;
        }

        private void cerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtContraseña.Text = "Contraseña";
            txtContraseña.UseSystemPasswordChar = false;
            txtUsuario.Text = "Usuario";
            alertIcon.Visible = false;
            lblErrorMessage.Visible = false;
            this.Show();
            //txtUsuario.Focus();
        }
    }
}