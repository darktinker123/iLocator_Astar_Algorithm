using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLocatorAstar
{
    public partial class UC_UserLogs : UserControl
    {
        public UC_UserLogs()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void UC_UserLogs_Load(object sender, EventArgs e)
        {
            dgvUserlogs.DataSource = db.v_userlogs;
            dgvUserlogs.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvUserlogs.DataSource= db.sp_SearchUserLogs(txtSearch.Text);
            dgvUserlogs.ClearSelection();
        }
    }
}
