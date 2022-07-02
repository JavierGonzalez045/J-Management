﻿using System;
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
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;

            if (panelPlaylistSubMenu.Visible == true)
                panelPlaylistSubMenu.Visible = false;

            if (panelToolsSubMenu.Visible == true)
                panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #region MediaSubMenu
        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form2());
            hideSubMenu();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        #endregion

        #region
        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Form3());
            hideSubMenu();
        }



        //hideSubMenu();




        #region ToolsSubMenu
        private void btnTools_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void iconButton12_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        #endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }


        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}