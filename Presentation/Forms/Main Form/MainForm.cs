using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;
using FontAwesome.Sharp;
using Presentation.Forms.UserProfile;
using Presentation.MessageBoxForm;
using static Presentation.Program;

namespace Presentation
{
    public partial class MainForm : Form
    {
        CustomMessageBox frmCustomBox = new CustomMessageBox();

        // Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public void setButtonStyle(Button button)
        {
            button.ForeColor = Color.Gainsboro;
            if (tbSwitchTheme.Checked)
            {
                button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            }
            else
            {
                button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        public void setLabelStyle(Label label)
        {
            label.ForeColor = Color.Gainsboro;
            if (tbSwitchTheme.Checked)
            {
                label.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            }
            else
            {
                label.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        public void setIconButtonStyle(IconButton iconButton)
        {
            if (tbSwitchTheme.Checked)
            {
                iconButton.ForeColor = RGBColors.deepSkyBlue;
                iconButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            }
            else
            {
                iconButton.ForeColor = Color.LightGray;
                iconButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        public void setThemeButtons(object sender)
        {
            if (tbSwitchTheme.Checked)
            {
                ActivateButton(sender, RGBColors.anotherShadeOfBlue);
            }
            else
            {
                ActivateButton(sender, RGBColors.activeDarkBlue);
            }
        }

        // Constructor
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            panelSidebar.Controls.Add(leftBorderBtn);
            // Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                if (tbSwitchTheme.Checked)
                {
                    // Button
                    currentBtn = (IconButton)senderBtn;
                    currentBtn.BackColor = Color.FromArgb(11, 170, 247);
                    currentBtn.ForeColor = color;
                    currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                    currentBtn.IconColor = color;
                    //Left border button
                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                    //Current Child Form Icon
                    iconCurrentChildForm.IconChar = currentBtn.IconChar;
                    iconCurrentChildForm.IconColor = color;
                }
                else
                {
                    // Button
                    currentBtn = (IconButton)senderBtn;
                    currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                    currentBtn.ForeColor = color;
                    currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                    currentBtn.IconColor = color;
                    //Left border button
                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                    //Current Child Form Icon
                    iconCurrentChildForm.IconChar = currentBtn.IconChar;
                    iconCurrentChildForm.IconColor = color;
                }
            }
            DisableButton();
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                if (tbSwitchTheme.Checked)
                {
                    currentBtn.BackColor = Color.FromArgb(11, 170, 247);
                    currentBtn.ForeColor = Color.Gainsboro;
                    currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                    currentBtn.IconColor = Color.Gainsboro;
                    currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    currentBtn.BackColor = Color.FromArgb(11, 7, 17);
                    currentBtn.ForeColor = Color.Gainsboro;
                    currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                    currentBtn.IconColor = Color.Gainsboro;
                    currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                }
            }
        }

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // Open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
            lblTitleChildForm.Text = currentBtn.Text;
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
            if (tbSwitchTheme.Checked)
            {
                ActivateButton(sender, RGBColors.anotherShadeOfBlue);
            }
            else
            {
                ActivateButton(sender, RGBColors.anotherShadeOfBlue);
            }
            showSubMenu(panelMediaSubMenu);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
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

        #endregion PlaylistSubMenu

        #region
        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            if (tbSwitchTheme.Checked)
            {
                ActivateButton(sender, RGBColors.lightBlue);
            }
            else
            {
                ActivateButton(sender, RGBColors.activeDarkBlue);
            }
            showSubMenu(panelPlaylistSubMenu);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.lightBlue);
            openChildForm(new Form3());
        }

        #region ToolsSubMenu
        private void btnTools_Click(object sender, EventArgs e)
        {
            if (tbSwitchTheme.Checked)
            {
                ActivateButton(sender, RGBColors.lightBlue);
            }
            else
            {
                ActivateButton(sender, RGBColors.activeDarkBlue);
            }
            showSubMenu(panelToolsSubMenu);
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        #endregion


        private void btnHelp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.lightBlue);
            openChildForm(new UserProfileForm());
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
        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (currentChildForm == null)
            {
                Reset();
            }
            else
            {
                currentChildForm.Close();
                Reset();
            }
        }

