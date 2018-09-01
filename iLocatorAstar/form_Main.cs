using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.IO;

namespace iLocatorAstar
{
    public partial class form_Main : Form
    {
        public form_Main()
        {
            InitializeComponent();
        }

        private void form_MainTest_Load(object sender, EventArgs e)
        {
            // Hide all Directories in Select Destition
            HidePanels();

            // Maximized Windows when Open
            WindowState = FormWindowState.Maximized;

            // Make sure Select User Form is hidden
            Form fc = Application.OpenForms["form_SelectUser"];
            if (fc != null)
            {
                fc.Hide();
            }

            if (tableLayoutPanel_FloorButtons.Visible == false)
            {
                bunifuTransFloorButtons.ShowSync(tableLayoutPanel_FloorButtons);
            }
            if (lbl_SelectFloor.Visible == false || lbl_SelectDestination.Visible == false || lbl_VirtualMap.Visible == false || lbl_ShortestPath.Visible == false || lbl_EstimatedTime.Visible == false || lbl_EstimatedDistance.Visible == false)
            {
                bunifuTransLabels.ShowSync(lbl_SelectFloor);
                bunifuTransLabels.ShowSync(lbl_SelectDestination);
                bunifuTransLabels.ShowSync(lbl_VirtualMap);
                bunifuTransLabels.ShowSync(lbl_ShortestPath);
                bunifuTransLabels.ShowSync(lbl_EstimatedTime);
                bunifuTransLabels.ShowSync(lbl_EstimatedDistance);
            }

            var text = File.ReadLines(Environment.CurrentDirectory.ToString() + @"..\..\..\setup\config.ini");
            string SystemFloor = "";
            foreach (var item in text)
            {
                SystemFloor = item.ToString();
            }

            if (SystemFloor.ToString() == "UG")
            {
                SelectedButton(this, e);

            }

        }

        private void SelectedButton(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color

            BunifuFlatButton selectedbtn=new BunifuFlatButton();

            foreach (Control c in tableLayoutPanel_FloorButtons.Controls)
            {
                BunifuFlatButton btn = c as BunifuFlatButton;
                if (c is BunifuFlatButton)
                {
                    btn.Normalcolor = Color.RoyalBlue;
                }
                selectedbtn = c as BunifuFlatButton;
            }
            
            // Show Virtual Map
            bunifuTransMaps.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                Image img = Image.FromFile(@"..\..\Virtual Maps\1st-rev.jpg");
                pb_VirtualMap.Image = img;
                pb_VirtualMap.SizeMode = PictureBoxSizeMode.StretchImage;
                bunifuTransMaps.ShowSync(pb_VirtualMap);
            }

            // Hide List of Directories in Select Destination
            HidePanels();

            switch(selectedbtn.Name)
            {
                case "btn_UG":
                    FormTransition(LayoutPanel_UG);
                    break;
                case "btn_2nd":
                    FormTransition(LayoutPanel_2nd);
                    break;
                case "btn_3rd":
                    FormTransition(LayoutPanel_3rd);
                    break;
                case "btn_4th":
                    FormTransition(LayoutPanel_4th);
                    break;
                case "btn_5th":
                    FormTransition(LayoutPanel_5th);
                    break;
                case "btn_6th":
                    FormTransition(LayoutPanel_6th);
                    break;
                case "btn_7th":
                    FormTransition(LayoutPanel_7th);
                    break;
                case "btn_8th":
                    FormTransition(LayoutPanel_8th);
                    break;
                case "btn_9th":
                    FormTransition(LayoutPanel_9th);
                    break;
                default:
                    FormTransition(LayoutPanel_10th);
                    break;
            }
        }

        private void FormTransition(TableLayoutPanel floor)
        {
            floor.Visible = true;
            floor.Dock = DockStyle.Fill;
            floor.Visible = false;

            if (floor.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(floor);
                bunifuTransLabels.ShowSync(pb_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(floor);
            }
        }
        
        public void HidePanels()
        {
            //Hide all Panel in Select Destinatoin
            LayoutPanel_UG.Visible = false;
            LayoutPanel_2nd.Visible = false;
            LayoutPanel_3rd.Visible = false;
            LayoutPanel_4th.Visible = false;
            LayoutPanel_5th.Visible = false;
            LayoutPanel_6th.Visible = false;
            LayoutPanel_7th.Visible = false;
            LayoutPanel_8th.Visible = false;
            LayoutPanel_9th.Visible = false;
            LayoutPanel_10th.Visible = false;
        }



        private void btn_Close_Click(object sender, EventArgs e)
        {
            System_Message _MessegeSystem = new System_Message();
            _MessegeSystem.ShowDialog();
        }

        private void LayoutPanel_UG_MouseEnter(object sender, EventArgs e)
        {
            foreach (Control c in LayoutPanel_UG.Controls)
            {
                LinkLabel lnkLabel = c as LinkLabel;

                if (c is LinkLabel)
                {
                    lnkLabel.LinkColor = Color.Pink;
                }
            }
        }

        private void panel_ContainerFloorSelector_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel_ContainerFloorSelector.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel_UniverseSelectDestination_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel_UniverseSelectDestination.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel_TitleVirtualMap_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel_TitleVirtualMap.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel_DetailsSelectedDestination_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel_DetailsSelectedDestination.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel_TitleSelectFloor_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel_TitleSelectFloor.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel_TitleSelectDestination_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel_TitleSelectDestination.ClientRectangle,
            Color.LightGray, 0, ButtonBorderStyle.Solid,
            Color.LightGray, 0, ButtonBorderStyle.Solid,
            Color.LightGray, 0, ButtonBorderStyle.Solid,
            Color.LightGray, 1, ButtonBorderStyle.Solid);
        }

        private void panel_UniverseVirtualMap_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel_UniverseVirtualMap.ClientRectangle,
            Color.LightGray, 1, ButtonBorderStyle.Solid,
            Color.LightGray, 0, ButtonBorderStyle.Solid,
            Color.LightGray, 0, ButtonBorderStyle.Solid,
            Color.LightGray, 0, ButtonBorderStyle.Solid);
        }

        private void pb_BackToHome_Click(object sender, EventArgs e)
        {
            form_WelcomePage _FormWelcomePage = new form_WelcomePage();
            _FormWelcomePage.Show();
            this.Hide();
        }

        private void pb_VirtualMap_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pb_VirtualMap.ClientRectangle,
            Color.LightGray, 1, ButtonBorderStyle.Solid,
            Color.LightGray, 0, ButtonBorderStyle.Solid,
            Color.LightGray, 0, ButtonBorderStyle.Solid,
            Color.LightGray, 0, ButtonBorderStyle.Solid);
        }
    }
}
