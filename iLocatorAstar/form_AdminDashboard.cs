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
using System.Diagnostics;

namespace iLocatorAstar
{
    public partial class form_AdminDashboard : Form
    {
        public form_AdminDashboard()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            System_Message MsgForm = new System_Message();
            MsgForm.ShowDialog();
        }

        private void form_AdminDashboard_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
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

        private void btn_UG_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"..\..\Virtual Maps\1st-rev.jpg");
            pb_VirtualMap.Image = img;
            pb_VirtualMap.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_2nd_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"..\..\Virtual Maps\2nd-rev.jpg");
            pb_VirtualMap.Image = img;
            pb_VirtualMap.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_3rd_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"..\..\Virtual Maps\3rd-rev.jpg");
            pb_VirtualMap.Image = img;
            pb_VirtualMap.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_4th_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"..\..\Virtual Maps\4th-rev.jpg");
            pb_VirtualMap.Image = img;
            pb_VirtualMap.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_5th_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"..\..\Virtual Maps\5th-rev.jpg");
            pb_VirtualMap.Image = img;
            pb_VirtualMap.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_6th_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"..\..\Virtual Maps\6th-rev.jpg");
            pb_VirtualMap.Image = img;
            pb_VirtualMap.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_7th_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"..\..\Virtual Maps\7th-rev.jpg");
            pb_VirtualMap.Image = img;
            pb_VirtualMap.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_8th_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"..\..\Virtual Maps\8th-rev.jpg");
            pb_VirtualMap.Image = img;
            pb_VirtualMap.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_9th_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"..\..\Virtual Maps\9th-rev.jpg");
            pb_VirtualMap.Image = img;
            pb_VirtualMap.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_10th_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"..\..\Virtual Maps\10th-rev.jpg");
            pb_VirtualMap.Image = img;
            pb_VirtualMap.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_SideNav_Logout_Click(object sender, EventArgs e)
        {
            form_WelcomePage WelcomePageForm = new form_WelcomePage();
            WelcomePageForm.Show();
            this.Hide();
        }
        public string fname;
        private void btn_OpenNodes_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                richTxtBox_Nodes.Text = File.ReadAllText(op.FileName);
            }
            fname = op.FileName;
        }

        private void btn_SaveNodes_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(fname, richTxtBox_Nodes.Lines);
            
        }

        private void btn_SideNav_SystemFloor_Click(object sender, EventArgs e)
        {
            Process.Start(@"..\..\Setup\Config.ini");
        }

        private void btn_Change_CurrentFlr_Click(object sender, EventArgs e)
        {
            Form_ChangeSystemFloor frm_ChangeSystemFloor = new Form_ChangeSystemFloor();
            frm_ChangeSystemFloor.ShowDialog();
        }

        int startingNode;

        private void btn_setStartingFloor_Click(object sender, EventArgs e)
        {
            switch (cmb_floorSelection.Text)
            {
                case "UG":
                    startingNode = 1;
                    break;
                case "3rd Floor":
                    startingNode = 42;
                    break;
                case "5th Floor":
                    startingNode = 106;
                    break;
                case "7th Floor":
                    startingNode = 145;
                    break;
                case "9th Floor":
                    startingNode = 207;
                    break;
                default:
                    startingNode = 0;
                    break;
            }
            changeStartingFloor(startingNode);
        }

        public void changeStartingFloor(int newStartingNode)
        {
            string[] configInput = File.ReadAllLines(Environment.CurrentDirectory.ToString() + @"\config\config.txt");

            for (int x = 0; x < configInput.Length; x++)
            {
                if (configInput[x] == "[Starting Point]")
                {
                    x++;

                    string[] values = configInput[x].Split('=');

                    if (values[0] == "startingNode")
                    {

                        values[1] = "" + newStartingNode;

                        string newText = values[0] + "=" + values[1];

                        configInput[x] = configInput[x].Replace(configInput[x], newText);

                        File.WriteAllLines(Environment.CurrentDirectory.ToString() + @"\config\config.txt", configInput);

                        MessageBox.Show("Starting floor successfully changed!");
                    }
                }
            }
        }
    }
}
