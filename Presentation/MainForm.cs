using Common.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void LoadUserData()
        {
            lblName.Text = $"{UserLoginCache.FirsName} {UserLoginCache.LastName}";
            lblPosition.Text = UserLoginCache.Position;
            lblEmail.Text = UserLoginCache.Email;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
    }
}
