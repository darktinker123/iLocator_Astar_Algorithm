using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLocatorAstar
{
    public partial class form_SelectUser : Form
    {


        public form_SelectUser()
        {
            InitializeComponent();

            //btn_UserGuest.FlatAppearance.MouseOverBackColor = Button.DefaultBackColor;
            //btn_UserGuest.BackColorChanged += (s, e) =>
            //{
            //    btn_UserGuest.FlatAppearance.MouseOverBackColor = btn_UserGuest.BackColor;
            //};
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel_ContainerSelectUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form_SelectUser_Load(object sender, EventArgs e)
        {
            // Make Application Fullscreen when Open
            WindowState = FormWindowState.Maximized;

            if (tableLayoutPanel_SelectUser.Visible == false)
            {
                bunifuTransition1.ShowSync(tableLayoutPanel_SelectUser);
            }
            else
            {
                bunifuTransition1.HideSync(tableLayoutPanel_SelectUser);
            }



        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            // Close Application
            System_Message _MessegeSystem = new System_Message();
            _MessegeSystem.ShowDialog();

            //if (MessageBox.Show("Are you sure?", "System Messege", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //else
            //{
            //    return;
            //}
        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
            form_Main _MainForm = new form_Main();
            this.Hide();
            _MainForm.Show();
        }

        private void btn_Guest_Click(object sender, EventArgs e)
        {
            form_Main _MainForm = new form_Main();
            this.Hide();
            _MainForm.Show();
        }

        private void btn_Alumni_Click(object sender, EventArgs e)
        {
            form_Main _MainForm = new form_Main();
            this.Hide();
            _MainForm.Show();
        }

        private void btn_Parents_Click(object sender, EventArgs e)
        {
            form_Main _MainForm = new form_Main();
            this.Hide();
            _MainForm.Show();
        }

        private void btn_Student_MouseHover(object sender, EventArgs e)
        {

            bunifuTransition1.ShowSync(btn_Student);
        }
    }
}
