namespace iLocatorAstar
{
    partial class form_SelectUser
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_SelectUser));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.panel_ContainerUniverse = new System.Windows.Forms.Panel();
            this.lbl_TimeToday = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_ContainerSelectUser = new System.Windows.Forms.Panel();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.tableLayoutPanel_SelectUser = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Parents = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Alumni = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Guest = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Student = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Back = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel_ControlBox = new System.Windows.Forms.Panel();
            this.pb_iLocatorLogo = new System.Windows.Forms.PictureBox();
            this.lbl_FormTitle = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.idleTime = new System.Windows.Forms.Timer(this.components);
            this.time_Timer = new System.Windows.Forms.Timer(this.components);
            this.bunifuFadeTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel_ContainerUniverse.SuspendLayout();
            this.panel_ContainerSelectUser.SuspendLayout();
            this.tableLayoutPanel_SelectUser.SuspendLayout();
            this.panel_ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_iLocatorLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ContainerUniverse
            // 
            this.panel_ContainerUniverse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ContainerUniverse.Controls.Add(this.lbl_TimeToday);
            this.panel_ContainerUniverse.Controls.Add(this.panel_ContainerSelectUser);
            this.bunifuFadeTransition.SetDecoration(this.panel_ContainerUniverse, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel_ContainerUniverse, BunifuAnimatorNS.DecorationType.None);
            this.panel_ContainerUniverse.Location = new System.Drawing.Point(12, 47);
            this.panel_ContainerUniverse.Name = "panel_ContainerUniverse";
            this.panel_ContainerUniverse.Size = new System.Drawing.Size(996, 438);
            this.panel_ContainerUniverse.TabIndex = 2;
            // 
            // lbl_TimeToday
            // 
            this.lbl_TimeToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_TimeToday.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbl_TimeToday, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.lbl_TimeToday, BunifuAnimatorNS.DecorationType.None);
            this.lbl_TimeToday.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeToday.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_TimeToday.Location = new System.Drawing.Point(4, 417);
            this.lbl_TimeToday.Name = "lbl_TimeToday";
            this.lbl_TimeToday.Size = new System.Drawing.Size(11, 17);
            this.lbl_TimeToday.TabIndex = 7;
            this.lbl_TimeToday.Text = " ";
            this.lbl_TimeToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TimeToday.Visible = false;
            // 
            // panel_ContainerSelectUser
            // 
            this.panel_ContainerSelectUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_ContainerSelectUser.Controls.Add(this.lbl_Description);
            this.panel_ContainerSelectUser.Controls.Add(this.tableLayoutPanel_SelectUser);
            this.bunifuFadeTransition.SetDecoration(this.panel_ContainerSelectUser, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel_ContainerSelectUser, BunifuAnimatorNS.DecorationType.None);
            this.panel_ContainerSelectUser.Location = new System.Drawing.Point(7, 3);
            this.panel_ContainerSelectUser.Name = "panel_ContainerSelectUser";
            this.panel_ContainerSelectUser.Size = new System.Drawing.Size(970, 431);
            this.panel_ContainerSelectUser.TabIndex = 5;
            // 
            // lbl_Description
            // 
            this.lbl_Description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Description.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbl_Description, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.lbl_Description, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Description.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Description.Location = new System.Drawing.Point(200, 16);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(572, 66);
            this.lbl_Description.TabIndex = 5;
            this.lbl_Description.Text = "Let us know who you are";
            this.lbl_Description.Visible = false;
            // 
            // tableLayoutPanel_SelectUser
            // 
            this.tableLayoutPanel_SelectUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel_SelectUser.ColumnCount = 9;
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.851852F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.851852F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.851852F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.851852F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel_SelectUser.Controls.Add(this.btn_Parents, 8, 0);
            this.tableLayoutPanel_SelectUser.Controls.Add(this.btn_Alumni, 6, 0);
            this.tableLayoutPanel_SelectUser.Controls.Add(this.btn_Guest, 4, 0);
            this.tableLayoutPanel_SelectUser.Controls.Add(this.btn_Student, 2, 0);
            this.tableLayoutPanel_SelectUser.Controls.Add(this.btn_Back, 0, 0);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel_SelectUser, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.tableLayoutPanel_SelectUser, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel_SelectUser.Location = new System.Drawing.Point(15, 97);
            this.tableLayoutPanel_SelectUser.Name = "tableLayoutPanel_SelectUser";
            this.tableLayoutPanel_SelectUser.RowCount = 1;
            this.tableLayoutPanel_SelectUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_SelectUser.Size = new System.Drawing.Size(938, 303);
            this.tableLayoutPanel_SelectUser.TabIndex = 4;
            this.tableLayoutPanel_SelectUser.Visible = false;
            // 
            // btn_Parents
            // 
            this.btn_Parents.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Parents.color = System.Drawing.Color.RoyalBlue;
            this.btn_Parents.colorActive = System.Drawing.Color.SkyBlue;
            this.btn_Parents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFadeTransition.SetDecoration(this.btn_Parents, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btn_Parents, BunifuAnimatorNS.DecorationType.None);
            this.btn_Parents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Parents.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn_Parents.ForeColor = System.Drawing.Color.White;
            this.btn_Parents.Image = ((System.Drawing.Image)(resources.GetObject("btn_Parents.Image")));
            this.btn_Parents.ImagePosition = 28;
            this.btn_Parents.ImageZoom = 50;
            this.btn_Parents.LabelPosition = 56;
            this.btn_Parents.LabelText = "Parent/s";
            this.btn_Parents.Location = new System.Drawing.Point(766, 7);
            this.btn_Parents.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Parents.Name = "btn_Parents";
            this.btn_Parents.Size = new System.Drawing.Size(166, 289);
            this.btn_Parents.TabIndex = 2;
            this.btn_Parents.Click += new System.EventHandler(this.btnClick);
            // 
            // btn_Alumni
            // 
            this.btn_Alumni.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Alumni.color = System.Drawing.Color.RoyalBlue;
            this.btn_Alumni.colorActive = System.Drawing.Color.SkyBlue;
            this.btn_Alumni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFadeTransition.SetDecoration(this.btn_Alumni, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btn_Alumni, BunifuAnimatorNS.DecorationType.None);
            this.btn_Alumni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Alumni.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn_Alumni.ForeColor = System.Drawing.Color.White;
            this.btn_Alumni.Image = ((System.Drawing.Image)(resources.GetObject("btn_Alumni.Image")));
            this.btn_Alumni.ImagePosition = 28;
            this.btn_Alumni.ImageZoom = 50;
            this.btn_Alumni.LabelPosition = 56;
            this.btn_Alumni.LabelText = "Alumni";
            this.btn_Alumni.Location = new System.Drawing.Point(576, 7);
            this.btn_Alumni.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Alumni.Name = "btn_Alumni";
            this.btn_Alumni.Size = new System.Drawing.Size(161, 289);
            this.btn_Alumni.TabIndex = 2;
            this.btn_Alumni.Click += new System.EventHandler(this.btnClick);
            // 
            // btn_Guest
            // 
            this.btn_Guest.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Guest.color = System.Drawing.Color.RoyalBlue;
            this.btn_Guest.colorActive = System.Drawing.Color.SkyBlue;
            this.btn_Guest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFadeTransition.SetDecoration(this.btn_Guest, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btn_Guest, BunifuAnimatorNS.DecorationType.None);
            this.btn_Guest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Guest.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn_Guest.ForeColor = System.Drawing.Color.White;
            this.btn_Guest.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guest.Image")));
            this.btn_Guest.ImagePosition = 28;
            this.btn_Guest.ImageZoom = 50;
            this.btn_Guest.LabelPosition = 56;
            this.btn_Guest.LabelText = "Guest";
            this.btn_Guest.Location = new System.Drawing.Point(386, 7);
            this.btn_Guest.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Guest.Name = "btn_Guest";
            this.btn_Guest.Size = new System.Drawing.Size(161, 289);
            this.btn_Guest.TabIndex = 2;
            this.btn_Guest.Click += new System.EventHandler(this.btnClick);
            // 
            // btn_Student
            // 
            this.btn_Student.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Student.color = System.Drawing.Color.RoyalBlue;
            this.btn_Student.colorActive = System.Drawing.Color.SkyBlue;
            this.btn_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFadeTransition.SetDecoration(this.btn_Student, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btn_Student, BunifuAnimatorNS.DecorationType.None);
            this.btn_Student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Student.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn_Student.ForeColor = System.Drawing.Color.White;
            this.btn_Student.Image = ((System.Drawing.Image)(resources.GetObject("btn_Student.Image")));
            this.btn_Student.ImagePosition = 28;
            this.btn_Student.ImageZoom = 50;
            this.btn_Student.LabelPosition = 56;
            this.btn_Student.LabelText = "Student";
            this.btn_Student.Location = new System.Drawing.Point(196, 7);
            this.btn_Student.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(161, 289);
            this.btn_Student.TabIndex = 2;
            this.btn_Student.Click += new System.EventHandler(this.btnClick);
            this.btn_Student.MouseHover += new System.EventHandler(this.btn_Student_MouseHover);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Khaki;
            this.btn_Back.color = System.Drawing.Color.Khaki;
            this.btn_Back.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFadeTransition.SetDecoration(this.btn_Back, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btn_Back, BunifuAnimatorNS.DecorationType.None);
            this.btn_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Back.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn_Back.ForeColor = System.Drawing.Color.Olive;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.ImagePosition = 28;
            this.btn_Back.ImageZoom = 50;
            this.btn_Back.LabelPosition = 56;
            this.btn_Back.LabelText = "Back";
            this.btn_Back.Location = new System.Drawing.Point(6, 7);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(161, 289);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            this.btn_Back.MouseHover += new System.EventHandler(this.btn_Student_MouseHover);
            // 
            // panel_ControlBox
            // 
            this.panel_ControlBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_ControlBox.Controls.Add(this.pb_iLocatorLogo);
            this.panel_ControlBox.Controls.Add(this.lbl_FormTitle);
            this.bunifuFadeTransition.SetDecoration(this.panel_ControlBox, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel_ControlBox, BunifuAnimatorNS.DecorationType.None);
            this.panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ControlBox.Location = new System.Drawing.Point(0, 0);
            this.panel_ControlBox.Name = "panel_ControlBox";
            this.panel_ControlBox.Size = new System.Drawing.Size(1020, 34);
            this.panel_ControlBox.TabIndex = 3;
            // 
            // pb_iLocatorLogo
            // 
            this.pb_iLocatorLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.pb_iLocatorLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_iLocatorLogo.BackgroundImage")));
            this.pb_iLocatorLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.pb_iLocatorLogo, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.pb_iLocatorLogo, BunifuAnimatorNS.DecorationType.None);
            this.pb_iLocatorLogo.Location = new System.Drawing.Point(9, 5);
            this.pb_iLocatorLogo.Name = "pb_iLocatorLogo";
            this.pb_iLocatorLogo.Size = new System.Drawing.Size(25, 25);
            this.pb_iLocatorLogo.TabIndex = 4;
            this.pb_iLocatorLogo.TabStop = false;
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbl_FormTitle, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.lbl_FormTitle, BunifuAnimatorNS.DecorationType.None);
            this.lbl_FormTitle.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_FormTitle.Location = new System.Drawing.Point(37, 7);
            this.lbl_FormTitle.Name = "lbl_FormTitle";
            this.lbl_FormTitle.Size = new System.Drawing.Size(186, 22);
            this.lbl_FormTitle.TabIndex = 2;
            this.lbl_FormTitle.Text = "iLocator | Select Profile";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 20;
            // 
            // idleTime
            // 
            this.idleTime.Interval = 60000;
            this.idleTime.Tick += new System.EventHandler(this.idleTime_Tick);
            // 
            // time_Timer
            // 
            this.time_Timer.Enabled = true;
            this.time_Timer.Interval = 1000;
            this.time_Timer.Tick += new System.EventHandler(this.timerTick);
            // 
            // bunifuFadeTransition
            // 
            this.bunifuFadeTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuFadeTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.bunifuFadeTransition.DefaultAnimation = animation2;
            // 
            // form_SelectUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 497);
            this.ControlBox = false;
            this.Controls.Add(this.panel_ControlBox);
            this.Controls.Add(this.panel_ContainerUniverse);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_SelectUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "iLocator | Select User";
            this.Load += new System.EventHandler(this.form_SelectUser_Load);
            this.panel_ContainerUniverse.ResumeLayout(false);
            this.panel_ContainerUniverse.PerformLayout();
            this.panel_ContainerSelectUser.ResumeLayout(false);
            this.panel_ContainerSelectUser.PerformLayout();
            this.tableLayoutPanel_SelectUser.ResumeLayout(false);
            this.panel_ControlBox.ResumeLayout(false);
            this.panel_ControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_iLocatorLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_ContainerUniverse;
        private System.Windows.Forms.Panel panel_ControlBox;
        private Bunifu.Framework.UI.BunifuTileButton btn_Student;
        private Bunifu.Framework.UI.BunifuTileButton btn_Parents;
        private Bunifu.Framework.UI.BunifuTileButton btn_Guest;
        private Bunifu.Framework.UI.BunifuTileButton btn_Alumni;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_SelectUser;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        public System.Windows.Forms.Timer idleTime;
        private Bunifu.Framework.UI.BunifuTileButton btn_Back;
        private System.Windows.Forms.Panel panel_ContainerSelectUser;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_TimeToday;
        private System.Windows.Forms.Timer time_Timer;
        private BunifuAnimatorNS.BunifuTransition bunifuFadeTransition;
        private System.Windows.Forms.Label lbl_FormTitle;
        private System.Windows.Forms.PictureBox pb_iLocatorLogo;
        private System.Windows.Forms.Label lbl_Description;
    }
}