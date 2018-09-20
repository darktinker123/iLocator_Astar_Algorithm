namespace iLocatorAstar
{
    partial class UC_UserLogs
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_UserLogs = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.userLogIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLogTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vuserlogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbiLocatorDataSet = new iLocatorAstar.dbiLocatorDataSet();
            this.v_userlogsTableAdapter = new iLocatorAstar.dbiLocatorDataSetTableAdapters.v_userlogsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalGuest = new System.Windows.Forms.Label();
            this.lblTotalAlumni = new System.Windows.Forms.Label();
            this.lblTotalParent = new System.Windows.Forms.Label();
            this.lblTotalStudent = new System.Windows.Forms.Label();
            this.lblOverallTotalEntries = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuserlogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbiLocatorDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_UserLogs
            // 
            this.dgv_UserLogs.AllowUserToAddRows = false;
            this.dgv_UserLogs.AllowUserToDeleteRows = false;
            this.dgv_UserLogs.AllowUserToResizeColumns = false;
            this.dgv_UserLogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_UserLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_UserLogs.AutoGenerateColumns = false;
            this.dgv_UserLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UserLogs.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_UserLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_UserLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UserLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_UserLogs.ColumnHeadersHeight = 50;
            this.dgv_UserLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userLogIDDataGridViewTextBoxColumn,
            this.usertypeDataGridViewTextBoxColumn,
            this.currentLocationDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.userLogTimeDataGridViewTextBoxColumn});
            this.dgv_UserLogs.DataSource = this.vuserlogsBindingSource;
            this.dgv_UserLogs.DoubleBuffered = true;
            this.dgv_UserLogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_UserLogs.EnableHeadersVisualStyles = false;
            this.dgv_UserLogs.HeaderBgColor = System.Drawing.Color.SkyBlue;
            this.dgv_UserLogs.HeaderForeColor = System.Drawing.Color.Black;
            this.dgv_UserLogs.Location = new System.Drawing.Point(429, 83);
            this.dgv_UserLogs.Margin = new System.Windows.Forms.Padding(5);
            this.dgv_UserLogs.MultiSelect = false;
            this.dgv_UserLogs.Name = "dgv_UserLogs";
            this.dgv_UserLogs.ReadOnly = true;
            this.dgv_UserLogs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UserLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_UserLogs.RowHeadersVisible = false;
            this.dgv_UserLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UserLogs.ShowCellErrors = false;
            this.dgv_UserLogs.ShowCellToolTips = false;
            this.dgv_UserLogs.ShowEditingIcon = false;
            this.dgv_UserLogs.ShowRowErrors = false;
            this.dgv_UserLogs.Size = new System.Drawing.Size(852, 596);
            this.dgv_UserLogs.TabIndex = 0;
            // 
            // userLogIDDataGridViewTextBoxColumn
            // 
            this.userLogIDDataGridViewTextBoxColumn.DataPropertyName = "userLogID";
            this.userLogIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.userLogIDDataGridViewTextBoxColumn.Name = "userLogIDDataGridViewTextBoxColumn";
            this.userLogIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usertypeDataGridViewTextBoxColumn
            // 
            this.usertypeDataGridViewTextBoxColumn.DataPropertyName = "usertype";
            this.usertypeDataGridViewTextBoxColumn.HeaderText = "user type";
            this.usertypeDataGridViewTextBoxColumn.Name = "usertypeDataGridViewTextBoxColumn";
            this.usertypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentLocationDataGridViewTextBoxColumn
            // 
            this.currentLocationDataGridViewTextBoxColumn.DataPropertyName = "currentLocation";
            this.currentLocationDataGridViewTextBoxColumn.HeaderText = "starting point";
            this.currentLocationDataGridViewTextBoxColumn.Name = "currentLocationDataGridViewTextBoxColumn";
            this.currentLocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userLogTimeDataGridViewTextBoxColumn
            // 
            this.userLogTimeDataGridViewTextBoxColumn.DataPropertyName = "userLogTime";
            this.userLogTimeDataGridViewTextBoxColumn.HeaderText = "user log time";
            this.userLogTimeDataGridViewTextBoxColumn.Name = "userLogTimeDataGridViewTextBoxColumn";
            this.userLogTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vuserlogsBindingSource
            // 
            this.vuserlogsBindingSource.DataMember = "v_userlogs";
            this.vuserlogsBindingSource.DataSource = this.dbiLocatorDataSet;
            // 
            // dbiLocatorDataSet
            // 
            this.dbiLocatorDataSet.DataSetName = "dbiLocatorDataSet";
            this.dbiLocatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_userlogsTableAdapter
            // 
            this.v_userlogsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "SUMMARY OF USER LOGS:";
            // 
            // cmbMonth
            // 
            this.cmbMonth.BackColor = System.Drawing.Color.White;
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(71, 142);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(216, 31);
            this.cmbMonth.TabIndex = 7;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select year:";
            // 
            // cmbYear
            // 
            this.cmbYear.BackColor = System.Drawing.Color.White;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(71, 67);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(216, 31);
            this.cmbYear.TabIndex = 9;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Select user type:";
            // 
            // cmbUserType
            // 
            this.cmbUserType.BackColor = System.Drawing.Color.White;
            this.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "All",
            "Student",
            "Guest",
            "Alumni",
            "Parent/s"});
            this.cmbUserType.Location = new System.Drawing.Point(71, 217);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(216, 31);
            this.cmbUserType.TabIndex = 11;
            this.cmbUserType.SelectedIndexChanged += new System.EventHandler(this.cmbUserType_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalGuest);
            this.groupBox1.Controls.Add(this.lblTotalAlumni);
            this.groupBox1.Controls.Add(this.lblTotalParent);
            this.groupBox1.Controls.Add(this.lblTotalStudent);
            this.groupBox1.Controls.Add(this.lblOverallTotalEntries);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbUserType);
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbYear);
            this.groupBox1.Location = new System.Drawing.Point(30, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 441);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lblTotalGuest
            // 
            this.lblTotalGuest.AutoSize = true;
            this.lblTotalGuest.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGuest.Location = new System.Drawing.Point(155, 337);
            this.lblTotalGuest.Name = "lblTotalGuest";
            this.lblTotalGuest.Size = new System.Drawing.Size(70, 24);
            this.lblTotalGuest.TabIndex = 28;
            this.lblTotalGuest.Text = "0 guest";
            this.lblTotalGuest.Visible = false;
            // 
            // lblTotalAlumni
            // 
            this.lblTotalAlumni.AutoSize = true;
            this.lblTotalAlumni.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAlumni.Location = new System.Drawing.Point(155, 361);
            this.lblTotalAlumni.Name = "lblTotalAlumni";
            this.lblTotalAlumni.Size = new System.Drawing.Size(83, 24);
            this.lblTotalAlumni.TabIndex = 27;
            this.lblTotalAlumni.Text = "0 alumni";
            this.lblTotalAlumni.Visible = false;
            // 
            // lblTotalParent
            // 
            this.lblTotalParent.AutoSize = true;
            this.lblTotalParent.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalParent.Location = new System.Drawing.Point(155, 385);
            this.lblTotalParent.Name = "lblTotalParent";
            this.lblTotalParent.Size = new System.Drawing.Size(81, 24);
            this.lblTotalParent.TabIndex = 26;
            this.lblTotalParent.Text = "0 parent";
            this.lblTotalParent.Visible = false;
            // 
            // lblTotalStudent
            // 
            this.lblTotalStudent.AutoSize = true;
            this.lblTotalStudent.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudent.Location = new System.Drawing.Point(155, 313);
            this.lblTotalStudent.Name = "lblTotalStudent";
            this.lblTotalStudent.Size = new System.Drawing.Size(90, 24);
            this.lblTotalStudent.TabIndex = 25;
            this.lblTotalStudent.Text = "0 student";
            this.lblTotalStudent.Visible = false;
            // 
            // lblOverallTotalEntries
            // 
            this.lblOverallTotalEntries.AutoSize = true;
            this.lblOverallTotalEntries.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallTotalEntries.Location = new System.Drawing.Point(164, 280);
            this.lblOverallTotalEntries.Name = "lblOverallTotalEntries";
            this.lblOverallTotalEntries.Size = new System.Drawing.Size(83, 24);
            this.lblOverallTotalEntries.TabIndex = 24;
            this.lblOverallTotalEntries.Text = "0 entries";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Total of:";
            // 
            // UC_UserLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_UserLogs);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_UserLogs";
            this.Size = new System.Drawing.Size(1309, 720);
            this.Load += new System.EventHandler(this.UC_UserLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuserlogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbiLocatorDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_UserLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLogIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLogTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vuserlogsBindingSource;
        private dbiLocatorDataSet dbiLocatorDataSet;
        private dbiLocatorDataSetTableAdapters.v_userlogsTableAdapter v_userlogsTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalGuest;
        private System.Windows.Forms.Label lblTotalAlumni;
        private System.Windows.Forms.Label lblTotalParent;
        private System.Windows.Forms.Label lblTotalStudent;
        private System.Windows.Forms.Label lblOverallTotalEntries;
        private System.Windows.Forms.Label label4;
    }
}
