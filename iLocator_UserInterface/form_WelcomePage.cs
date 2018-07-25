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

namespace iLocator_UserInterface
{
    public partial class form_WelcomePage : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public form_WelcomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            if (lbl_iLocatorWelcomePage.Visible == false || lbl_WelcomeDescription.Visible == false || lbl_WelcomeDescription.Visible == false || tableLayoutPanel_SocialMedia.Visible == false)
            {
                bunifuFadeTransition.ShowSync(lbl_iLocatorWelcomePage);              
                bunifuFadeTransition.ShowSync(lbl_WelcomeDescription);
                bunifuFadeTransition.ShowSync(tableLayoutPanel_SocialMedia);
                bunifuFadeTransition.ShowSync(btn_Next);
            }
            else
            {
                bunifuFadeTransition.HideSync(lbl_iLocatorWelcomePage);
                bunifuFadeTransition.HideSync(lbl_WelcomeDescription);
                bunifuFadeTransition.HideSync(tableLayoutPanel_SocialMedia);
                bunifuFadeTransition.HideSync(btn_Next);
            }
     
        }


        private void panel_ContainerWelcome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            // Close Application
            System_Message _MessegeSystem = new System_Message();
            _MessegeSystem.ShowDialog();
          
           
        }

        private void panel_LogoTitle_Paint(object sender, PaintEventArgs e)
        {
            //System.Windows.Forms.Panel panel = sender as System.Windows.Forms.Panel;
            //System.Drawing.Rectangle rect = panel.ClientRectangle;
            //rect.Width--;
            //rect.Height--;
            //e.Graphics.DrawRectangle(Pens.DarkGray, rect);

    
        }

        private void btn_wpNext_Click(object sender, EventArgs e)
        {
            form_SelectUser _FormSelectUser = new form_SelectUser();
            this.Hide();
            _FormSelectUser.ShowDialog();
        }

        private void pb_FacebookIco_Click(object sender, EventArgs e)
        {
       
        }

        private void pb_FacebookIco_MouseHover(object sender, EventArgs e)
        {

        }

        private void pb_gPlusIco_Click(object sender, EventArgs e)
        {

        }

        private void pb_gPlusIco_MouseHover(object sender, EventArgs e)
        {

        }

        private void pb_TwitterIco_MouseHover(object sender, EventArgs e)
        {

        }

        private void pb_InfoIco_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            form_SelectUser _FormSelect = new form_SelectUser();
            this.Hide();
            _FormSelect.Show();
        }

        private void pb_InfoIco_Click(object sender, EventArgs e)
        {
            System_Info _SystemInfo = new System_Info();
            _SystemInfo.ShowDialog();
        }
    }
}
