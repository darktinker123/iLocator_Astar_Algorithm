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

            if (tableLayoutPanel_SelectUser.Visible == false || lbl_Description.Visible == false || lbl_TimeToday.Visible == false)
            {
                bunifuTransition1.ShowSync(tableLayoutPanel_SelectUser);
                bunifuTransition1.ShowSync(lbl_Description);
                bunifuFadeTransition.ShowSync(lbl_TimeToday);
            }
            else
            {
                bunifuTransition1.HideSync(lbl_Description);
                bunifuTransition1.HideSync(tableLayoutPanel_SelectUser);
            }

            // If User is Idle for 1 minute, back to the Welcome Page
            idleTime.Tick += new EventHandler(idleTime_Tick);
            idleTime.Stop();
            idleTime.Start();

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            // Close Application
            System_Message _MessegeSystem = new System_Message();
            _MessegeSystem.ShowDialog();

            // Uncomment me if you wan't simple Application Exit Message
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
            idleTime.Stop();
            form_Main _Mainform = new form_Main();
            _Mainform.Show();
            this.Hide();
           

        }

        private void btn_Guest_Click(object sender, EventArgs e)
        {
            idleTime.Stop();
            form_Main _Mainform = new form_Main();
            _Mainform.Show();
            this.Hide();

        }

        private void btn_Alumni_Click(object sender, EventArgs e)
        {
            idleTime.Stop();
            form_Main _Mainform = new form_Main();
            _Mainform.Show();
            this.Hide();
        }

        private void btn_Parents_Click(object sender, EventArgs e)
        {
            idleTime.Stop();
            form_Main _Mainform = new form_Main();
            _Mainform.Show();
            this.Hide();
        }

        private void btn_Student_MouseHover(object sender, EventArgs e)
        {

            bunifuTransition1.ShowSync(btn_Student);
        }

        private void idleTime_Tick(object sender, EventArgs e)
        {
            idleTime.Stop();
            form_WelcomePage _Welcomepage = new form_WelcomePage();
            _Welcomepage.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            idleTime.Stop();
            form_WelcomePage _Welcomepage = new form_WelcomePage();
            _Welcomepage.Show();
            this.Hide();

        }

        private void time_Timer_Tick(object sender, EventArgs e)
        {
            this.lbl_TimeToday.Text = DateTime.Now.ToString();
        }
    }
}
