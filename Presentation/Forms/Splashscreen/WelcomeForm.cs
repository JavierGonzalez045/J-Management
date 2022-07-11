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

namespace Presentation
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (this.Opacity < 1) this.Opacity += 0.05;
            //jmCustomProgressBar1.Value += 1;
            //if (jmCustomProgressBar1.Value == 100)
            //{
            //    timer1.Stop();
            //    timer2.Start();
            //}
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            //lblUsername.Text = $"{UserCache.FirsName} {UserCache.LastName}";
            //this.Opacity = 0.0;
            //jmCustomProgressBar1.Value = 0;
            //jmCustomProgressBar1.Minimum = 0;
            //jmCustomProgressBar1.Maximum = 100;
            //timer1.Start();
        }
    }
}
