using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace iLocatorAstar
{
    public partial class form_AdminDashboard : Form
    {
        public form_AdminDashboard()
        {
            InitializeComponent();
        }
        
        private void form_AdminDashboard_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            DefaultPage();
        }

        private void pb_SideMenu_Click(object sender, EventArgs e)
        {
            if (panel_SideNav.Width == 60)
            {
                panel_SideNav.Visible = false;
                pb_Admin.Visible = false;
                lbl_Admin.Visible = false;
                separator_SideNav.Visible = false;
                panel_SideNav.Width = 250;
                bunifuTransition1.ShowSync(panel_SideNav);
                bunifuTransition3.ShowSync(pb_Admin);
                bunifuTransition4.ShowSync(lbl_Admin);
                bunifuTransition4.ShowSync(separator_SideNav);
            }
            else
            {
                panel_SideNav.Visible = false;
                lbl_Admin.Visible = false;
                pb_Admin.Visible = false;
                separator_SideNav.Visible = false;
                panel_SideNav.Width = 60;
                bunifuTransition2.ShowSync(panel_SideNav);
            }
        }

        private void form_AdminDashboard_Click(object sender, EventArgs e)
        {
            if (panel_SideNav.Width == 250)
            {
                panel_SideNav.Visible = false;
                lbl_Admin.Visible = false;
                pb_Admin.Visible = false;
                separator_SideNav.Visible = false;
                panel_SideNav.Width = 60;
                bunifuTransition2.ShowSync(panel_SideNav);
            }
        }
     
        private void btn_SideNav_Logout_Click(object sender, EventArgs e)
        {
            form_WelcomePage WelcomePageForm = new form_WelcomePage();
            WelcomePageForm.Show();
            this.Hide();
        }


        private void btn_SideNav_Logs_Click(object sender, EventArgs e)
        {
            panel_UniverseAdmin.Controls.Clear();

            UC_UserLogs frm_UserLogs = new UC_UserLogs();        
            panel_UniverseAdmin.Controls.Add(frm_UserLogs);
            frm_UserLogs.Dock = DockStyle.Fill;
        }

        private void btn_SideNav_Home_Click(object sender, EventArgs e)
        {
            DefaultPage();
        }

        private void DefaultPage()
        {
            panel_UniverseAdmin.Controls.Clear();

            UC_Admin_Dashboard frm_AdminDashboard = new UC_Admin_Dashboard();
            panel_UniverseAdmin.Controls.Add(frm_AdminDashboard);
            frm_AdminDashboard.Dock = DockStyle.Fill;
        }

    }
}
