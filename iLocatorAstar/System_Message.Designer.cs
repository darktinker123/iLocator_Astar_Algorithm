namespace iLocatorAstar
{
    partial class System_Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(System_Message));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_ContainerMsgSystem = new System.Windows.Forms.Panel();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.btn_Yes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_No = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pb_ExclamationIcon = new System.Windows.Forms.PictureBox();
            this.lbl_MsgSystem = new System.Windows.Forms.Label();
            this.bunifu_TitleMsgMessege = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pb_MsgSystemIco = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.panel_ControlBox = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel_ContainerMsgSystem.SuspendLayout();
            this.panel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ExclamationIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MsgSystemIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.panel_ControlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_ContainerMsgSystem
            // 
            this.panel_ContainerMsgSystem.BackColor = System.Drawing.Color.CadetBlue;
            this.panel_ContainerMsgSystem.Controls.Add(this.panel_Buttons);
            this.panel_ContainerMsgSystem.Controls.Add(this.pb_ExclamationIcon);
            this.panel_ContainerMsgSystem.Controls.Add(this.lbl_MsgSystem);
            this.panel_ContainerMsgSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContainerMsgSystem.Location = new System.Drawing.Point(0, 37);
            this.panel_ContainerMsgSystem.Name = "panel_ContainerMsgSystem";
            this.panel_ContainerMsgSystem.Size = new System.Drawing.Size(509, 214);
            this.panel_ContainerMsgSystem.TabIndex = 6;
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Buttons.Controls.Add(this.btn_Yes);
            this.panel_Buttons.Controls.Add(this.btn_No);
            this.panel_Buttons.Location = new System.Drawing.Point(227, 146);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(279, 62);
            this.panel_Buttons.TabIndex = 1;
            // 
            // btn_Yes
            // 
            this.btn_Yes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.btn_Yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.btn_Yes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Yes.BorderRadius = 0;
            this.btn_Yes.ButtonText = "Yes";
            this.btn_Yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Yes.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Yes.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Yes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Yes.Iconimage")));
            this.btn_Yes.Iconimage_right = null;
            this.btn_Yes.Iconimage_right_Selected = null;
            this.btn_Yes.Iconimage_Selected = null;
            this.btn_Yes.IconMarginLeft = 0;
            this.btn_Yes.IconMarginRight = 0;
            this.btn_Yes.IconRightVisible = true;
            this.btn_Yes.IconRightZoom = 0D;
            this.btn_Yes.IconVisible = true;
            this.btn_Yes.IconZoom = 90D;
            this.btn_Yes.IsTab = false;
            this.btn_Yes.Location = new System.Drawing.Point(8, 9);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.btn_Yes.OnHovercolor = System.Drawing.Color.Cyan;
            this.btn_Yes.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Yes.selected = false;
            this.btn_Yes.Size = new System.Drawing.Size(131, 43);
            this.btn_Yes.TabIndex = 5;
            this.btn_Yes.Text = "Yes";
            this.btn_Yes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Yes.Textcolor = System.Drawing.Color.White;
            this.btn_Yes.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Yes.Click += new System.EventHandler(this.btn_Yes_Click);
            // 
            // btn_No
            // 
            this.btn_No.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.btn_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.btn_No.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_No.BorderRadius = 0;
            this.btn_No.ButtonText = "   No";
            this.btn_No.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_No.DisabledColor = System.Drawing.Color.Gray;
            this.btn_No.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_No.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_No.Iconimage")));
            this.btn_No.Iconimage_right = null;
            this.btn_No.Iconimage_right_Selected = null;
            this.btn_No.Iconimage_Selected = null;
            this.btn_No.IconMarginLeft = 0;
            this.btn_No.IconMarginRight = 0;
            this.btn_No.IconRightVisible = true;
            this.btn_No.IconRightZoom = 0D;
            this.btn_No.IconVisible = true;
            this.btn_No.IconZoom = 40D;
            this.btn_No.IsTab = false;
            this.btn_No.Location = new System.Drawing.Point(146, 10);
            this.btn_No.Name = "btn_No";
            this.btn_No.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.btn_No.OnHovercolor = System.Drawing.Color.Cyan;
            this.btn_No.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_No.selected = false;
            this.btn_No.Size = new System.Drawing.Size(127, 43);
            this.btn_No.TabIndex = 4;
            this.btn_No.Text = "   No";
            this.btn_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_No.Textcolor = System.Drawing.Color.White;
            this.btn_No.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // pb_ExclamationIcon
            // 
            this.pb_ExclamationIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_ExclamationIcon.BackgroundImage")));
            this.pb_ExclamationIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ExclamationIcon.Location = new System.Drawing.Point(122, 46);
            this.pb_ExclamationIcon.Name = "pb_ExclamationIcon";
            this.pb_ExclamationIcon.Size = new System.Drawing.Size(73, 71);
            this.pb_ExclamationIcon.TabIndex = 1;
            this.pb_ExclamationIcon.TabStop = false;
            // 
            // lbl_MsgSystem
            // 
            this.lbl_MsgSystem.AutoSize = true;
            this.lbl_MsgSystem.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MsgSystem.ForeColor = System.Drawing.Color.White;
            this.lbl_MsgSystem.Location = new System.Drawing.Point(196, 65);
            this.lbl_MsgSystem.Name = "lbl_MsgSystem";
            this.lbl_MsgSystem.Size = new System.Drawing.Size(173, 30);
            this.lbl_MsgSystem.TabIndex = 0;
            this.lbl_MsgSystem.Text = "Are you sure?";
            // 
            // bunifu_TitleMsgMessege
            // 
            this.bunifu_TitleMsgMessege.AutoSize = true;
            this.bunifu_TitleMsgMessege.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifu_TitleMsgMessege.ForeColor = System.Drawing.Color.White;
            this.bunifu_TitleMsgMessege.Location = new System.Drawing.Point(41, 8);
            this.bunifu_TitleMsgMessege.Name = "bunifu_TitleMsgMessege";
            this.bunifu_TitleMsgMessege.Size = new System.Drawing.Size(137, 21);
            this.bunifu_TitleMsgMessege.TabIndex = 1;
            this.bunifu_TitleMsgMessege.Text = "System Message";
            // 
            // pb_MsgSystemIco
            // 
            this.pb_MsgSystemIco.BackgroundImage = global::iLocatorAstar.Properties.Resources.message_2_64;
            this.pb_MsgSystemIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_MsgSystemIco.Location = new System.Drawing.Point(11, 4);
            this.pb_MsgSystemIco.Name = "pb_MsgSystemIco";
            this.pb_MsgSystemIco.Size = new System.Drawing.Size(24, 29);
            this.pb_MsgSystemIco.TabIndex = 1;
            this.pb_MsgSystemIco.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = global::iLocatorAstar.Properties.Resources.close_window_32;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Location = new System.Drawing.Point(476, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(19, 27);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel_ControlBox
            // 
            this.panel_ControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            this.panel_ControlBox.Controls.Add(this.btn_Close);
            this.panel_ControlBox.Controls.Add(this.pb_MsgSystemIco);
            this.panel_ControlBox.Controls.Add(this.bunifu_TitleMsgMessege);
            this.panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ControlBox.Location = new System.Drawing.Point(0, 0);
            this.panel_ControlBox.Name = "panel_ControlBox";
            this.panel_ControlBox.Size = new System.Drawing.Size(509, 37);
            this.panel_ControlBox.TabIndex = 3;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel_ControlBox;
            this.bunifuDragControl1.Vertical = true;
            // 
            // System_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(509, 251);
            this.Controls.Add(this.panel_ContainerMsgSystem);
            this.Controls.Add(this.panel_ControlBox);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "System_Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.panel_ContainerMsgSystem.ResumeLayout(false);
            this.panel_ContainerMsgSystem.PerformLayout();
            this.panel_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ExclamationIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MsgSystemIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.panel_ControlBox.ResumeLayout(false);
            this.panel_ControlBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_ContainerMsgSystem;
        private System.Windows.Forms.Label lbl_MsgSystem;
        private System.Windows.Forms.Panel panel_ControlBox;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.PictureBox pb_MsgSystemIco;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifu_TitleMsgMessege;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pb_ExclamationIcon;
        private System.Windows.Forms.Panel panel_Buttons;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Yes;
        private Bunifu.Framework.UI.BunifuFlatButton btn_No;
    }
}