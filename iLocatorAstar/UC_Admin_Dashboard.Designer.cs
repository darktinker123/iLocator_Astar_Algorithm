namespace iLocatorAstar
{
    partial class UC_Admin_Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pb_VirtualMap = new System.Windows.Forms.PictureBox();
            this.btn_setStartingFloor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmb_floorSelection = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_VirtualMap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "Set system floor:";
            // 
            // pb_VirtualMap
            // 
            this.pb_VirtualMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_VirtualMap.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pb_VirtualMap.Location = new System.Drawing.Point(442, 74);
            this.pb_VirtualMap.Name = "pb_VirtualMap";
            this.pb_VirtualMap.Size = new System.Drawing.Size(864, 476);
            this.pb_VirtualMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_VirtualMap.TabIndex = 31;
            this.pb_VirtualMap.TabStop = false;
            // 
            // btn_setStartingFloor
            // 
            this.btn_setStartingFloor.Activecolor = System.Drawing.Color.Cyan;
            this.btn_setStartingFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_setStartingFloor.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_setStartingFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_setStartingFloor.BorderRadius = 0;
            this.btn_setStartingFloor.ButtonText = "Apply changes";
            this.btn_setStartingFloor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_setStartingFloor.DisabledColor = System.Drawing.Color.Gray;
            this.btn_setStartingFloor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setStartingFloor.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_setStartingFloor.Iconimage = null;
            this.btn_setStartingFloor.Iconimage_right = null;
            this.btn_setStartingFloor.Iconimage_right_Selected = null;
            this.btn_setStartingFloor.Iconimage_Selected = null;
            this.btn_setStartingFloor.IconMarginLeft = 0;
            this.btn_setStartingFloor.IconMarginRight = 0;
            this.btn_setStartingFloor.IconRightVisible = true;
            this.btn_setStartingFloor.IconRightZoom = 0D;
            this.btn_setStartingFloor.IconVisible = true;
            this.btn_setStartingFloor.IconZoom = 90D;
            this.btn_setStartingFloor.IsTab = false;
            this.btn_setStartingFloor.Location = new System.Drawing.Point(174, 368);
            this.btn_setStartingFloor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_setStartingFloor.Name = "btn_setStartingFloor";
            this.btn_setStartingFloor.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_setStartingFloor.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btn_setStartingFloor.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_setStartingFloor.selected = false;
            this.btn_setStartingFloor.Size = new System.Drawing.Size(192, 47);
            this.btn_setStartingFloor.TabIndex = 30;
            this.btn_setStartingFloor.Text = "Apply changes";
            this.btn_setStartingFloor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_setStartingFloor.Textcolor = System.Drawing.Color.White;
            this.btn_setStartingFloor.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setStartingFloor.Click += new System.EventHandler(this.btn_setStartingFloor_Click);
            // 
            // cmb_floorSelection
            // 
            this.cmb_floorSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_floorSelection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_floorSelection.FormattingEnabled = true;
            this.cmb_floorSelection.Items.AddRange(new object[] {
            "UG",
            "3rd",
            "5th",
            "7th",
            "9th"});
            this.cmb_floorSelection.Location = new System.Drawing.Point(27, 237);
            this.cmb_floorSelection.Name = "cmb_floorSelection";
            this.cmb_floorSelection.Size = new System.Drawing.Size(391, 29);
            this.cmb_floorSelection.TabIndex = 32;
            this.cmb_floorSelection.SelectedIndexChanged += new System.EventHandler(this.cmb_floorSelection_SelectedIndexChanged);
            // 
            // UC_Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_VirtualMap);
            this.Controls.Add(this.btn_setStartingFloor);
            this.Controls.Add(this.cmb_floorSelection);
            this.Name = "UC_Admin_Dashboard";
            this.Size = new System.Drawing.Size(1334, 630);
            ((System.ComponentModel.ISupportInitialize)(this.pb_VirtualMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_VirtualMap;
        private Bunifu.Framework.UI.BunifuFlatButton btn_setStartingFloor;
        private System.Windows.Forms.ComboBox cmb_floorSelection;

    }
}
