using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Bunifu.Framework.UI;

namespace iLocatorAstar
{
    public partial class form_SelectUser : Form
    {

        public bool Animation = false;

        public form_SelectUser()
        {
            InitializeComponent();
        }
      
        //FORM LOAD
        private void form_SelectUser_Load(object sender, EventArgs e)
        {
            Loading_Form.Start();

            //FULLSCREEN UPON LOAD
            WindowState = FormWindowState.Maximized;

            Form fc = Application.OpenForms["form_WelcomePage"];
            if (fc != null)
            {
                fc.Hide();
            }


            if (lbl_Description.Visible == false || lbl_TimeToday.Visible == false)
            {
                bunifuTransition1.ShowSync(lbl_Description);
                bunifuFadeTransition.ShowSync(lbl_TimeToday);            
            }
            else
            {
                bunifuTransition1.HideSync(lbl_Description);
            }

            //IF USER IDLE FOR 1MIN, AUTOMATICALLY GOES BACK TO WELCOME PAGE

            this.Animation = true;

        }

        public string currentFloor;

        //EVENT BUTTON CLICK
        private void btnClick(object sender, EventArgs e)
        {                
            BunifuTileButton btn = (BunifuTileButton) sender;
            switch (btn.Name)
            {
                case "btn_Back":
                    form_WelcomePage WelcomePageForm = new form_WelcomePage();
                    WelcomePageForm.Show();
                    this.Hide();
                    break;
                default:
                    form_Main _Mainform = new form_Main();
                    _Mainform.currentFloor = this.currentFloor;
                    _Mainform.Show();
                    _Mainform.usertype = btn.LabelText;
                    break; 
            }
        }

        private void btn_Student_MouseHover(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(btn_Student);
        }

        private void idleTime_Tick(object sender, EventArgs e)
        {
            form_WelcomePage _Welcomepage = new form_WelcomePage();
            _Welcomepage.Show();

            this.Hide();
        }

        private void timerTick(object sender, EventArgs e)
        {
            this.lbl_TimeToday.Text = DateTime.Now.ToString();
        }

        private void Loading_Form_Tick(object sender, EventArgs e)
        {
            Loading_Form.Stop();
            btn_Back.Enabled = true;
            btn_Student.Enabled = true;
            btn_Guest.Enabled = true;
            btn_Parents.Enabled = true;
            btn_Alumni.Enabled = true;
        }
    }
}
