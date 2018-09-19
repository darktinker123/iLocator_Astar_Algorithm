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
            dgv_UserLogs.DataSource = db.v_userlogs;
            dgv_UserLogs.ClearSelection();
            displaySummary();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgv_UserLogs.DataSource = db.sp_SearchUserLogs(txtSearch.Text);
            dgv_UserLogs.ClearSelection();
        }

        private void displaySummary()
        {
            int total = dgv_UserLogs.Rows.Count;
            lblOverallTotalEntries.Text = total+" entries";

            int student = 0;
            int guest = 0;
            int alumni = 0;
            int parent = 0;

            for (int x = 1; x < total; x++)
            {
                switch (dgv_UserLogs.Rows[x].Cells[1].Value.ToString())
                {
                    case "Student":
                        student++;
                        break;
                    case "Guest":
                        guest++;
                        break;
                    case "Alumni":
                        alumni++;
                        break;
                    default:
                        parent++;
                        break;
                }
            }

            lblTotalStudent.Text = student + " students";
            lblTotalGuest.Text = guest + " guests";
            lblTotalAlumni.Text = alumni + " alumni";
            lblTotalParent.Text = parent + " parent/s";



        }


    }
}
