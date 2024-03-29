﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}