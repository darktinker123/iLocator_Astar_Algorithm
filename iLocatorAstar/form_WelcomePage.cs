using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace iLocatorAstar
{
    public partial class form_WelcomePage : Form
    {

        public form_WelcomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           var text = File.ReadLines(Environment.CurrentDirectory.ToString()+@"..\..\..\setup\config.ini");
           
            string result="";
            foreach (var item in text)
            {
                result = item.ToString();
            }
            MessageBox.Show(result.ToString());

            // Make Application Fullscreen when Open
            WindowState = FormWindowState.Maximized;

            // Transition Logo ACT
            if (pb_ACTIco.Visible == false)
            {
                bunifuACTTransition.ShowSync(pb_ACTIco);
            }
            else
            {
                bunifuACTTransition.HideSync(pb_ACTIco);
            }

            //Transition Title, Description, Button & Social Media
            if (lbl_iLocatorWelcomePage.Visible == false || lbl_WelcomeDescription.Visible == false || lbl_WelcomeDescription.Visible == false || tableLayoutPanel_SocialMedia.Visible == false || lbl_TimeToday.Visible == false)
            {
                bunifuFadeTransition.ShowSync(lbl_iLocatorWelcomePage);              
                bunifuFadeTransition.ShowSync(lbl_WelcomeDescription);
                bunifuFadeTransition.ShowSync(tableLayoutPanel_SocialMedia);
                bunifuFadeTransition.ShowSync(btn_Next);
                bunifuFadeTransition.ShowSync(lbl_TimeToday);
            }


        }

        // When X button is click
        private void btn_Close_Click(object sender, EventArgs e)
        {
            System_Message _MessegeSystem = new System_Message();
            _MessegeSystem.ShowDialog();
        }

        // When Facebook Icon is Click
        private void pb_FacebookIco_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com");
        }

        // When Google Plus Icon is Click
        private void pb_gPlusIco_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.plus.google.com");
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            form_SelectUser _FormSelect = new form_SelectUser();
            _FormSelect.Show();
            this.Hide();
        }

        // When System Info Icon is Click
        private void pb_InfoIco_Click(object sender, EventArgs e)
        {
            System_Info _SystemInfo = new System_Info();
            _SystemInfo.ShowDialog();
        }


        // When Twitter Icon is Click
        private void pb_TwitterIco_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.twitter.com");

        }
        
        // Code for Date and Time Below
        private void Time_Timer_Tick(object sender, EventArgs e)
        {
            this.lbl_TimeToday.Text = DateTime.Now.ToString();
        }

        private void lbl_WelcomeDescription_Click(object sender, EventArgs e)
        {

        }

        private void panel_ControlBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
