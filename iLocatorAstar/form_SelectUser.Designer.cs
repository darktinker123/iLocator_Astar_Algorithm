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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_SelectUser));
            this.panel_ContainerSelectUser = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_SelectUser = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Student = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Guest = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Alumni = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Parents = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel_ControlBox = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.panel_ContainerSelectUser.SuspendLayout();
            this.tableLayoutPanel_SelectUser.SuspendLayout();
            this.panel_ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ContainerSelectUser
            // 
            this.panel_ContainerSelectUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ContainerSelectUser.Controls.Add(this.tableLayoutPanel_SelectUser);
            this.bunifuTransition1.SetDecoration(this.panel_ContainerSelectUser, BunifuAnimatorNS.DecorationType.None);
            this.panel_ContainerSelectUser.Location = new System.Drawing.Point(12, 47);
            this.panel_ContainerSelectUser.Name = "panel_ContainerSelectUser";
            this.panel_ContainerSelectUser.Size = new System.Drawing.Size(824, 390);
            this.panel_ContainerSelectUser.TabIndex = 2;
            this.panel_ContainerSelectUser.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ContainerSelectUser_Paint);
            // 
            // tableLayoutPanel_SelectUser
            // 
            this.tableLayoutPanel_SelectUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel_SelectUser.ColumnCount = 7;
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.46939F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.040816F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.46939F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.040816F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.46939F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.040816F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.46939F));
            this.tableLayoutPanel_SelectUser.Controls.Add(this.btn_Student, 0, 0);
            this.tableLayoutPanel_SelectUser.Controls.Add(this.btn_Guest, 2, 0);
            this.tableLayoutPanel_SelectUser.Controls.Add(this.btn_Alumni, 4, 0);
            this.tableLayoutPanel_SelectUser.Controls.Add(this.btn_Parents, 6, 0);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel_SelectUser, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel_SelectUser.Location = new System.Drawing.Point(22, 54);
            this.tableLayoutPanel_SelectUser.Name = "tableLayoutPanel_SelectUser";
            this.tableLayoutPanel_SelectUser.RowCount = 1;
            this.tableLayoutPanel_SelectUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_SelectUser.Size = new System.Drawing.Size(769, 241);
            this.tableLayoutPanel_SelectUser.TabIndex = 4;
            this.tableLayoutPanel_SelectUser.Visible = false;
            // 
            // btn_Student
            // 
            this.btn_Student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.btn_Student.color = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.btn_Student.colorActive = System.Drawing.Color.Cyan;
            this.btn_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_Student, BunifuAnimatorNS.DecorationType.None);
            this.btn_Student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Student.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_Student.ForeColor = System.Drawing.Color.White;
            this.btn_Student.Image = ((System.Drawing.Image)(resources.GetObject("btn_Student.Image")));
            this.btn_Student.ImagePosition = 20;
            this.btn_Student.ImageZoom = 50;
            this.btn_Student.LabelPosition = 41;
            this.btn_Student.LabelText = "Student";
            this.btn_Student.Location = new System.Drawing.Point(6, 6);
            this.btn_Student.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(168, 229);
            this.btn_Student.TabIndex = 2;
            this.btn_Student.Click += new System.EventHandler(this.btn_Student_Click);
            this.btn_Student.MouseHover += new System.EventHandler(this.btn_Student_MouseHover);
            // 
            // btn_Guest
            // 
            this.btn_Guest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.btn_Guest.color = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.btn_Guest.colorActive = System.Drawing.Color.Cyan;
            this.btn_Guest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_Guest, BunifuAnimatorNS.DecorationType.None);
            this.btn_Guest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Guest.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_Guest.ForeColor = System.Drawing.Color.White;
            this.btn_Guest.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guest.Image")));
            this.btn_Guest.ImagePosition = 20;
            this.btn_Guest.ImageZoom = 50;
            this.btn_Guest.LabelPosition = 41;
            this.btn_Guest.LabelText = "Guest";
            this.btn_Guest.Location = new System.Drawing.Point(201, 6);
            this.btn_Guest.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Guest.Name = "btn_Guest";
            this.btn_Guest.Size = new System.Drawing.Size(168, 229);
            this.btn_Guest.TabIndex = 2;
            this.btn_Guest.Click += new System.EventHandler(this.btn_Guest_Click);
            // 
            // btn_Alumni
            // 
            this.btn_Alumni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.btn_Alumni.color = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.btn_Alumni.colorActive = System.Drawing.Color.Cyan;
            this.btn_Alumni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_Alumni, BunifuAnimatorNS.DecorationType.None);
            this.btn_Alumni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Alumni.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_Alumni.ForeColor = System.Drawing.Color.White;
            this.btn_Alumni.Image = ((System.Drawing.Image)(resources.GetObject("btn_Alumni.Image")));
            this.btn_Alumni.ImagePosition = 20;
            this.btn_Alumni.ImageZoom = 50;
            this.btn_Alumni.LabelPosition = 41;
            this.btn_Alumni.LabelText = "Aumni";
            this.btn_Alumni.Location = new System.Drawing.Point(396, 6);
            this.btn_Alumni.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Alumni.Name = "btn_Alumni";
            this.btn_Alumni.Size = new System.Drawing.Size(168, 229);
            this.btn_Alumni.TabIndex = 2;
            this.btn_Alumni.Click += new System.EventHandler(this.btn_Alumni_Click);
            // 
            // btn_Parents
            // 
            this.btn_Parents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.btn_Parents.color = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.btn_Parents.colorActive = System.Drawing.Color.Cyan;
            this.btn_Parents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_Parents, BunifuAnimatorNS.DecorationType.None);
            this.btn_Parents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Parents.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_Parents.ForeColor = System.Drawing.Color.White;
            this.btn_Parents.Image = ((System.Drawing.Image)(resources.GetObject("btn_Parents.Image")));
            this.btn_Parents.ImagePosition = 20;
            this.btn_Parents.ImageZoom = 50;
            this.btn_Parents.LabelPosition = 41;
            this.btn_Parents.LabelText = "Parent/s";
            this.btn_Parents.Location = new System.Drawing.Point(591, 6);
            this.btn_Parents.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Parents.Name = "btn_Parents";
            this.btn_Parents.Size = new System.Drawing.Size(172, 229);
            this.btn_Parents.TabIndex = 2;
            this.btn_Parents.Click += new System.EventHandler(this.btn_Parents_Click);
            // 
            // panel_ControlBox
            // 
            this.panel_ControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.panel_ControlBox.Controls.Add(this.label1);
            this.panel_ControlBox.Controls.Add(this.btn_Close);
            this.bunifuTransition1.SetDecoration(this.panel_ControlBox, BunifuAnimatorNS.DecorationType.None);
            this.panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ControlBox.Location = new System.Drawing.Point(0, 0);
            this.panel_ControlBox.Name = "panel_ControlBox";
            this.panel_ControlBox.Size = new System.Drawing.Size(848, 34);
            this.panel_ControlBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "iLocator | Select Profile";
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = global::iLocatorAstar.Properties.Resources.close_window_32;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_Close, BunifuAnimatorNS.DecorationType.None);
            this.btn_Close.Location = new System.Drawing.Point(821, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(19, 27);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 1F;
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
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            this.bunifuTransition1.Interval = 20;
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.White;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.White;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // form_SelectUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 449);
            this.ControlBox = false;
            this.Controls.Add(this.panel_ControlBox);
            this.Controls.Add(this.panel_ContainerSelectUser);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_SelectUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "iLocator - Select User";
            this.Load += new System.EventHandler(this.form_SelectUser_Load);
            this.panel_ContainerSelectUser.ResumeLayout(false);
            this.tableLayoutPanel_SelectUser.ResumeLayout(false);
            this.panel_ControlBox.ResumeLayout(false);
            this.panel_ControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_ContainerSelectUser;
        private System.Windows.Forms.Panel panel_ControlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_Close;
        private Bunifu.Framework.UI.BunifuTileButton btn_Student;
        private Bunifu.Framework.UI.BunifuTileButton btn_Parents;
        private Bunifu.Framework.UI.BunifuTileButton btn_Guest;
        private Bunifu.Framework.UI.BunifuTileButton btn_Alumni;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_SelectUser;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
    }
}