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

        //FORM LOAD
        private void form_SelectUser_Load(object sender, EventArgs e)
        {
            //FULLSCREEN UPON LOAD
            WindowState = FormWindowState.Maximized;

            ////Make sure Welcome Page Form is Hide
            //Form fc = Application.OpenForms["form_WelcomePage"];
            //if (fc != null)
            //{
            //    fc.Hide();
            //}

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

            //IF USER IDLE FOR 1MIN, AUTOMATICALLY GOES BACK TO WELCOME PAGE
            idleTime.Tick += new EventHandler(idleTime_Tick);
            idleTime.Stop();
            idleTime.Start();
        }

        //EVENT BUTTON CLICK
        Button btn = new Button();
        private void btnClick(object sender, EventArgs e)
        {
            idleTime.Stop();
            form_Main _Mainform = new form_Main();
            _Mainform.Show();
            this.Hide(); 
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            idleTime.Stop();
            form_WelcomePage wp = new form_WelcomePage();
            wp.Show();
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

        private void timerTick(object sender, EventArgs e)
        {
            this.lbl_TimeToday.Text = DateTime.Now.ToString();
        }

        //private void panel_ContainerSelectUser_Paint_1(object sender, PaintEventArgs e)
        //{
        //    ControlPaint.DrawBorder(e.Graphics, this.panel_ContainerSelectUser.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        //}
    }
}
