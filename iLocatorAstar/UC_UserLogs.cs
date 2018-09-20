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
            cmbYear.DataSource = Enumerable.Range(2018, 6).ToList();
        }
          
        int year = 0;
        int month = 0;
        string usertype = "";

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            year = int.Parse(cmbYear.SelectedItem.ToString());
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbMonth.SelectedIndex + 1;
            string m = "0" + index;
            month = int.Parse(m);
        }

        private void cmbUserType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            usertype = cmbUserType.SelectedItem.ToString();
            switch (usertype)
            {
                case "All":
                    dgv_UserLogs.DataSource = db.sp_ViewSummaryAll(year, month);
                    break;
                default:
                    dgv_UserLogs.DataSource = db.sp_ViewSummaryByUserType(year, month, usertype);
                    break;
            }
            dgv_UserLogs.ClearSelection();
            displaySummary();
        }

        private void displaySummary()
        {
            int total = dgv_UserLogs.Rows.Count;
            lblOverallTotalEntries.Text = total + " entries";

            if (usertype == "All")
            {
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

                showUsertypeSummary(true);
                lblTotalStudent.Text = student + " students";
                lblTotalGuest.Text = guest + " guests";
                lblTotalAlumni.Text = alumni + " alumni";
                lblTotalParent.Text = parent + " parent/s";
            }
            else
            {
                showUsertypeSummary(false);
            }
            
        }

        private void showUsertypeSummary(bool isVisible)
        {
            lblTotalStudent.Visible = isVisible;
            lblTotalGuest.Visible = isVisible;
            lblTotalAlumni.Visible = isVisible;
            lblTotalParent.Visible = isVisible;
        }


    }
}
