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
    public partial class form_Main : Form
    {
        public form_Main()
        {
            InitializeComponent();
        }

        private void form_Main_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            HidePanels();
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
            // Close Application
            System_Message _MessegeSystem = new System_Message();
            _MessegeSystem.ShowDialog();


            // Uncomment me if you wan't simple Close Question
            //if (MessageBox.Show("Are you sure?", "System Messege", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //else
            //{
            //    return;
            //}
        }

        private void btn_UG_Click(object sender, EventArgs e)
        {
            HidePanels();
            LayoutPanel_UG.Visible = true;
            LayoutPanel_UG.Dock = DockStyle.Fill;
            LayoutPanel_UG.Visible = false;

            if (LayoutPanel_UG.Visible == false)    
            {
                bunifuTransitionLeaf.ShowSync(LayoutPanel_UG);
            }
            else
            {
                bunifuTransitionLeaf.HideSync(LayoutPanel_UG);
            }

            //if (btn_UG.selected == false)
            //{
            //    btn_UG.selected = true;
            //    btn_UG.Normalcolor = Color.Cyan;
            //}
            //else
            //{
            //    btn_UG.selected = false;
            //    btn_UG.Normalcolor = Color.FromArgb(66, 192, 251);
            //}
        }

        private void btn_2nd_Click(object sender, EventArgs e)
        {
            HidePanels();
            LayoutPanel_2nd.Visible = true;
            LayoutPanel_2nd.Dock = DockStyle.Fill;
            LayoutPanel_2nd.Visible = false;

            if (LayoutPanel_2nd.Visible == false)
            {
                bunifuTransitionLeaf.ShowSync(LayoutPanel_2nd);
            }
            else
            {
                bunifuTransitionLeaf.HideSync(LayoutPanel_2nd);
            }

        }

        private void btn_3rd_Click(object sender, EventArgs e)
        {
            HidePanels();
            LayoutPanel_3rd.Visible = true;
            LayoutPanel_3rd.Dock = DockStyle.Fill;
            LayoutPanel_3rd.Visible = false;

            if (LayoutPanel_3rd.Visible == false)
            {
                bunifuTransitionLeaf.ShowSync(LayoutPanel_3rd);
            }
            else
            {
                bunifuTransitionLeaf.HideSync(LayoutPanel_3rd);
            }

        }

        private void btn_4th_Click(object sender, EventArgs e)
        {
            HidePanels();
            LayoutPanel_4th.Visible = true;
            LayoutPanel_4th.Dock = DockStyle.Fill;
            LayoutPanel_4th.Visible = false;

            if (LayoutPanel_4th.Visible == false)
            {
                bunifuTransitionLeaf.ShowSync(LayoutPanel_4th);
            }
            else
            {
                bunifuTransitionLeaf.HideSync(LayoutPanel_4th);
            }
        }

        private void btn_5th_Click(object sender, EventArgs e)
        {
            HidePanels();
            LayoutPanel_5th.Visible = true;
            LayoutPanel_5th.Dock = DockStyle.Fill;
            LayoutPanel_5th.Visible = false;

            if (LayoutPanel_4th.Visible == false)
            {
                bunifuTransitionLeaf.ShowSync(LayoutPanel_5th);
            }
            else
            {
                bunifuTransitionLeaf.HideSync(LayoutPanel_5th);
            }
        }

        private void btn_6th_Click(object sender, EventArgs e)
        {
            HidePanels();
            LayoutPanel_6th.Visible = true;
            LayoutPanel_6th.Dock = DockStyle.Fill;
            LayoutPanel_6th.Visible = false;

            if (LayoutPanel_6th.Visible == false)
            {
                bunifuTransitionLeaf.ShowSync(LayoutPanel_6th);
            }
            else
            {
                bunifuTransitionLeaf.HideSync(LayoutPanel_6th);
            }
        }

        private void btn_7th_Click(object sender, EventArgs e)
        {
            HidePanels();
            LayoutPanel_7th.Visible = true;
            LayoutPanel_7th.Dock = DockStyle.Fill;
            LayoutPanel_7th.Visible = false;

            if (LayoutPanel_7th.Visible == false)
            {
                bunifuTransitionLeaf.ShowSync(LayoutPanel_7th);
            }
            else
            {
                bunifuTransitionLeaf.HideSync(LayoutPanel_7th);
            }
        }

        private void btn_8th_Click(object sender, EventArgs e)
        {
            HidePanels();
            LayoutPanel_8th.Visible = true;
            LayoutPanel_8th.Dock = DockStyle.Fill;
            LayoutPanel_8th.Visible = false;

            if (LayoutPanel_8th.Visible == false)
            {
                bunifuTransitionLeaf.ShowSync(LayoutPanel_8th);
            }
            else
            {
                bunifuTransitionLeaf.HideSync(LayoutPanel_8th);
            }
        }

        private void btn_9th_Click(object sender, EventArgs e)
        {
            HidePanels();
            LayoutPanel_9th.Visible = true;
            LayoutPanel_9th.Dock = DockStyle.Fill;
            LayoutPanel_9th.Visible = false;

            if (LayoutPanel_9th.Visible == false)
            {
                bunifuTransitionLeaf.ShowSync(LayoutPanel_9th);
            }
            else
            {
                bunifuTransitionLeaf.HideSync(LayoutPanel_9th);
            }
        }

        private void btn_10th_Click(object sender, EventArgs e)
        {
            HidePanels();
            LayoutPanel_10th.Visible = true;
            LayoutPanel_10th.Dock = DockStyle.Fill;
            LayoutPanel_10th.Visible = false;

            if (LayoutPanel_10th.Visible == false)
            {
                bunifuTransitionLeaf.ShowSync(LayoutPanel_10th);
            }
            else
            {
                bunifuTransitionLeaf.HideSync(LayoutPanel_10th);
            }
        }

    }
}
