namespace iLocatorAstar
{
    partial class System_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(System_Info));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_ControlBox = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.pb_SystemInfoIco = new System.Windows.Forms.PictureBox();
            this.lbl_TitleSystemInfo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_ContainerSystemInfo = new System.Windows.Forms.Panel();
            this.pb_SystemIcon = new System.Windows.Forms.PictureBox();
            this.lbl_SystemInfoTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_SystemInfoCopyright = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_SystemInfoVersion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_Admin3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_Admin1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_Admin2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_Admin4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel_DivisionTop = new System.Windows.Forms.Panel();
            this.panel_DivisionBottom = new System.Windows.Forms.Panel();
            this.panel_ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SystemInfoIco)).BeginInit();
            this.panel_ContainerSystemInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SystemIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_ControlBox
            // 
            this.panel_ControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.panel_ControlBox.Controls.Add(this.btn_Close);
            this.panel_ControlBox.Controls.Add(this.pb_SystemInfoIco);
            this.panel_ControlBox.Controls.Add(this.lbl_TitleSystemInfo);
            this.panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ControlBox.Location = new System.Drawing.Point(0, 0);
            this.panel_ControlBox.Name = "panel_ControlBox";
            this.panel_ControlBox.Size = new System.Drawing.Size(531, 37);
            this.panel_ControlBox.TabIndex = 4;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = global::iLocatorAstar.Properties.Resources.close_window_32;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Location = new System.Drawing.Point(498, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(19, 27);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pb_SystemInfoIco
            // 
            this.pb_SystemInfoIco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_SystemInfoIco.BackgroundImage")));
            this.pb_SystemInfoIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_SystemInfoIco.Location = new System.Drawing.Point(11, 4);
            this.pb_SystemInfoIco.Name = "pb_SystemInfoIco";
            this.pb_SystemInfoIco.Size = new System.Drawing.Size(24, 29);
            this.pb_SystemInfoIco.TabIndex = 1;
            this.pb_SystemInfoIco.TabStop = false;
            // 
            // lbl_TitleSystemInfo
            // 
            this.lbl_TitleSystemInfo.AutoSize = true;
            this.lbl_TitleSystemInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleSystemInfo.ForeColor = System.Drawing.Color.White;
            this.lbl_TitleSystemInfo.Location = new System.Drawing.Point(41, 8);
            this.lbl_TitleSystemInfo.Name = "lbl_TitleSystemInfo";
            this.lbl_TitleSystemInfo.Size = new System.Drawing.Size(98, 21);
            this.lbl_TitleSystemInfo.TabIndex = 1;
            this.lbl_TitleSystemInfo.Text = "System Info";
            // 
            // panel_ContainerSystemInfo
            // 
            this.panel_ContainerSystemInfo.BackColor = System.Drawing.Color.CadetBlue;
            this.panel_ContainerSystemInfo.Controls.Add(this.pb_SystemIcon);
            this.panel_ContainerSystemInfo.Controls.Add(this.lbl_SystemInfoTitle);
            this.panel_ContainerSystemInfo.Controls.Add(this.lbl_SystemInfoCopyright);
            this.panel_ContainerSystemInfo.Controls.Add(this.lbl_SystemInfoVersion);
            this.panel_ContainerSystemInfo.Controls.Add(this.lbl_Admin3);
            this.panel_ContainerSystemInfo.Controls.Add(this.lbl_Admin1);
            this.panel_ContainerSystemInfo.Controls.Add(this.lbl_Admin2);
            this.panel_ContainerSystemInfo.Controls.Add(this.lbl_Admin4);
            this.panel_ContainerSystemInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContainerSystemInfo.Location = new System.Drawing.Point(0, 70);
            this.panel_ContainerSystemInfo.Name = "panel_ContainerSystemInfo";
            this.panel_ContainerSystemInfo.Size = new System.Drawing.Size(531, 254);
            this.panel_ContainerSystemInfo.TabIndex = 7;
            // 
            // pb_SystemIcon
            // 
            this.pb_SystemIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_SystemIcon.BackgroundImage")));
            this.pb_SystemIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_SystemIcon.Location = new System.Drawing.Point(18, 38);
            this.pb_SystemIcon.Name = "pb_SystemIcon";
            this.pb_SystemIcon.Size = new System.Drawing.Size(127, 152);
            this.pb_SystemIcon.TabIndex = 1;
            this.pb_SystemIcon.TabStop = false;
            // 
            // lbl_SystemInfoTitle
            // 
            this.lbl_SystemInfoTitle.AutoSize = true;
            this.lbl_SystemInfoTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SystemInfoTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_SystemInfoTitle.Location = new System.Drawing.Point(190, 63);
            this.lbl_SystemInfoTitle.Name = "lbl_SystemInfoTitle";
            this.lbl_SystemInfoTitle.Size = new System.Drawing.Size(259, 23);
            this.lbl_SystemInfoTitle.TabIndex = 0;
            this.lbl_SystemInfoTitle.Text = "iLocator using A* Algorithm";
            // 
            // lbl_SystemInfoCopyright
            // 
            this.lbl_SystemInfoCopyright.AutoSize = true;
            this.lbl_SystemInfoCopyright.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SystemInfoCopyright.ForeColor = System.Drawing.Color.White;
            this.lbl_SystemInfoCopyright.Location = new System.Drawing.Point(14, 225);
            this.lbl_SystemInfoCopyright.Name = "lbl_SystemInfoCopyright";
            this.lbl_SystemInfoCopyright.Size = new System.Drawing.Size(97, 17);
            this.lbl_SystemInfoCopyright.TabIndex = 0;
            this.lbl_SystemInfoCopyright.Text = "Copyright 2018";
            // 
            // lbl_SystemInfoVersion
            // 
            this.lbl_SystemInfoVersion.AutoSize = true;
            this.lbl_SystemInfoVersion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SystemInfoVersion.ForeColor = System.Drawing.Color.White;
            this.lbl_SystemInfoVersion.Location = new System.Drawing.Point(422, 225);
            this.lbl_SystemInfoVersion.Name = "lbl_SystemInfoVersion";
            this.lbl_SystemInfoVersion.Size = new System.Drawing.Size(79, 17);
            this.lbl_SystemInfoVersion.TabIndex = 0;
            this.lbl_SystemInfoVersion.Text = "Version 0.01";
            // 
            // lbl_Admin3
            // 
            this.lbl_Admin3.AutoSize = true;
            this.lbl_Admin3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Admin3.ForeColor = System.Drawing.Color.White;
            this.lbl_Admin3.Location = new System.Drawing.Point(326, 104);
            this.lbl_Admin3.Name = "lbl_Admin3";
            this.lbl_Admin3.Size = new System.Drawing.Size(155, 21);
            this.lbl_Admin3.TabIndex = 0;
            this.lbl_Admin3.Text = "Dummy A. Dummy";
            // 
            // lbl_Admin1
            // 
            this.lbl_Admin1.AutoSize = true;
            this.lbl_Admin1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Admin1.ForeColor = System.Drawing.Color.White;
            this.lbl_Admin1.Location = new System.Drawing.Point(163, 104);
            this.lbl_Admin1.Name = "lbl_Admin1";
            this.lbl_Admin1.Size = new System.Drawing.Size(155, 21);
            this.lbl_Admin1.TabIndex = 0;
            this.lbl_Admin1.Text = "Dummy A. Dummy";
            // 
            // lbl_Admin2
            // 
            this.lbl_Admin2.AutoSize = true;
            this.lbl_Admin2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Admin2.ForeColor = System.Drawing.Color.White;
            this.lbl_Admin2.Location = new System.Drawing.Point(163, 138);
            this.lbl_Admin2.Name = "lbl_Admin2";
            this.lbl_Admin2.Size = new System.Drawing.Size(155, 21);
            this.lbl_Admin2.TabIndex = 0;
            this.lbl_Admin2.Text = "Dummy A. Dummy";
            // 
            // lbl_Admin4
            // 
            this.lbl_Admin4.AutoSize = true;
            this.lbl_Admin4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Admin4.ForeColor = System.Drawing.Color.White;
            this.lbl_Admin4.Location = new System.Drawing.Point(324, 138);
            this.lbl_Admin4.Name = "lbl_Admin4";
            this.lbl_Admin4.Size = new System.Drawing.Size(155, 21);
            this.lbl_Admin4.TabIndex = 0;
            this.lbl_Admin4.Text = "Dummy A. Dummy";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel_ControlBox;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel_DivisionTop
            // 
            this.panel_DivisionTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_DivisionTop.Location = new System.Drawing.Point(0, 37);
            this.panel_DivisionTop.Name = "panel_DivisionTop";
            this.panel_DivisionTop.Size = new System.Drawing.Size(531, 33);
            this.panel_DivisionTop.TabIndex = 8;
            // 
            // panel_DivisionBottom
            // 
            this.panel_DivisionBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_DivisionBottom.Location = new System.Drawing.Point(0, 324);
            this.panel_DivisionBottom.Name = "panel_DivisionBottom";
            this.panel_DivisionBottom.Size = new System.Drawing.Size(531, 28);
            this.panel_DivisionBottom.TabIndex = 9;
            // 
            // System_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(531, 352);
            this.ControlBox = false;
            this.Controls.Add(this.panel_ContainerSystemInfo);
            this.Controls.Add(this.panel_DivisionBottom);
            this.Controls.Add(this.panel_DivisionTop);
            this.Controls.Add(this.panel_ControlBox);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "System_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System_Info";
            this.panel_ControlBox.ResumeLayout(false);
            this.panel_ControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SystemInfoIco)).EndInit();
            this.panel_ContainerSystemInfo.ResumeLayout(false);
            this.panel_ContainerSystemInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SystemIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_ControlBox;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.PictureBox pb_SystemInfoIco;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_TitleSystemInfo;
        private System.Windows.Forms.Panel panel_ContainerSystemInfo;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_SystemInfoTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_SystemInfoCopyright;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_SystemInfoVersion;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Admin3;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Admin1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Admin2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Admin4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pb_SystemIcon;
        private System.Windows.Forms.Panel panel_DivisionBottom;
        private System.Windows.Forms.Panel panel_DivisionTop;
    }
}