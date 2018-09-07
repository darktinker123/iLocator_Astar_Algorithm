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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUserlogs = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dbiLocatorDataSet = new iLocatorAstar.dbiLocatorDataSet();
            this.vuserlogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_userlogsTableAdapter = new iLocatorAstar.dbiLocatorDataSetTableAdapters.v_userlogsTableAdapter();
            this.userLogIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLogTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserlogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbiLocatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuserlogsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserlogs
            // 
            this.dgvUserlogs.AllowUserToAddRows = false;
            this.dgvUserlogs.AllowUserToDeleteRows = false;
            this.dgvUserlogs.AllowUserToResizeColumns = false;
            this.dgvUserlogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUserlogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserlogs.AutoGenerateColumns = false;
            this.dgvUserlogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserlogs.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvUserlogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserlogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserlogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserlogs.ColumnHeadersHeight = 50;
            this.dgvUserlogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userLogIDDataGridViewTextBoxColumn,
            this.usertypeDataGridViewTextBoxColumn,
            this.currentLocationDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.userLogTimeDataGridViewTextBoxColumn});
            this.dgvUserlogs.DataSource = this.vuserlogsBindingSource;
            this.dgvUserlogs.DoubleBuffered = true;
            this.dgvUserlogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUserlogs.EnableHeadersVisualStyles = false;
            this.dgvUserlogs.HeaderBgColor = System.Drawing.Color.SkyBlue;
            this.dgvUserlogs.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvUserlogs.Location = new System.Drawing.Point(53, 116);
            this.dgvUserlogs.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvUserlogs.MultiSelect = false;
            this.dgvUserlogs.Name = "dgvUserlogs";
            this.dgvUserlogs.ReadOnly = true;
            this.dgvUserlogs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserlogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserlogs.RowHeadersVisible = false;
            this.dgvUserlogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserlogs.ShowCellErrors = false;
            this.dgvUserlogs.ShowCellToolTips = false;
            this.dgvUserlogs.ShowEditingIcon = false;
            this.dgvUserlogs.ShowRowErrors = false;
            this.dgvUserlogs.Size = new System.Drawing.Size(1002, 761);
            this.dgvUserlogs.TabIndex = 0;
            // 
            // dbiLocatorDataSet
            // 
            this.dbiLocatorDataSet.DataSetName = "dbiLocatorDataSet";
            this.dbiLocatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vuserlogsBindingSource
            // 
            this.vuserlogsBindingSource.DataMember = "v_userlogs";
            this.vuserlogsBindingSource.DataSource = this.dbiLocatorDataSet;
            // 
            // v_userlogsTableAdapter
            // 
            this.v_userlogsTableAdapter.ClearBeforeFill = true;
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
            this.currentLocationDataGridViewTextBoxColumn.HeaderText = "current location";
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
            this.userLogTimeDataGridViewTextBoxColumn.HeaderText = "log time";
            this.userLogTimeDataGridViewTextBoxColumn.Name = "userLogTimeDataGridViewTextBoxColumn";
            this.userLogTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(297, 64);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(541, 32);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // UC_UserLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvUserlogs);
            this.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UC_UserLogs";
            this.Size = new System.Drawing.Size(1113, 901);
            this.Load += new System.EventHandler(this.UC_UserLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserlogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbiLocatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuserlogsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvUserlogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLogIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLogTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vuserlogsBindingSource;
        private dbiLocatorDataSet dbiLocatorDataSet;
        private dbiLocatorDataSetTableAdapters.v_userlogsTableAdapter v_userlogsTableAdapter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}
