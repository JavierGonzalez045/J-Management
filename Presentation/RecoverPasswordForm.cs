using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class RecoverPasswordForm : Form
    {
        public RecoverPasswordForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var user = new UserModel();
            var result = user.recoverPassword(txtUserRequest.Text);
            lblResult.Text = result;
        }
    }
}