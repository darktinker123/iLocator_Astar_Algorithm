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
        
        // Make some element round edges
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public form_WelcomePage()
        {
            InitializeComponent();
        }

        //FORM LOAD
        private void form_WelcomePage_Load(object sender, EventArgs e)
        {
            //DEFAULT LOCATION FROM CONFIG FILE
            var text = File.ReadLines(Environment.CurrentDirectory.ToString() + @"..\..\..\setup\config.ini");
            string result = "";
            string vertex = "";
            foreach (var item in text)
            {
                result = item.ToString();
                vertex = item.ToString();

            }

            lbl_VarSysCurrentFloor.Text = result.ToString();

            //MAKE FORM FULLSCREEN
            WindowState = FormWindowState.Maximized;

            //TRANSITION OF ACT LOGO
            if (pb_ACTIco.Visible == false)
            {
                bunifuACTTransition.ShowSync(pb_ACTIco);
            }
            else
            {
                bunifuACTTransition.HideSync(pb_ACTIco);
            }

            //OTHER TRANSITIONS
            if (lbl_iLocatorWelcomePage.Visible == false || lbl_WelcomeDescription.Visible == false || lbl_WelcomeDescription.Visible == false || tableLayoutPanel_SocialMedia.Visible == false || lbl_TimeToday.Visible == false)
            {
                bunifuFadeTransition.ShowSync(lbl_iLocatorWelcomePage);
                bunifuFadeTransition.ShowSync(lbl_WelcomeDescription);
                bunifuFadeTransition.ShowSync(tableLayoutPanel_SocialMedia);
                bunifuFadeTransition.ShowSync(btn_Next);
                bunifuFadeTransition.ShowSync(lbl_TimeToday);
            }

        }
        
        //EVENT FOR NEXT BUTTON
        private void btn_Next_Click(object sender, EventArgs e)
        {
            form_SelectUser user = new form_SelectUser();
            user.Show();
            this.Hide();
        }

        //EVENT FOR CLICKING OF ICONS
        private void pbMouseClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            switch (pb.Name)
            {
                case "pb_FacebookIco":
                    System.Diagnostics.Process.Start("http://www.facebook.com");
                    break;
                case "pb_TwitterIco":
                    break;
                case "pb_gPlusIco":
                    System.Diagnostics.Process.Start("http://www.plus.google.com");
                    break;
                case"pb_InfoIco":
                    System_Info info = new System_Info();
                    info.ShowDialog();
                    break;
                default:
                    System_Message message = new System_Message();
                    message.ShowDialog();
                    break;
            }
        }

        //DATE AND TIME
        private void timerTick(object sender, EventArgs e)
        {
            this.lbl_TimeToday.Text = DateTime.Now.ToString();
        }

        private void panel_LogoTitle_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel_LogoTitle.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            System_Message msgForm = new System_Message();
            msgForm.ShowDialog();
        }
    }
}

