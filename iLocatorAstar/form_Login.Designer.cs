namespace iLocatorAstar
{
    partial class form_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Login));
            this.lbl_FormTitle = new System.Windows.Forms.Label();
            this.panel_ControlBox = new System.Windows.Forms.Panel();
            this.pb_iLocatorLogo = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.bunifuTxtBox_Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControlBox = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuTxtBox_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_AdminLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_iLocatorLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.AutoSize = true;
            this.lbl_FormTitle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_FormTitle.Location = new System.Drawing.Point(37, 10);
            this.lbl_FormTitle.Name = "lbl_FormTitle";
            this.lbl_FormTitle.Size = new System.Drawing.Size(140, 16);
            this.lbl_FormTitle.TabIndex = 2;
            this.lbl_FormTitle.Text = "iLocator | Admin Login";
            // 
            // panel_ControlBox
            // 
            this.panel_ControlBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_ControlBox.Controls.Add(this.pb_iLocatorLogo);
            this.panel_ControlBox.Controls.Add(this.lbl_FormTitle);
            this.panel_ControlBox.Controls.Add(this.btn_Close);
            this.panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ControlBox.Location = new System.Drawing.Point(0, 0);
            this.panel_ControlBox.Name = "panel_ControlBox";
            this.panel_ControlBox.Size = new System.Drawing.Size(576, 34);
            this.panel_ControlBox.TabIndex = 2;
            // 
            // pb_iLocatorLogo
            // 
            this.pb_iLocatorLogo.BackColor = System.Drawing.Color.Transparent;
            this.pb_iLocatorLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_iLocatorLogo.BackgroundImage")));
            this.pb_iLocatorLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_iLocatorLogo.Location = new System.Drawing.Point(9, 5);
            this.pb_iLocatorLogo.Name = "pb_iLocatorLogo";
            this.pb_iLocatorLogo.Size = new System.Drawing.Size(25, 25);
            this.pb_iLocatorLogo.TabIndex = 3;
            this.pb_iLocatorLogo.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Location = new System.Drawing.Point(549, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(19, 27);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // bunifuTxtBox_Username
            // 
            this.bunifuTxtBox_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTxtBox_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTxtBox_Username.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTxtBox_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuTxtBox_Username.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuTxtBox_Username.HintText = "";
            this.bunifuTxtBox_Username.isPassword = false;
            this.bunifuTxtBox_Username.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.bunifuTxtBox_Username.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuTxtBox_Username.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.bunifuTxtBox_Username.LineThickness = 4;
            this.bunifuTxtBox_Username.Location = new System.Drawing.Point(21, 187);
            this.bunifuTxtBox_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuTxtBox_Username.Name = "bunifuTxtBox_Username";
            this.bunifuTxtBox_Username.Size = new System.Drawing.Size(461, 39);
            this.bunifuTxtBox_Username.TabIndex = 0;
            this.bunifuTxtBox_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTxtBox_Username.Enter += new System.EventHandler(this.bunifuTxtBox_Username_Enter);
            this.bunifuTxtBox_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuTxtBox_Username_KeyDown);
            this.bunifuTxtBox_Username.Leave += new System.EventHandler(this.bunifuTxtBox_Username_Leave);
            // 
            // bunifuDragControlBox
            // 
            this.bunifuDragControlBox.Fixed = true;
            this.bunifuDragControlBox.Horizontal = true;
            this.bunifuDragControlBox.TargetControl = this.panel_ControlBox;
            this.bunifuDragControlBox.Vertical = true;
            // 
            // bunifuTxtBox_Password
            // 
            this.bunifuTxtBox_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTxtBox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTxtBox_Password.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTxtBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuTxtBox_Password.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuTxtBox_Password.HintText = "";
            this.bunifuTxtBox_Password.isPassword = false;
            this.bunifuTxtBox_Password.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.bunifuTxtBox_Password.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuTxtBox_Password.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.bunifuTxtBox_Password.LineThickness = 4;
            this.bunifuTxtBox_Password.Location = new System.Drawing.Point(21, 283);
            this.bunifuTxtBox_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuTxtBox_Password.Name = "bunifuTxtBox_Password";
            this.bunifuTxtBox_Password.Size = new System.Drawing.Size(461, 39);
            this.bunifuTxtBox_Password.TabIndex = 1;
            this.bunifuTxtBox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTxtBox_Password.Enter += new System.EventHandler(this.bunifuTxtBox_Password_Enter);
            this.bunifuTxtBox_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuTxtBox_Password_KeyDown);
            this.bunifuTxtBox_Password.Leave += new System.EventHandler(this.bunifuTxtBox_Password_Leave);
            // 
            // btn_AdminLogin
            // 
            this.btn_AdminLogin.Activecolor = System.Drawing.Color.Cyan;
            this.btn_AdminLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AdminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AdminLogin.BorderRadius = 0;
            this.btn_AdminLogin.ButtonText = "LOGIN";
            this.btn_AdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AdminLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AdminLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AdminLogin.Iconimage = null;
            this.btn_AdminLogin.Iconimage_right = null;
            this.btn_AdminLogin.Iconimage_right_Selected = null;
            this.btn_AdminLogin.Iconimage_Selected = null;
            this.btn_AdminLogin.IconMarginLeft = 0;
            this.btn_AdminLogin.IconMarginRight = 0;
            this.btn_AdminLogin.IconRightVisible = true;
            this.btn_AdminLogin.IconRightZoom = 0D;
            this.btn_AdminLogin.IconVisible = true;
            this.btn_AdminLogin.IconZoom = 90D;
            this.btn_AdminLogin.IsTab = false;
            this.btn_AdminLogin.Location = new System.Drawing.Point(160, 396);
            this.btn_AdminLogin.Name = "btn_AdminLogin";
            this.btn_AdminLogin.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_AdminLogin.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btn_AdminLogin.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_AdminLogin.selected = false;
            this.btn_AdminLogin.Size = new System.Drawing.Size(186, 48);
            this.btn_AdminLogin.TabIndex = 2;
            this.btn_AdminLogin.Text = "LOGIN";
            this.btn_AdminLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AdminLogin.Textcolor = System.Drawing.Color.White;
            this.btn_AdminLogin.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminLogin.Click += new System.EventHandler(this.btn_AdminLogin_Click);
            this.btn_AdminLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_AdminLogin_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuTxtBox_Username);
            this.panel1.Controls.Add(this.btn_AdminLogin);
            this.panel1.Controls.Add(this.bunifuTxtBox_Password);
            this.panel1.Location = new System.Drawing.Point(40, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 472);
            this.panel1.TabIndex = 5;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(153, 122);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(191, 41);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Admin Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(194, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 96);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(576, 549);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_ControlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iLocator - Admin Login";
            this.Load += new System.EventHandler(this.form_Login_Load);
            this.panel_ControlBox.ResumeLayout(false);
            this.panel_ControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_iLocatorLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_iLocatorLogo;
        private System.Windows.Forms.Label lbl_FormTitle;
        private System.Windows.Forms.Panel panel_ControlBox;
        private System.Windows.Forms.PictureBox btn_Close;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuTxtBox_Username;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuTxtBox_Password;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AdminLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}