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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid_UserLogs = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_UserLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_UserLogs
            // 
            this.dataGrid_UserLogs.AllowUserToAddRows = false;
            this.dataGrid_UserLogs.AllowUserToDeleteRows = false;
            this.dataGrid_UserLogs.AllowUserToResizeColumns = false;
            this.dataGrid_UserLogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid_UserLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_UserLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_UserLogs.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGrid_UserLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_UserLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_UserLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_UserLogs.ColumnHeadersHeight = 50;
            this.dataGrid_UserLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_UserLogs.DoubleBuffered = true;
            this.dataGrid_UserLogs.EnableHeadersVisualStyles = false;
            this.dataGrid_UserLogs.HeaderBgColor = System.Drawing.Color.Blue;
            this.dataGrid_UserLogs.HeaderForeColor = System.Drawing.Color.White;
            this.dataGrid_UserLogs.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_UserLogs.Name = "dataGrid_UserLogs";
            this.dataGrid_UserLogs.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_UserLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_UserLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_UserLogs.ShowCellErrors = false;
            this.dataGrid_UserLogs.ShowCellToolTips = false;
            this.dataGrid_UserLogs.ShowEditingIcon = false;
            this.dataGrid_UserLogs.ShowRowErrors = false;
            this.dataGrid_UserLogs.Size = new System.Drawing.Size(662, 449);
            this.dataGrid_UserLogs.TabIndex = 0;
            // 
            // UC_UserLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGrid_UserLogs);
            this.Name = "UC_UserLogs";
            this.Size = new System.Drawing.Size(662, 449);
            this.Load += new System.EventHandler(this.UC_UserLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_UserLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGrid_UserLogs;
    }
}
