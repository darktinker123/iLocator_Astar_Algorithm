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

        //Global Current Floor Variable
        public string currentFloor;

        public form_WelcomePage()
        {
            InitializeComponent();
        }

        //FORM LOAD
        private void form_WelcomePage_Load(object sender, EventArgs e)
        {
            //DEFAULT LOCATION FROM CONFIG FILE
            /*            string[] configInput = File.ReadAllLines(Environment.CurrentDirectory.ToString() + @"\config\config.txt");
                        for (int x = 0; x < configInput.Length; x++)
                        {
                            if (configInput[x] == "[Starting Point]")
                            {
                                x++;

                                string[] values = configInput[x].Split('=');

                                switch (values[1])
                                {
                                    case 
                                    default:
                                        break;
                                }

                            }
                        }*/

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

            Dictionary<int, string> startingFloors = new Dictionary<int, string>();

            startingFloors.Add(1, "UG");
            startingFloors.Add(42, "3rd Floor");
            startingFloors.Add(106, "5th Floor");
            startingFloors.Add(145, "7th Floor");
            startingFloors.Add(207, "9th Floor");

            string[] configInput = File.ReadAllLines(Environment.CurrentDirectory.ToString() + @"\config\config.txt");

            for (int x = 0; x < configInput.Length; x++)
            {
                if (configInput[x] == "[Starting Point]")
                {
                    x++;

                    string[] values = configInput[x].Split('=');

                    int temp;

                    if (int.TryParse(values[1], out temp))
                    {
                        currentFloor = startingFloors.FirstOrDefault(y => y.Key == int.Parse(values[1])).Value;

                        lbl_VarSysCurrentFloor.Text = currentFloor;
                    }
                    else
                    {
                        MessageBox.Show("Starting Point invalid! Please check the system's configuration file.");
                    }
                }
            }
        }
        
        //EVENT FOR NEXT BUTTON
        private void btn_Next_Click(object sender, EventArgs e)
        {
            
            form_SelectUser SelectUserForm = new form_SelectUser();
            SelectUserForm.currentFloor = currentFloor;
            SelectUserForm.Show();
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            System_Message msgForm = new System_Message();
            msgForm.ShowDialog();
        }

        private void pb_Settings_Click(object sender, EventArgs e)
        {
            form_Login loginForm = new form_Login();
            loginForm.ShowDialog();
            this.Hide();

            if (true)
            {

            }
        }
    }
}

