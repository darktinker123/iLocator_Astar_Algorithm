namespace iLocatorAstar
{
    partial class form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Main));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_TitleVirtualMap = new System.Windows.Forms.Panel();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lbl_VirtualMap = new System.Windows.Forms.Label();
            this.panel_DetailsSelectedDestination = new System.Windows.Forms.Panel();
            this.btn_Replay = new System.Windows.Forms.PictureBox();
            this.lbl_GoHome = new System.Windows.Forms.Label();
            this.btn_BackToHome = new System.Windows.Forms.PictureBox();
            this.lbl_EstimatedDistance = new System.Windows.Forms.Label();
            this.lbl_Replay = new System.Windows.Forms.Label();
            this.lbl_EstimatedTime = new System.Windows.Forms.Label();
            this.panel_UniverseSelectDestination = new System.Windows.Forms.Panel();
            this.panel_ContainerSelectDestination = new System.Windows.Forms.Panel();
            this.panel_TitleSelectDestination = new System.Windows.Forms.Panel();
            this.lbl_SelectDestination = new System.Windows.Forms.Label();
            this.panel_UniverseVirtualMap = new System.Windows.Forms.Panel();
            this.pb_VirtualMap = new System.Windows.Forms.PictureBox();
            this.panel_ContainerFloorSelector = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_FloorButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_10th = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_9th = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_8th = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_7th = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_6th = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_5th = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_4th = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_3rd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_2nd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_UG = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_TitleSelectFloor = new System.Windows.Forms.Panel();
            this.lbl_SelectFloor = new System.Windows.Forms.Label();
            this.lbl_FormTitle = new System.Windows.Forms.Label();
            this.pb_iLocatorLogo = new System.Windows.Forms.PictureBox();
            this.panel_ControlBox = new System.Windows.Forms.Panel();
            this.panel_ContainerMain = new System.Windows.Forms.Panel();
            this.bunifuLeafTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuFadeTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel_TitleVirtualMap.SuspendLayout();
            this.panel_DetailsSelectedDestination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Replay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_BackToHome)).BeginInit();
            this.panel_UniverseSelectDestination.SuspendLayout();
            this.panel_TitleSelectDestination.SuspendLayout();
            this.panel_UniverseVirtualMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_VirtualMap)).BeginInit();
            this.panel_ContainerFloorSelector.SuspendLayout();
            this.tableLayoutPanel_FloorButtons.SuspendLayout();
            this.panel_TitleSelectFloor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_iLocatorLogo)).BeginInit();
            this.panel_ControlBox.SuspendLayout();
            this.panel_ContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_TitleVirtualMap
            // 
            this.panel_TitleVirtualMap.BackColor = System.Drawing.SystemColors.Control;
            this.panel_TitleVirtualMap.Controls.Add(this.lblFloor);
            this.panel_TitleVirtualMap.Controls.Add(this.lbl_VirtualMap);
            this.bunifuFadeTransition.SetDecoration(this.panel_TitleVirtualMap, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.panel_TitleVirtualMap, BunifuAnimatorNS.DecorationType.None);
            this.panel_TitleVirtualMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitleVirtualMap.Location = new System.Drawing.Point(474, 0);
            this.panel_TitleVirtualMap.Name = "panel_TitleVirtualMap";
            this.panel_TitleVirtualMap.Size = new System.Drawing.Size(577, 51);
            this.panel_TitleVirtualMap.TabIndex = 7;
            this.panel_TitleVirtualMap.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_TitleVirtualMap_Paint);
            // 
            // lblFloor
            // 
            this.lblFloor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFloor.AutoSize = true;
            this.bunifuLeafTransition.SetDecoration(this.lblFloor, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.lblFloor, BunifuAnimatorNS.DecorationType.None);
            this.lblFloor.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Bold);
            this.lblFloor.ForeColor = System.Drawing.Color.DimGray;
            this.lblFloor.Location = new System.Drawing.Point(54, 6);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(0, 41);
            this.lblFloor.TabIndex = 5;
            // 
            // lbl_VirtualMap
            // 
            this.lbl_VirtualMap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_VirtualMap.AutoSize = true;
            this.bunifuLeafTransition.SetDecoration(this.lbl_VirtualMap, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.lbl_VirtualMap, BunifuAnimatorNS.DecorationType.None);
            this.lbl_VirtualMap.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VirtualMap.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_VirtualMap.Location = new System.Drawing.Point(420, 11);
            this.lbl_VirtualMap.Name = "lbl_VirtualMap";
            this.lbl_VirtualMap.Size = new System.Drawing.Size(143, 29);
            this.lbl_VirtualMap.TabIndex = 4;
            this.lbl_VirtualMap.Text = "(Virtual Map)";
            // 
            // panel_DetailsSelectedDestination
            // 
            this.panel_DetailsSelectedDestination.Controls.Add(this.btn_Replay);
            this.panel_DetailsSelectedDestination.Controls.Add(this.lbl_GoHome);
            this.panel_DetailsSelectedDestination.Controls.Add(this.btn_BackToHome);
            this.panel_DetailsSelectedDestination.Controls.Add(this.lbl_EstimatedDistance);
            this.panel_DetailsSelectedDestination.Controls.Add(this.lbl_Replay);
            this.panel_DetailsSelectedDestination.Controls.Add(this.lbl_EstimatedTime);
            this.bunifuFadeTransition.SetDecoration(this.panel_DetailsSelectedDestination, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.panel_DetailsSelectedDestination, BunifuAnimatorNS.DecorationType.None);
            this.panel_DetailsSelectedDestination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_DetailsSelectedDestination.Location = new System.Drawing.Point(474, 513);
            this.panel_DetailsSelectedDestination.Name = "panel_DetailsSelectedDestination";
            this.panel_DetailsSelectedDestination.Size = new System.Drawing.Size(577, 117);
            this.panel_DetailsSelectedDestination.TabIndex = 8;
            this.panel_DetailsSelectedDestination.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_DetailsSelectedDestination_Paint);
            // 
            // btn_Replay
            // 
            this.btn_Replay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Replay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Replay.BackgroundImage")));
            this.btn_Replay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Replay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuLeafTransition.SetDecoration(this.btn_Replay, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.btn_Replay, BunifuAnimatorNS.DecorationType.None);
            this.btn_Replay.Location = new System.Drawing.Point(449, 24);
            this.btn_Replay.Name = "btn_Replay";
            this.btn_Replay.Size = new System.Drawing.Size(53, 62);
            this.btn_Replay.TabIndex = 7;
            this.btn_Replay.TabStop = false;
            this.btn_Replay.Visible = false;
            this.btn_Replay.Click += new System.EventHandler(this.btn_Replay_Click);
            // 
            // lbl_GoHome
            // 
            this.lbl_GoHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GoHome.AutoSize = true;
            this.bunifuLeafTransition.SetDecoration(this.lbl_GoHome, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.lbl_GoHome, BunifuAnimatorNS.DecorationType.None);
            this.lbl_GoHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GoHome.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_GoHome.Location = new System.Drawing.Point(514, 89);
            this.lbl_GoHome.Name = "lbl_GoHome";
            this.lbl_GoHome.Size = new System.Drawing.Size(56, 21);
            this.lbl_GoHome.TabIndex = 8;
            this.lbl_GoHome.Text = "Home";
            this.lbl_GoHome.Visible = false;
            // 
            // btn_BackToHome
            // 
            this.btn_BackToHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BackToHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BackToHome.BackgroundImage")));
            this.btn_BackToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BackToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuLeafTransition.SetDecoration(this.btn_BackToHome, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.btn_BackToHome, BunifuAnimatorNS.DecorationType.None);
            this.btn_BackToHome.Location = new System.Drawing.Point(512, 25);
            this.btn_BackToHome.Name = "btn_BackToHome";
            this.btn_BackToHome.Size = new System.Drawing.Size(53, 62);
            this.btn_BackToHome.TabIndex = 7;
            this.btn_BackToHome.TabStop = false;
            this.btn_BackToHome.Visible = false;
            this.btn_BackToHome.Click += new System.EventHandler(this.pb_BackToHome_Click);
            // 
            // lbl_EstimatedDistance
            // 
            this.lbl_EstimatedDistance.AutoSize = true;
            this.bunifuLeafTransition.SetDecoration(this.lbl_EstimatedDistance, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.lbl_EstimatedDistance, BunifuAnimatorNS.DecorationType.None);
            this.lbl_EstimatedDistance.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EstimatedDistance.Location = new System.Drawing.Point(21, 62);
            this.lbl_EstimatedDistance.Name = "lbl_EstimatedDistance";
            this.lbl_EstimatedDistance.Size = new System.Drawing.Size(179, 24);
            this.lbl_EstimatedDistance.TabIndex = 6;
            this.lbl_EstimatedDistance.Text = "Estimated Distance: ";
            // 
            // lbl_Replay
            // 
            this.lbl_Replay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Replay.AutoSize = true;
            this.bunifuLeafTransition.SetDecoration(this.lbl_Replay, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.lbl_Replay, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Replay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Replay.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Replay.Location = new System.Drawing.Point(445, 89);
            this.lbl_Replay.Name = "lbl_Replay";
            this.lbl_Replay.Size = new System.Drawing.Size(63, 21);
            this.lbl_Replay.TabIndex = 8;
            this.lbl_Replay.Text = "Replay";
            this.lbl_Replay.Visible = false;
            // 
            // lbl_EstimatedTime
            // 
            this.lbl_EstimatedTime.AutoSize = true;
            this.bunifuLeafTransition.SetDecoration(this.lbl_EstimatedTime, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.lbl_EstimatedTime, BunifuAnimatorNS.DecorationType.None);
            this.lbl_EstimatedTime.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EstimatedTime.Location = new System.Drawing.Point(21, 37);
            this.lbl_EstimatedTime.Name = "lbl_EstimatedTime";
            this.lbl_EstimatedTime.Size = new System.Drawing.Size(144, 24);
            this.lbl_EstimatedTime.TabIndex = 6;
            this.lbl_EstimatedTime.Text = "Estimated Time:";
            // 
            // panel_UniverseSelectDestination
            // 
            this.panel_UniverseSelectDestination.Controls.Add(this.panel_ContainerSelectDestination);
            this.panel_UniverseSelectDestination.Controls.Add(this.panel_TitleSelectDestination);
            this.bunifuFadeTransition.SetDecoration(this.panel_UniverseSelectDestination, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.panel_UniverseSelectDestination, BunifuAnimatorNS.DecorationType.None);
            this.panel_UniverseSelectDestination.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_UniverseSelectDestination.Location = new System.Drawing.Point(168, 0);
            this.panel_UniverseSelectDestination.Name = "panel_UniverseSelectDestination";
            this.panel_UniverseSelectDestination.Size = new System.Drawing.Size(306, 630);
            this.panel_UniverseSelectDestination.TabIndex = 5;
            this.panel_UniverseSelectDestination.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_UniverseSelectDestination_Paint);
            // 
            // panel_ContainerSelectDestination
            // 
            this.bunifuFadeTransition.SetDecoration(this.panel_ContainerSelectDestination, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.panel_ContainerSelectDestination, BunifuAnimatorNS.DecorationType.None);
            this.panel_ContainerSelectDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContainerSelectDestination.ForeColor = System.Drawing.Color.Transparent;
            this.panel_ContainerSelectDestination.Location = new System.Drawing.Point(0, 51);
            this.panel_ContainerSelectDestination.Name = "panel_ContainerSelectDestination";
            this.panel_ContainerSelectDestination.Size = new System.Drawing.Size(306, 579);
            this.panel_ContainerSelectDestination.TabIndex = 2;
            this.panel_ContainerSelectDestination.Visible = false;
            // 
            // panel_TitleSelectDestination
            // 
            this.panel_TitleSelectDestination.Controls.Add(this.lbl_SelectDestination);
            this.bunifuFadeTransition.SetDecoration(this.panel_TitleSelectDestination, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.panel_TitleSelectDestination, BunifuAnimatorNS.DecorationType.None);
            this.panel_TitleSelectDestination.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitleSelectDestination.Location = new System.Drawing.Point(0, 0);
            this.panel_TitleSelectDestination.Name = "panel_TitleSelectDestination";
            this.panel_TitleSelectDestination.Size = new System.Drawing.Size(306, 51);
            this.panel_TitleSelectDestination.TabIndex = 1;
            this.panel_TitleSelectDestination.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_TitleSelectDestination_Paint);
            // 
            // lbl_SelectDestination
            // 
            this.lbl_SelectDestination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SelectDestination.AutoSize = true;
            this.bunifuLeafTransition.SetDecoration(this.lbl_SelectDestination, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.lbl_SelectDestination, BunifuAnimatorNS.DecorationType.None);
            this.lbl_SelectDestination.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic);
            this.lbl_SelectDestination.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_SelectDestination.Location = new System.Drawing.Point(68, 13);
            this.lbl_SelectDestination.Name = "lbl_SelectDestination";
            this.lbl_SelectDestination.Size = new System.Drawing.Size(184, 29);
            this.lbl_SelectDestination.TabIndex = 4;
            this.lbl_SelectDestination.Text = "Select Destination";
            // 
            // panel_UniverseVirtualMap
            // 
            this.panel_UniverseVirtualMap.BackColor = System.Drawing.SystemColors.Control;
            this.panel_UniverseVirtualMap.Controls.Add(this.pb_VirtualMap);
            this.bunifuFadeTransition.SetDecoration(this.panel_UniverseVirtualMap, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.panel_UniverseVirtualMap, BunifuAnimatorNS.DecorationType.None);
            this.panel_UniverseVirtualMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_UniverseVirtualMap.Location = new System.Drawing.Point(474, 51);
            this.panel_UniverseVirtualMap.Name = "panel_UniverseVirtualMap";
            this.panel_UniverseVirtualMap.Size = new System.Drawing.Size(577, 462);
            this.panel_UniverseVirtualMap.TabIndex = 9;
            this.panel_UniverseVirtualMap.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_UniverseVirtualMap_Paint);
            // 
            // pb_VirtualMap
            // 
            this.pb_VirtualMap.BackColor = System.Drawing.SystemColors.Control;
            this.pb_VirtualMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuLeafTransition.SetDecoration(this.pb_VirtualMap, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.pb_VirtualMap, BunifuAnimatorNS.DecorationType.None);
            this.pb_VirtualMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_VirtualMap.Location = new System.Drawing.Point(0, 0);
            this.pb_VirtualMap.Name = "pb_VirtualMap";
            this.pb_VirtualMap.Size = new System.Drawing.Size(577, 462);
            this.pb_VirtualMap.TabIndex = 0;
            this.pb_VirtualMap.TabStop = false;
            this.pb_VirtualMap.Visible = false;
            this.pb_VirtualMap.BackgroundImageChanged += new System.EventHandler(this.pb_VirtualMap_BackgroundImageChanged);
            this.pb_VirtualMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_VirtualMap_Paint);
            // 
            // panel_ContainerFloorSelector
            // 
            this.panel_ContainerFloorSelector.Controls.Add(this.tableLayoutPanel_FloorButtons);
            this.panel_ContainerFloorSelector.Controls.Add(this.panel_TitleSelectFloor);
            this.bunifuFadeTransition.SetDecoration(this.panel_ContainerFloorSelector, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.panel_ContainerFloorSelector, BunifuAnimatorNS.DecorationType.None);
            this.panel_ContainerFloorSelector.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ContainerFloorSelector.Location = new System.Drawing.Point(0, 0);
            this.panel_ContainerFloorSelector.Name = "panel_ContainerFloorSelector";
            this.panel_ContainerFloorSelector.Size = new System.Drawing.Size(168, 630);
            this.panel_ContainerFloorSelector.TabIndex = 4;
            this.panel_ContainerFloorSelector.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ContainerFloorSelector_Paint);
            // 
            // tableLayoutPanel_FloorButtons
            // 
            this.tableLayoutPanel_FloorButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel_FloorButtons.ColumnCount = 1;
            this.tableLayoutPanel_FloorButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_FloorButtons.Controls.Add(this.btn_10th, 0, 9);
            this.tableLayoutPanel_FloorButtons.Controls.Add(this.btn_9th, 0, 8);
            this.tableLayoutPanel_FloorButtons.Controls.Add(this.btn_8th, 0, 7);
            this.tableLayoutPanel_FloorButtons.Controls.Add(this.btn_7th, 0, 6);
            this.tableLayoutPanel_FloorButtons.Controls.Add(this.btn_6th, 0, 5);
            this.tableLayoutPanel_FloorButtons.Controls.Add(this.btn_5th, 0, 4);
            this.tableLayoutPanel_FloorButtons.Controls.Add(this.btn_4th, 0, 3);
            this.tableLayoutPanel_FloorButtons.Controls.Add(this.btn_3rd, 0, 2);
            this.tableLayoutPanel_FloorButtons.Controls.Add(this.btn_2nd, 0, 1);
            this.tableLayoutPanel_FloorButtons.Controls.Add(this.btn_UG, 0, 0);
            this.bunifuLeafTransition.SetDecoration(this.tableLayoutPanel_FloorButtons, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.tableLayoutPanel_FloorButtons, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel_FloorButtons.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel_FloorButtons.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel_FloorButtons.Name = "tableLayoutPanel_FloorButtons";
            this.tableLayoutPanel_FloorButtons.RowCount = 10;
            this.tableLayoutPanel_FloorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_FloorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_FloorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_FloorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_FloorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_FloorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_FloorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_FloorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_FloorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_FloorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_FloorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_FloorButtons.Size = new System.Drawing.Size(160, 572);
            this.tableLayoutPanel_FloorButtons.TabIndex = 4;
            // 
            // btn_10th
            // 
            this.btn_10th.Activecolor = System.Drawing.Color.SteelBlue;
            this.btn_10th.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_10th.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_10th.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_10th.BorderRadius = 5;
            this.btn_10th.ButtonText = "10th Floor";
            this.btn_10th.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFadeTransition.SetDecoration(this.btn_10th, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.btn_10th, BunifuAnimatorNS.DecorationType.None);
            this.btn_10th.DisabledColor = System.Drawing.Color.Gray;
            this.btn_10th.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_10th.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_10th.Iconimage = null;
            this.btn_10th.Iconimage_right = null;
            this.btn_10th.Iconimage_right_Selected = null;
            this.btn_10th.Iconimage_Selected = null;
            this.btn_10th.IconMarginLeft = 0;
            this.btn_10th.IconMarginRight = 0;
            this.btn_10th.IconRightVisible = true;
            this.btn_10th.IconRightZoom = 0D;
            this.btn_10th.IconVisible = true;
            this.btn_10th.IconZoom = 90D;
            this.btn_10th.IsTab = false;
            this.btn_10th.Location = new System.Drawing.Point(18, 520);
            this.btn_10th.Name = "btn_10th";
            this.btn_10th.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_10th.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btn_10th.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_10th.selected = false;
            this.btn_10th.Size = new System.Drawing.Size(123, 45);
            this.btn_10th.TabIndex = 8;
            this.btn_10th.Text = "10th Floor";
            this.btn_10th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_10th.Textcolor = System.Drawing.Color.White;
            this.btn_10th.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_10th.Click += new System.EventHandler(this.btn_10th_Click);
            // 
            // btn_9th
            // 
            this.btn_9th.Activecolor = System.Drawing.Color.SteelBlue;
            this.btn_9th.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_9th.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_9th.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_9th.BorderRadius = 5;
            this.btn_9th.ButtonText = "9th Floor";
            this.btn_9th.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFadeTransition.SetDecoration(this.btn_9th, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.btn_9th, BunifuAnimatorNS.DecorationType.None);
            this.btn_9th.DisabledColor = System.Drawing.Color.Gray;
            this.btn_9th.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9th.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_9th.Iconimage = null;
            this.btn_9th.Iconimage_right = null;
            this.btn_9th.Iconimage_right_Selected = null;
            this.btn_9th.Iconimage_Selected = null;
            this.btn_9th.IconMarginLeft = 0;
            this.btn_9th.IconMarginRight = 0;
            this.btn_9th.IconRightVisible = true;
            this.btn_9th.IconRightZoom = 0D;
            this.btn_9th.IconVisible = true;
            this.btn_9th.IconZoom = 90D;
            this.btn_9th.IsTab = false;
            this.btn_9th.Location = new System.Drawing.Point(18, 462);
            this.btn_9th.Name = "btn_9th";
            this.btn_9th.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_9th.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btn_9th.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_9th.selected = false;
            this.btn_9th.Size = new System.Drawing.Size(123, 45);
            this.btn_9th.TabIndex = 8;
            this.btn_9th.Text = "9th Floor";
            this.btn_9th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_9th.Textcolor = System.Drawing.Color.White;
            this.btn_9th.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9th.Click += new System.EventHandler(this.btn_9th_Click);
            // 
            // btn_8th
            // 
            this.btn_8th.Activecolor = System.Drawing.Color.SteelBlue;
            this.btn_8th.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_8th.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_8th.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_8th.BorderRadius = 5;
            this.btn_8th.ButtonText = "8th Floor";
            this.btn_8th.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFadeTransition.SetDecoration(this.btn_8th, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.btn_8th, BunifuAnimatorNS.DecorationType.None);
            this.btn_8th.DisabledColor = System.Drawing.Color.Gray;
            this.btn_8th.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8th.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_8th.Iconimage = null;
            this.btn_8th.Iconimage_right = null;
            this.btn_8th.Iconimage_right_Selected = null;
            this.btn_8th.Iconimage_Selected = null;
            this.btn_8th.IconMarginLeft = 0;
            this.btn_8th.IconMarginRight = 0;
            this.btn_8th.IconRightVisible = true;
            this.btn_8th.IconRightZoom = 0D;
            this.btn_8th.IconVisible = true;
            this.btn_8th.IconZoom = 90D;
            this.btn_8th.IsTab = false;
            this.btn_8th.Location = new System.Drawing.Point(18, 405);
            this.btn_8th.Name = "btn_8th";
            this.btn_8th.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_8th.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btn_8th.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_8th.selected = false;
            this.btn_8th.Size = new System.Drawing.Size(123, 45);
            this.btn_8th.TabIndex = 8;
            this.btn_8th.Text = "8th Floor";
            this.btn_8th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_8th.Textcolor = System.Drawing.Color.White;
            this.btn_8th.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8th.Click += new System.EventHandler(this.btn_8th_Click);
            // 
            // btn_7th
            // 
            this.btn_7th.Activecolor = System.Drawing.Color.SkyBlue;
            this.btn_7th.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_7th.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_7th.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_7th.BorderRadius = 5;
            this.btn_7th.ButtonText = "7th Floor";
            this.btn_7th.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFadeTransition.SetDecoration(this.btn_7th, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.btn_7th, BunifuAnimatorNS.DecorationType.None);
            this.btn_7th.DisabledColor = System.Drawing.Color.Gray;
            this.btn_7th.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7th.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_7th.Iconimage = null;
            this.btn_7th.Iconimage_right = null;
            this.btn_7th.Iconimage_right_Selected = null;
            this.btn_7th.Iconimage_Selected = null;
            this.btn_7th.IconMarginLeft = 0;
            this.btn_7th.IconMarginRight = 0;
            this.btn_7th.IconRightVisible = true;
            this.btn_7th.IconRightZoom = 0D;
            this.btn_7th.IconVisible = true;
            this.btn_7th.IconZoom = 90D;
            this.btn_7th.IsTab = false;
            this.btn_7th.Location = new System.Drawing.Point(18, 348);
            this.btn_7th.Name = "btn_7th";
            this.btn_7th.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_7th.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btn_7th.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_7th.selected = false;
            this.btn_7th.Size = new System.Drawing.Size(123, 45);
            this.btn_7th.TabIndex = 8;
            this.btn_7th.Text = "7th Floor";
            this.btn_7th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_7th.Textcolor = System.Drawing.Color.White;
            this.btn_7th.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7th.Click += new System.EventHandler(this.btn_7th_Click);
            // 
            // btn_6th
            // 
            this.btn_6th.Activecolor = System.Drawing.Color.SteelBlue;
            this.btn_6th.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_6th.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_6th.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_6th.BorderRadius = 5;
            this.btn_6th.ButtonText = "6th Floor";
            this.btn_6th.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFadeTransition.SetDecoration(this.btn_6th, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.btn_6th, BunifuAnimatorNS.DecorationType.None);
            this.btn_6th.DisabledColor = System.Drawing.Color.Gray;
            this.btn_6th.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6th.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_6th.Iconimage = null;
            this.btn_6th.Iconimage_right = null;
            this.btn_6th.Iconimage_right_Selected = null;
            this.btn_6th.Iconimage_Selected = null;
            this.btn_6th.IconMarginLeft = 0;
            this.btn_6th.IconMarginRight = 0;
            this.btn_6th.IconRightVisible = true;
            this.btn_6th.IconRightZoom = 0D;
            this.btn_6th.IconVisible = true;
            this.btn_6th.IconZoom = 90D;
            this.btn_6th.IsTab = false;
            this.btn_6th.Location = new System.Drawing.Point(18, 291);
            this.btn_6th.Name = "btn_6th";
            this.btn_6th.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_6th.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btn_6th.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_6th.selected = false;
            this.btn_6th.Size = new System.Drawing.Size(123, 45);
            this.btn_6th.TabIndex = 8;
            this.btn_6th.Text = "6th Floor";
            this.btn_6th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_6th.Textcolor = System.Drawing.Color.White;
            this.btn_6th.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6th.Click += new System.EventHandler(this.btn_6th_Click);
            // 
            // btn_5th
            // 
            this.btn_5th.Activecolor = System.Drawing.Color.SteelBlue;
            this.btn_5th.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_5th.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_5th.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_5th.BorderRadius = 5;
            this.btn_5th.ButtonText = "5th Floor";
            this.btn_5th.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFadeTransition.SetDecoration(this.btn_5th, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.btn_5th, BunifuAnimatorNS.DecorationType.None);
            this.btn_5th.DisabledColor = System.Drawing.Color.Gray;
            this.btn_5th.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5th.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_5th.Iconimage = null;
            this.btn_5th.Iconimage_right = null;
            this.btn_5th.Iconimage_right_Selected = null;
            this.btn_5th.Iconimage_Selected = null;
            this.btn_5th.IconMarginLeft = 0;
            this.btn_5th.IconMarginRight = 0;
            this.btn_5th.IconRightVisible = true;
            this.btn_5th.IconRightZoom = 0D;
            this.btn_5th.IconVisible = true;
            this.btn_5th.IconZoom = 90D;
            this.btn_5th.IsTab = false;
            this.btn_5th.Location = new System.Drawing.Point(18, 234);
            this.btn_5th.Name = "btn_5th";
            this.btn_5th.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_5th.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btn_5th.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_5th.selected = false;
            this.btn_5th.Size = new System.Drawing.Size(123, 45);
            this.btn_5th.TabIndex = 8;
            this.btn_5th.Text = "5th Floor";
            this.btn_5th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_5th.Textcolor = System.Drawing.Color.White;
            this.btn_5th.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5th.Click += new System.EventHandler(this.btn_5th_Click);
            // 
            // btn_4th
            // 
            this.btn_4th.Activecolor = System.Drawing.Color.SteelBlue;
            this.btn_4th.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_4th.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_4th.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_4th.BorderRadius = 5;
            this.btn_4th.ButtonText = "4th Floor";
            this.btn_4th.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFadeTransition.SetDecoration(this.btn_4th, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.btn_4th, BunifuAnimatorNS.DecorationType.None);
            this.btn_4th.DisabledColor = System.Drawing.Color.Gray;
            this.btn_4th.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4th.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_4th.Iconimage = null;
            this.btn_4th.Iconimage_right = null;
            this.btn_4th.Iconimage_right_Selected = null;
            this.btn_4th.Iconimage_Selected = null;
            this.btn_4th.IconMarginLeft = 0;
            this.btn_4th.IconMarginRight = 0;
            this.btn_4th.IconRightVisible = true;
            this.btn_4th.IconRightZoom = 0D;
            this.btn_4th.IconVisible = true;
            this.btn_4th.IconZoom = 90D;
            this.btn_4th.IsTab = false;
            this.btn_4th.Location = new System.Drawing.Point(18, 177);
            this.btn_4th.Name = "btn_4th";
            this.btn_4th.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_4th.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btn_4th.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_4th.selected = false;
            this.btn_4th.Size = new System.Drawing.Size(123, 45);
            this.btn_4th.TabIndex = 8;
            this.btn_4th.Text = "4th Floor";
            this.btn_4th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_4th.Textcolor = System.Drawing.Color.White;
            this.btn_4th.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4th.Click += new System.EventHandler(this.btn_4th_Click);
            // 
            // btn_3rd
            // 
            this.btn_3rd.Activecolor = System.Drawing.Color.SteelBlue;
            this.btn_3rd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_3rd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_3rd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_3rd.BorderRadius = 5;
            this.btn_3rd.ButtonText = "3rd Floor";
            this.btn_3rd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFadeTransition.SetDecoration(this.btn_3rd, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.btn_3rd, BunifuAnimatorNS.DecorationType.None);
            this.btn_3rd.DisabledColor = System.Drawing.Color.Gray;
            this.btn_3rd.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3rd.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_3rd.Iconimage = null;
            this.btn_3rd.Iconimage_right = null;
            this.btn_3rd.Iconimage_right_Selected = null;
            this.btn_3rd.Iconimage_Selected = null;
            this.btn_3rd.IconMarginLeft = 0;
            this.btn_3rd.IconMarginRight = 0;
            this.btn_3rd.IconRightVisible = true;
            this.btn_3rd.IconRightZoom = 0D;
            this.btn_3rd.IconVisible = true;
            this.btn_3rd.IconZoom = 90D;
            this.btn_3rd.IsTab = false;
            this.btn_3rd.Location = new System.Drawing.Point(18, 120);
            this.btn_3rd.Name = "btn_3rd";
            this.btn_3rd.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_3rd.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btn_3rd.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_3rd.selected = false;
            this.btn_3rd.Size = new System.Drawing.Size(123, 45);
            this.btn_3rd.TabIndex = 8;
            this.btn_3rd.Text = "3rd Floor";
            this.btn_3rd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_3rd.Textcolor = System.Drawing.Color.White;
            this.btn_3rd.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3rd.Click += new System.EventHandler(this.btn_3rd_Click);
            // 
            // btn_2nd
            // 
            this.btn_2nd.Activecolor = System.Drawing.Color.SteelBlue;
            this.btn_2nd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_2nd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_2nd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_2nd.BorderRadius = 5;
            this.btn_2nd.ButtonText = "2nd Floor";
            this.btn_2nd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFadeTransition.SetDecoration(this.btn_2nd, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.btn_2nd, BunifuAnimatorNS.DecorationType.None);
            this.btn_2nd.DisabledColor = System.Drawing.Color.Gray;
            this.btn_2nd.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2nd.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_2nd.Iconimage = null;
            this.btn_2nd.Iconimage_right = null;
            this.btn_2nd.Iconimage_right_Selected = null;
            this.btn_2nd.Iconimage_Selected = null;
            this.btn_2nd.IconMarginLeft = 0;
            this.btn_2nd.IconMarginRight = 0;
            this.btn_2nd.IconRightVisible = true;
            this.btn_2nd.IconRightZoom = 0D;
            this.btn_2nd.IconVisible = true;
            this.btn_2nd.IconZoom = 90D;
            this.btn_2nd.IsTab = false;
            this.btn_2nd.Location = new System.Drawing.Point(18, 63);
            this.btn_2nd.Name = "btn_2nd";
            this.btn_2nd.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_2nd.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btn_2nd.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_2nd.selected = false;
            this.btn_2nd.Size = new System.Drawing.Size(123, 45);
            this.btn_2nd.TabIndex = 8;
            this.btn_2nd.Text = "2nd Floor";
            this.btn_2nd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_2nd.Textcolor = System.Drawing.Color.White;
            this.btn_2nd.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2nd.Click += new System.EventHandler(this.btn_2nd_Click);
            // 
            // btn_UG
            // 
            this.btn_UG.Activecolor = System.Drawing.Color.SteelBlue;
            this.btn_UG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_UG.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_UG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_UG.BorderRadius = 5;
            this.btn_UG.ButtonText = "UG";
            this.btn_UG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFadeTransition.SetDecoration(this.btn_UG, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.btn_UG, BunifuAnimatorNS.DecorationType.None);
            this.btn_UG.DisabledColor = System.Drawing.Color.Gray;
            this.btn_UG.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UG.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_UG.Iconimage = null;
            this.btn_UG.Iconimage_right = null;
            this.btn_UG.Iconimage_right_Selected = null;
            this.btn_UG.Iconimage_Selected = null;
            this.btn_UG.IconMarginLeft = 0;
            this.btn_UG.IconMarginRight = 0;
            this.btn_UG.IconRightVisible = true;
            this.btn_UG.IconRightZoom = 0D;
            this.btn_UG.IconVisible = true;
            this.btn_UG.IconZoom = 90D;
            this.btn_UG.IsTab = false;
            this.btn_UG.Location = new System.Drawing.Point(18, 6);
            this.btn_UG.Name = "btn_UG";
            this.btn_UG.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_UG.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btn_UG.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_UG.selected = false;
            this.btn_UG.Size = new System.Drawing.Size(123, 45);
            this.btn_UG.TabIndex = 8;
            this.btn_UG.Tag = "";
            this.btn_UG.Text = "UG";
            this.btn_UG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_UG.Textcolor = System.Drawing.Color.White;
            this.btn_UG.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UG.Click += new System.EventHandler(this.btn_UG_Click);
            // 
            // panel_TitleSelectFloor
            // 
            this.panel_TitleSelectFloor.Controls.Add(this.lbl_SelectFloor);
            this.bunifuFadeTransition.SetDecoration(this.panel_TitleSelectFloor, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.panel_TitleSelectFloor, BunifuAnimatorNS.DecorationType.None);
            this.panel_TitleSelectFloor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitleSelectFloor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_TitleSelectFloor.Location = new System.Drawing.Point(0, 0);
            this.panel_TitleSelectFloor.Name = "panel_TitleSelectFloor";
            this.panel_TitleSelectFloor.Size = new System.Drawing.Size(168, 51);
            this.panel_TitleSelectFloor.TabIndex = 5;
            this.panel_TitleSelectFloor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_TitleSelectFloor_Paint);
            // 
            // lbl_SelectFloor
            // 
            this.lbl_SelectFloor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SelectFloor.AutoSize = true;
            this.bunifuLeafTransition.SetDecoration(this.lbl_SelectFloor, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.lbl_SelectFloor, BunifuAnimatorNS.DecorationType.None);
            this.lbl_SelectFloor.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic);
            this.lbl_SelectFloor.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_SelectFloor.Location = new System.Drawing.Point(26, 13);
            this.lbl_SelectFloor.Name = "lbl_SelectFloor";
            this.lbl_SelectFloor.Size = new System.Drawing.Size(124, 29);
            this.lbl_SelectFloor.TabIndex = 4;
            this.lbl_SelectFloor.Text = "Select Floor";
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.AutoSize = true;
            this.bunifuLeafTransition.SetDecoration(this.lbl_FormTitle, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.lbl_FormTitle, BunifuAnimatorNS.DecorationType.None);
            this.lbl_FormTitle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_FormTitle.Location = new System.Drawing.Point(37, 10);
            this.lbl_FormTitle.Name = "lbl_FormTitle";
            this.lbl_FormTitle.Size = new System.Drawing.Size(97, 16);
            this.lbl_FormTitle.TabIndex = 2;
            this.lbl_FormTitle.Text = "iLocator | Main";
            // 
            // pb_iLocatorLogo
            // 
            this.pb_iLocatorLogo.BackColor = System.Drawing.Color.Transparent;
            this.pb_iLocatorLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_iLocatorLogo.BackgroundImage")));
            this.pb_iLocatorLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuLeafTransition.SetDecoration(this.pb_iLocatorLogo, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this.pb_iLocatorLogo, BunifuAnimatorNS.DecorationType.None);
            this.pb_iLocatorLogo.Location = new System.Drawing.Point(9, 5);
            this.pb_iLocatorLogo.Name = "pb_iLocatorLogo";
            this.pb_iLocatorLogo.Size = new System.Drawing.Size(25, 25);
            this.pb_iLocatorLogo.TabIndex = 4;
            this.pb_iLocatorLogo.TabStop = false;
            // 
            // panel_ControlBox
            // 
            this.panel_ControlBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_ControlBox.Controls.Add(this.pb_iLocatorLogo);
            this.panel_ControlBox.Controls.Add(this.lbl_FormTitle);
            this.bunifuFadeTransition.SetDecoration(this.panel_ControlBox, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.panel_ControlBox, BunifuAnimatorNS.DecorationType.None);
            this.panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ControlBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_ControlBox.Location = new System.Drawing.Point(0, 0);
            this.panel_ControlBox.Name = "panel_ControlBox";
            this.panel_ControlBox.Size = new System.Drawing.Size(1051, 34);
            this.panel_ControlBox.TabIndex = 3;
            // 
            // panel_ContainerMain
            // 
            this.panel_ContainerMain.Controls.Add(this.panel_UniverseVirtualMap);
            this.panel_ContainerMain.Controls.Add(this.panel_DetailsSelectedDestination);
            this.panel_ContainerMain.Controls.Add(this.panel_TitleVirtualMap);
            this.panel_ContainerMain.Controls.Add(this.panel_UniverseSelectDestination);
            this.panel_ContainerMain.Controls.Add(this.panel_ContainerFloorSelector);
            this.bunifuFadeTransition.SetDecoration(this.panel_ContainerMain, BunifuAnimatorNS.DecorationType.None);
            this.bunifuLeafTransition.SetDecoration(this.panel_ContainerMain, BunifuAnimatorNS.DecorationType.None);
            this.panel_ContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContainerMain.Location = new System.Drawing.Point(0, 34);
            this.panel_ContainerMain.Name = "panel_ContainerMain";
            this.panel_ContainerMain.Size = new System.Drawing.Size(1051, 630);
            this.panel_ContainerMain.TabIndex = 10;
            this.panel_ContainerMain.Visible = false;
            // 
            // bunifuLeafTransition
            // 
            this.bunifuLeafTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuLeafTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
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
            animation1.TransparencyCoeff = 1F;
            this.bunifuLeafTransition.DefaultAnimation = animation1;
            this.bunifuLeafTransition.TimeStep = 0.1F;
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
            animation2.TransparencyCoeff = 0F;
            this.bunifuFadeTransition.DefaultAnimation = animation2;
            this.bunifuFadeTransition.TimeStep = 0.1F;
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 669);
            this.Controls.Add(this.panel_ContainerMain);
            this.Controls.Add(this.panel_ControlBox);
            this.bunifuLeafTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFadeTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Main";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 3, 5);
            this.Text = "iLocator | Main";
            this.Load += new System.EventHandler(this.form_Main_Load);
            this.panel_TitleVirtualMap.ResumeLayout(false);
            this.panel_TitleVirtualMap.PerformLayout();
            this.panel_DetailsSelectedDestination.ResumeLayout(false);
            this.panel_DetailsSelectedDestination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Replay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_BackToHome)).EndInit();
            this.panel_UniverseSelectDestination.ResumeLayout(false);
            this.panel_TitleSelectDestination.ResumeLayout(false);
            this.panel_TitleSelectDestination.PerformLayout();
            this.panel_UniverseVirtualMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_VirtualMap)).EndInit();
            this.panel_ContainerFloorSelector.ResumeLayout(false);
            this.tableLayoutPanel_FloorButtons.ResumeLayout(false);
            this.panel_TitleSelectFloor.ResumeLayout(false);
            this.panel_TitleSelectFloor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_iLocatorLogo)).EndInit();
            this.panel_ControlBox.ResumeLayout(false);
            this.panel_ControlBox.PerformLayout();
            this.panel_ContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private BunifuAnimatorNS.BunifuTransition bunifuLeafTransition;
        private System.Windows.Forms.Panel panel_ContainerMain;
        private System.Windows.Forms.Panel panel_ContainerFloorSelector;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_FloorButtons;
        private Bunifu.Framework.UI.BunifuFlatButton btn_10th;
        private Bunifu.Framework.UI.BunifuFlatButton btn_9th;
        private Bunifu.Framework.UI.BunifuFlatButton btn_8th;
        private Bunifu.Framework.UI.BunifuFlatButton btn_7th;
        private Bunifu.Framework.UI.BunifuFlatButton btn_6th;
        private Bunifu.Framework.UI.BunifuFlatButton btn_5th;
        private Bunifu.Framework.UI.BunifuFlatButton btn_4th;
        private Bunifu.Framework.UI.BunifuFlatButton btn_3rd;
        private Bunifu.Framework.UI.BunifuFlatButton btn_2nd;
        private Bunifu.Framework.UI.BunifuFlatButton btn_UG;
        private System.Windows.Forms.Panel panel_TitleSelectFloor;
        private System.Windows.Forms.Label lbl_SelectFloor;
        private System.Windows.Forms.Panel panel_UniverseSelectDestination;
        private System.Windows.Forms.Panel panel_ContainerSelectDestination;
        private System.Windows.Forms.Panel panel_TitleSelectDestination;
        private System.Windows.Forms.Label lbl_SelectDestination;
        private System.Windows.Forms.Panel panel_UniverseVirtualMap;
        private System.Windows.Forms.PictureBox pb_VirtualMap;
        private System.Windows.Forms.Panel panel_TitleVirtualMap;
        private System.Windows.Forms.Label lbl_VirtualMap;
        private System.Windows.Forms.Panel panel_DetailsSelectedDestination;
        private System.Windows.Forms.Label lbl_Replay;
        private System.Windows.Forms.PictureBox btn_Replay;
        private System.Windows.Forms.Label lbl_GoHome;
        private System.Windows.Forms.PictureBox btn_BackToHome;
        private System.Windows.Forms.Label lbl_EstimatedDistance;
        private System.Windows.Forms.Label lbl_EstimatedTime;
        private System.Windows.Forms.Panel panel_ControlBox;
        private System.Windows.Forms.PictureBox pb_iLocatorLogo;
        private System.Windows.Forms.Label lbl_FormTitle;
        private BunifuAnimatorNS.BunifuTransition bunifuFadeTransition;
        private System.Windows.Forms.Label lblFloor;
    }
}