        private void Reset()
        {
            DisableButton();
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Inicio";
        }


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragForm.ReleaseCapture();
            dragForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (ResultMessageBox.Show("¿Está seguro que desea salir?",
                "Salir", MessageBoxButtons.YesNo, EIcons.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                frmCustomBox.closeMessageBox();
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btnClose.ForeColor = RGBColors.darkRed;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Circle;
            btnClose.ForeColor = RGBColors.lightRed;
        }

        private void btnMaximize_MouseHover(object sender, EventArgs e)
        {
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.CircleChevronUp;
            btnMaximize.ForeColor = RGBColors.darkGreen;
        }

        private void btnMaximize_MouseLeave(object sender, EventArgs e)
        {
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Circle;
            btnMaximize.ForeColor = RGBColors.lightGreen;
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            btnMinimize.ForeColor = RGBColors.darkYellow;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Circle;
            btnMinimize.ForeColor = RGBColors.lightYellow;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelSidebar.Width > 200)
            {
                panelSidebar.Width = 100;
                btnInicio.Visible = false;
                lblOpacidad.Visible = false;
                lblEstadoOpacidad.Visible = false;
                tbOpacidad.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                this.panelLogo.Padding = new Padding(0,20,0,0);
                foreach (Button menuButton in panelSidebar.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelSidebar.Width = 250;
                btnInicio.Visible = true;
                btnMenu.Dock = DockStyle.None;
                lblOpacidad.Visible = true;
                lblEstadoOpacidad.Visible = true;
                tbOpacidad.Visible = true;
                foreach (Button menuButton in panelSidebar.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.IconColor = RGBColors.lightBlue;
            btnLogout.ForeColor = RGBColors.lightBlue;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.IconColor = RGBColors.gainsboroColor;
            btnLogout.ForeColor = RGBColors.gainsboroColor;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (ResultMessageBox.Show("¿Está seguro que desea cerrar sesión?",
                "Cerrar sesión", MessageBoxButtons.YesNo, EIcons.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                frmCustomBox.closeMessageBox();
            }
        }

        private void loadUserData()
        {
            //lblCargo.Text = UserCache.Position;
            //lblNombre.Text = $"{UserCache.FirsName} {UserCache.LastName}";
            //lblCorreo.Text = UserCache.Email;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //loadUserData();

            // ADMINISTRAR PERMISOS
            if (UserCache.Position == Positions.Accounting)
            {
                btnEqualizer.Enabled = false;
                btnEqualizer.Visible = false;
            }
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToString("ddd dd, MMMM yyyy");
        }
         
        private void tbOpacidad_CheckedChanged(object sender, EventArgs e)
        {
            if (tbOpacidad.Checked)
            {
                this.Opacity = 0.9D;
                lblEstadoOpacidad.Text = "Desactivar";
                lblEstadoOpacidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            }
            else
            {
                this.Opacity = 1.0D;
                lblEstadoOpacidad.Text = "Activar";
                lblEstadoOpacidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        public void SetTheme()
        {
            #region btnMedia
            setThemeButtons(btnMedia);

            setIconButtonStyle(iconButton1);
            setIconButtonStyle(iconButton2);
            setIconButtonStyle(iconButton3);
            setIconButtonStyle(iconButton4);
            #endregion

            #region btnPlaylist
            setThemeButtons(btnPlaylist);

            setIconButtonStyle(iconButton5);
            setIconButtonStyle(iconButton6);
            setIconButtonStyle(iconButton7);
            setIconButtonStyle(iconButton8);
            #endregion

            // btnEqualizer

            setThemeButtons(btnEqualizer);


            #region btnTools
            setThemeButtons(btnTools);

            setIconButtonStyle(iconButton9);
            setIconButtonStyle(iconButton10);
            setIconButtonStyle(iconButton11);
            setIconButtonStyle(iconButton12);
            #endregion

            // btnHelp
            setThemeButtons(btnHelp);
        }

        private void tbSwitchTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (tbSwitchTheme.Checked)
            {
                iconCurrentChildForm.IconChar = IconChar.Home;
                iconCurrentChildForm.BackColor = RGBColors.lightGray;
                iconCurrentChildForm.ForeColor = Color.SlateGray;
                panelMediaSubMenu.BackColor = Color.Gainsboro;
                panelPlaylistSubMenu.BackColor = Color.Gainsboro;
                panelToolsSubMenu.BackColor = Color.Gainsboro;
                panelTitleBar.BackColor = RGBColors.lightGray;
                panelShadow.BackColor = RGBColors.panelShadowLight;
                panelChildForm.BackColor = RGBColors.panelChildFormLight;
                btnInicio.Image = Properties.Resources.J_MANAGEMENT_WHITE_LOGO;
                panelSidebar.BackColor = RGBColors.panelSidebarLight;
                iconMoon.ForeColor = Color.White;
                iconSun.ForeColor = Color.DimGray;
                ActivateButton(sender, RGBColors.anotherShadeOfBlue);

                SetTheme();

                // Opacity controls
                setLabelStyle(lblOpacidad);
                tbOpacidad.OffBackColor = Color.DimGray;
                tbOpacidad.OnBackColor = Color.Navy;
                btnLogout.ForeColor = Color.Gainsboro;
            }
            else
            {
                panelMediaSubMenu.BackColor = RGBColors.panelSubMenusDark;
                panelPlaylistSubMenu.BackColor = RGBColors.panelSubMenusDark;
                panelToolsSubMenu.BackColor = RGBColors.panelSubMenusDark;
                iconCurrentChildForm.BackColor = RGBColors.darkBlue;
                iconCurrentChildForm.IconChar = IconChar.Home;
                panelTitleBar.BackColor = RGBColors.darkBlue;
                panelShadow.BackColor = RGBColors.panelShadowDark;
                panelChildForm.BackColor = RGBColors.panelChildFormDark;
                btnInicio.Image = Properties.Resources.J_MANAGEMENT_LIGHT_BLUE_LOGO;
                panelSidebar.BackColor = RGBColors.panelSidebarDark;
                iconMoon.ForeColor = Color.DeepSkyBlue;
                iconSun.ForeColor = Color.White;

                SetTheme();

                // Opacity controls
                setLabelStyle(lblOpacidad);
                tbOpacidad.OffBackColor = Color.DimGray;
                tbOpacidad.OnBackColor = Color.DodgerBlue;
                btnLogout.ForeColor = Color.Gainsboro;
                btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }
    }
}