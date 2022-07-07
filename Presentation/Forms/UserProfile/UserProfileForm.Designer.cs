
namespace Presentation.Forms.UserProfile
{
    partial class UserProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileForm));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.linkEditPass = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCurrentPassword = new Presentation.Forms.Assets.JMCustomTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new Presentation.Forms.Assets.JMCustomTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPassword = new Presentation.Forms.Assets.JMCustomTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmail = new Presentation.Forms.Assets.JMCustomTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtLastName = new Presentation.Forms.Assets.JMCustomTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFirstName = new Presentation.Forms.Assets.JMCustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new Presentation.Forms.Assets.JMCustomTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkEditProfile = new System.Windows.Forms.LinkLabel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jmCirculePictureBox1 = new Presentation.Forms.J_Management_Controls.JMCirculePictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jmCirculePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(58)))));
            this.Panel1.Controls.Add(this.linkEditPass);
            this.Panel1.Controls.Add(this.btnSave);
            this.Panel1.Controls.Add(this.btnCancel);
            this.Panel1.Controls.Add(this.txtCurrentPassword);
            this.Panel1.Controls.Add(this.label19);
            this.Panel1.Controls.Add(this.txtConfirmPass);
            this.Panel1.Controls.Add(this.label18);
            this.Panel1.Controls.Add(this.txtPassword);
            this.Panel1.Controls.Add(this.label17);
            this.Panel1.Controls.Add(this.txtEmail);
            this.Panel1.Controls.Add(this.label16);
            this.Panel1.Controls.Add(this.txtLastName);
            this.Panel1.Controls.Add(this.label15);
            this.Panel1.Controls.Add(this.txtFirstName);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.txtUsername);
            this.Panel1.Controls.Add(this.label13);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel1.Location = new System.Drawing.Point(680, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(540, 885);
            this.Panel1.TabIndex = 10;
            this.Panel1.Visible = false;
            // 
            // linkEditPass
            // 
            this.linkEditPass.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkEditPass.AutoSize = true;
            this.linkEditPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkEditPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.linkEditPass.Location = new System.Drawing.Point(254, 516);
            this.linkEditPass.Name = "linkEditPass";
            this.linkEditPass.Size = new System.Drawing.Size(41, 22);
            this.linkEditPass.TabIndex = 30;
            this.linkEditPass.TabStop = true;
            this.linkEditPass.Text = "Edit";
            this.linkEditPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEditPass_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(184)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(288, 714);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 52);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(126)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(55, 714);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(210, 52);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtCurrentPassword.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtCurrentPassword.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.txtCurrentPassword.BorderSize = 3;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.Black;
            this.txtCurrentPassword.Location = new System.Drawing.Point(55, 629);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentPassword.Multiline = false;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtCurrentPassword.PasswordChar = true;
            this.txtCurrentPassword.Size = new System.Drawing.Size(443, 32);
            this.txtCurrentPassword.TabIndex = 18;
            this.txtCurrentPassword.Texts = "";
            this.txtCurrentPassword.UnderlinedStyle = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.Gainsboro;
            this.label19.Location = new System.Drawing.Point(53, 599);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(157, 22);
            this.label19.TabIndex = 17;
            this.label19.Text = "Current password:";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmPass.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtConfirmPass.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.txtConfirmPass.BorderSize = 3;
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtConfirmPass.Location = new System.Drawing.Point(55, 546);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPass.Multiline = false;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Padding = new System.Windows.Forms.Padding(7);
            this.txtConfirmPass.PasswordChar = false;
            this.txtConfirmPass.Size = new System.Drawing.Size(443, 32);
            this.txtConfirmPass.TabIndex = 16;
            this.txtConfirmPass.Texts = "";
            this.txtConfirmPass.UnderlinedStyle = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(53, 516);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(199, 22);
            this.label18.TabIndex = 15;
            this.label18.Text = "Confirm your password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.txtPassword.BorderSize = 3;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(55, 462);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.Size = new System.Drawing.Size(443, 32);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(53, 432);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 22);
            this.label17.TabIndex = 13;
            this.label17.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.txtEmail.BorderSize = 3;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(55, 375);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(443, 32);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(53, 345);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 22);
            this.label16.TabIndex = 11;
            this.label16.Text = "Email:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastName.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtLastName.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.txtLastName.BorderSize = 3;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.Location = new System.Drawing.Point(55, 290);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Padding = new System.Windows.Forms.Padding(7);
            this.txtLastName.PasswordChar = false;
            this.txtLastName.Size = new System.Drawing.Size(443, 32);
            this.txtLastName.TabIndex = 10;
            this.txtLastName.Texts = "";
            this.txtLastName.UnderlinedStyle = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(53, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 22);
            this.label15.TabIndex = 9;
            this.label15.Text = "Last name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtFirstName.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFirstName.BorderSize = 3;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(55, 205);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Padding = new System.Windows.Forms.Padding(7);
            this.txtFirstName.PasswordChar = false;
            this.txtFirstName.Size = new System.Drawing.Size(443, 32);
            this.txtFirstName.TabIndex = 8;
            this.txtFirstName.Texts = "";
            this.txtFirstName.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(53, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "First name:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtUsername.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.txtUsername.BorderSize = 3;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(55, 121);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.Size = new System.Drawing.Size(443, 32);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(53, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 22);
            this.label13.TabIndex = 5;
            this.label13.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(53, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Editar datos";
            // 
            // linkEditProfile
            // 
            this.linkEditProfile.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkEditProfile.AutoSize = true;
            this.linkEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkEditProfile.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(202)))));
            this.linkEditProfile.Location = new System.Drawing.Point(269, 480);
            this.linkEditProfile.Name = "linkEditProfile";
            this.linkEditProfile.Size = new System.Drawing.Size(108, 25);
            this.linkEditProfile.TabIndex = 28;
            this.linkEditProfile.TabStop = true;
            this.linkEditProfile.Text = "Editar perfil";
            this.linkEditProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEditProfile_LinkClicked);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPosition.ForeColor = System.Drawing.Color.DimGray;
            this.lblPosition.Location = new System.Drawing.Point(380, 367);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(72, 22);
            this.lblPosition.TabIndex = 27;
            this.lblPosition.Text = "position";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMail.ForeColor = System.Drawing.Color.DimGray;
            this.lblMail.Location = new System.Drawing.Point(381, 305);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(52, 22);
            this.lblMail.TabIndex = 26;
            this.lblMail.Text = "email";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.ForeColor = System.Drawing.Color.DimGray;
            this.lblLastName.Location = new System.Drawing.Point(380, 240);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(85, 22);
            this.lblLastName.TabIndex = 25;
            this.lblLastName.Text = "lastName";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.DimGray;
            this.lblName.Location = new System.Drawing.Point(381, 176);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 22);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "name";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.DimGray;
            this.lblUser.Location = new System.Drawing.Point(381, 115);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(45, 22);
            this.lblUser.TabIndex = 23;
            this.lblUser.Text = "user";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(380, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Position:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(381, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(380, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Last name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(381, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(381, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Username:";
            // 
            // jmCirculePictureBox1
            // 
            this.jmCirculePictureBox1.BoderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.jmCirculePictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.jmCirculePictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(236)))));
            this.jmCirculePictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(119)))));
            this.jmCirculePictureBox1.BorderSize = 10;
            this.jmCirculePictureBox1.GradientAngle = 50F;
            this.jmCirculePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("jmCirculePictureBox1.Image")));
            this.jmCirculePictureBox1.Location = new System.Drawing.Point(82, 91);
            this.jmCirculePictureBox1.Name = "jmCirculePictureBox1";
            this.jmCirculePictureBox1.Size = new System.Drawing.Size(262, 262);
            this.jmCirculePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jmCirculePictureBox1.TabIndex = 17;
            this.jmCirculePictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.SlateGray;
            this.label14.Location = new System.Drawing.Point(163, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 37);
            this.label14.TabIndex = 29;
            this.label14.Text = "Mi perfil";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.ForeColor = System.Drawing.Color.SlateGray;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnClose.IconColor = System.Drawing.Color.SlateGray;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 31;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 31);
            this.btnClose.TabIndex = 30;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 885);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.linkEditProfile);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.jmCirculePictureBox1);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1220, 885);
            this.Name = "UserProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserProfileForm";
            this.Load += new System.EventHandler(this.UserProfileForm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jmCirculePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private Assets.JMCustomTextBox txtUsername;
        private System.Windows.Forms.LinkLabel linkEditProfile;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private J_Management_Controls.JMCirculePictureBox jmCirculePictureBox1;
        private System.Windows.Forms.Label label14;
        private Assets.JMCustomTextBox txtConfirmPass;
        private System.Windows.Forms.Label label18;
        private Assets.JMCustomTextBox txtPassword;
        private System.Windows.Forms.Label label17;
        private Assets.JMCustomTextBox txtEmail;
        private System.Windows.Forms.Label label16;
        private Assets.JMCustomTextBox txtLastName;
        private System.Windows.Forms.Label label15;
        private Assets.JMCustomTextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private Assets.JMCustomTextBox txtCurrentPassword;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel linkEditPass;
        private FontAwesome.Sharp.IconPictureBox btnClose;
    }
}