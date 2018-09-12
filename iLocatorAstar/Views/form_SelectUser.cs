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
        public string currentFloor;

        public form_SelectUser()
        {
            InitializeComponent();
        }
      
        //FORM LOAD
        private void form_SelectUser_Load(object sender, EventArgs e)
        {
            //FULLSCREEN UPON LOAD
            WindowState = FormWindowState.Maximized;

            //TRANSITION OF FORMS
            bunifuTransition.ShowSync(panel_ContainerUniverse);
        }

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
                    this.Hide();
                    _Mainform.usertype = btn.LabelText;
                    break; 
            }
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

    }
}
