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
            foreach (Control x in this.Controls)
            {
                if (x is LinkLabel)
                {
                    ((LinkLabel)x).LinkColor = Color.Pink;
                }
            }

            // Hide all Directories in Select Destition
            HidePanels();

            // Maximized Windows when Open
            WindowState = FormWindowState.Maximized;

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

        }
        private void btn_UG_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            BunifuFlatButton selectedBtn = sender as BunifuFlatButton;

            foreach (Control c in tableLayoutPanel_FloorButtons.Controls)
            {
                BunifuFlatButton BtnSelected = c as BunifuFlatButton;

                if (c is BunifuFlatButton)
                {
                    BtnSelected.Normalcolor = Color.FromArgb(66, 192, 251);
                }
                selectedBtn.Normalcolor = Color.Cyan;
            }

            // Hide List of Directories in Select Destination
            HidePanels();

            // Make the Selected Layout Visible then Fill it in panel. Then hide it for Transition purposes.
            LayoutPanel_UG.Visible = true;
            LayoutPanel_UG.Dock = DockStyle.Fill;
            LayoutPanel_UG.Visible = false;

            // Transition Code
            if (LayoutPanel_UG.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(LayoutPanel_UG);
                bunifuTransLabels.ShowSync(pb_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(LayoutPanel_UG);
            }
        }

        private void btn_2nd_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            BunifuFlatButton selectedBtn = sender as BunifuFlatButton;

            foreach (Control c in tableLayoutPanel_FloorButtons.Controls)
            {
                BunifuFlatButton BtnSelected = c as BunifuFlatButton;

                if (c is BunifuFlatButton)
                {
                    BtnSelected.Normalcolor = Color.FromArgb(66, 192, 251);
                }
                selectedBtn.Normalcolor = Color.Cyan;
            }

            HidePanels();
            LayoutPanel_2nd.Visible = true;
            LayoutPanel_2nd.Dock = DockStyle.Fill;
            LayoutPanel_2nd.Visible = false;

            if (LayoutPanel_2nd.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(LayoutPanel_2nd);
                bunifuTransLabels.ShowSync(pb_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(LayoutPanel_2nd);
            }

        }

        private void btn_3rd_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            BunifuFlatButton selectedBtn = sender as BunifuFlatButton;

            foreach (Control c in tableLayoutPanel_FloorButtons.Controls)
            {
                BunifuFlatButton BtnSelected = c as BunifuFlatButton;

                if (c is BunifuFlatButton)
                {
                    BtnSelected.Normalcolor = Color.FromArgb(66, 192, 251);
                }
                selectedBtn.Normalcolor = Color.Cyan;
            }
            HidePanels();
            LayoutPanel_3rd.Visible = true;
            LayoutPanel_3rd.Dock = DockStyle.Fill;
            LayoutPanel_3rd.Visible = false;

            if (LayoutPanel_3rd.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(LayoutPanel_3rd);
                bunifuTransLabels.ShowSync(pb_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(LayoutPanel_3rd);
            }
        }

        private void btn_4th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            BunifuFlatButton selectedBtn = sender as BunifuFlatButton;

            foreach (Control c in tableLayoutPanel_FloorButtons.Controls)
            {
                BunifuFlatButton BtnSelected = c as BunifuFlatButton;

                if (c is BunifuFlatButton)
                {
                    BtnSelected.Normalcolor = Color.FromArgb(66, 192, 251);
                }
                selectedBtn.Normalcolor = Color.Cyan;
            }
            HidePanels();
            LayoutPanel_4th.Visible = true;
            LayoutPanel_4th.Dock = DockStyle.Fill;
            LayoutPanel_4th.Visible = false;

            if (LayoutPanel_4th.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(LayoutPanel_4th);
                bunifuTransLabels.ShowSync(pb_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(LayoutPanel_4th);
            }
        }

        private void btn_5th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            BunifuFlatButton selectedBtn = sender as BunifuFlatButton;

            foreach (Control c in tableLayoutPanel_FloorButtons.Controls)
            {
                BunifuFlatButton BtnSelected = c as BunifuFlatButton;

                if (c is BunifuFlatButton)
                {
                    BtnSelected.Normalcolor = Color.FromArgb(66, 192, 251);
                }
                selectedBtn.Normalcolor = Color.Cyan;
            }
            HidePanels();
            LayoutPanel_5th.Visible = true;
            LayoutPanel_5th.Dock = DockStyle.Fill;
            LayoutPanel_5th.Visible = false;

            if (LayoutPanel_4th.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(LayoutPanel_5th);
                bunifuTransLabels.ShowSync(pb_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(LayoutPanel_5th);
            }
        }

        private void btn_6th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            BunifuFlatButton selectedBtn = sender as BunifuFlatButton;

            foreach (Control c in tableLayoutPanel_FloorButtons.Controls)
            {
                BunifuFlatButton BtnSelected = c as BunifuFlatButton;

                if (c is BunifuFlatButton)
                {
                    BtnSelected.Normalcolor = Color.FromArgb(66, 192, 251);
                }
                selectedBtn.Normalcolor = Color.Cyan;
            }
            HidePanels();
            LayoutPanel_6th.Visible = true;
            LayoutPanel_6th.Dock = DockStyle.Fill;
            LayoutPanel_6th.Visible = false;

            if (LayoutPanel_6th.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(LayoutPanel_6th);
                bunifuTransLabels.ShowSync(pb_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(LayoutPanel_6th);
            }
        }

        private void btn_7th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            BunifuFlatButton selectedBtn = sender as BunifuFlatButton;

            foreach (Control c in tableLayoutPanel_FloorButtons.Controls)
            {
                BunifuFlatButton BtnSelected = c as BunifuFlatButton;

                if (c is BunifuFlatButton)
                {
                    BtnSelected.Normalcolor = Color.FromArgb(66, 192, 251);
                }
                selectedBtn.Normalcolor = Color.Cyan;
            }
            HidePanels();
            LayoutPanel_7th.Visible = true;
            LayoutPanel_7th.Dock = DockStyle.Fill;
            LayoutPanel_7th.Visible = false;

            if (LayoutPanel_7th.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(LayoutPanel_7th);
                bunifuTransLabels.ShowSync(pb_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(LayoutPanel_7th);
            }
        }

        private void btn_8th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            BunifuFlatButton selectedBtn = sender as BunifuFlatButton;

            foreach (Control c in tableLayoutPanel_FloorButtons.Controls)
            {
                BunifuFlatButton BtnSelected = c as BunifuFlatButton;

                if (c is BunifuFlatButton)
                {
                    BtnSelected.Normalcolor = Color.FromArgb(66, 192, 251);
                }
                selectedBtn.Normalcolor = Color.Cyan;
            }
            HidePanels();
            LayoutPanel_8th.Visible = true;
            LayoutPanel_8th.Dock = DockStyle.Fill;
            LayoutPanel_8th.Visible = false;

            if (LayoutPanel_8th.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(LayoutPanel_8th);
                bunifuTransLabels.ShowSync(pb_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(LayoutPanel_8th);
            }
        }

        private void btn_9th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            BunifuFlatButton selectedBtn = sender as BunifuFlatButton;

            foreach (Control c in tableLayoutPanel_FloorButtons.Controls)
            {
                BunifuFlatButton BtnSelected = c as BunifuFlatButton;

                if (c is BunifuFlatButton)
                {
                    BtnSelected.Normalcolor = Color.FromArgb(66, 192, 251);
                }
                selectedBtn.Normalcolor = Color.Cyan;
            }
            HidePanels();
            LayoutPanel_9th.Visible = true;
            LayoutPanel_9th.Dock = DockStyle.Fill;
            LayoutPanel_9th.Visible = false;

            if (LayoutPanel_9th.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(LayoutPanel_9th);
                bunifuTransLabels.ShowSync(pb_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(LayoutPanel_9th);
            }
        }

        private void btn_10th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            BunifuFlatButton selectedBtn = sender as BunifuFlatButton;

            foreach (Control c in tableLayoutPanel_FloorButtons.Controls)
            {
                BunifuFlatButton BtnSelected = c as BunifuFlatButton;

                if (c is BunifuFlatButton)
                {
                    BtnSelected.Normalcolor = Color.FromArgb(66, 192, 251);
                }
                selectedBtn.Normalcolor = Color.Cyan;
            }
            HidePanels();
            LayoutPanel_10th.Visible = true;
            LayoutPanel_10th.Dock = DockStyle.Fill;
            LayoutPanel_10th.Visible = false;

            if (LayoutPanel_10th.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(LayoutPanel_10th);
                bunifuTransLabels.ShowSync(pb_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(LayoutPanel_10th);
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
            //foreach (Control c in LayoutPanel_UG.Controls)
            //{
            //    LinkLabel lnkLabel = c as LinkLabel;

            //    if (c is LinkLabel)
            //    {
            //        lnkLabel.LinkColor = Color.Pink;
            //    }
            //}
        }

        private void TableLayoutPanel_Map_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
