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
    public partial class TestZone : Form
    {
        public TestZone()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            BunifuFlatButton selectedBtn = sender as BunifuFlatButton;

            foreach (Control c in this.Controls)
            {
                BunifuFlatButton BtnSelected = c as BunifuFlatButton;

                if (c is BunifuFlatButton)
                {

                    BtnSelected.Normalcolor = Color.FromArgb(66, 192, 251);
                }

                selectedBtn.Normalcolor = Color.Cyan;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            BunifuFlatButton selectedBtn = sender as BunifuFlatButton;

            foreach (Control c in this.Controls)
            {
                BunifuFlatButton BtnSelected = c as BunifuFlatButton;

                if (c is BunifuFlatButton)
                {
                    BtnSelected.Normalcolor = Color.FromArgb(66, 192, 251);
                }
                selectedBtn.Normalcolor = Color.Cyan;

            }

            //BunifuFlatButton btnSelected = sender as BunifuFlatButton;
            //foreach (BunifuFlatButton selectedBtn in this.Controls.OfType<BunifuFlatButton>())
            //{
            //    if (btnSelected is BunifuFlatButton)
            //    {
            //        selectedBtn.Normalcolor = Color.FromArgb(66, 192, 251);
            //    }
            //    selectedBtn.Normalcolor = Color.Cyan;
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btnSelected = sender as Button;
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.FromArgb(66, 192, 251);
                }
                btnSelected.BackColor = Color.Cyan;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btnSelected = sender as Button;
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.FromArgb(66, 192, 251);
                }
                btnSelected.BackColor = Color.Cyan;
            }
        }
        private void TestZone_Load(object sender, EventArgs e)
        {
            //button1.Tag = "T";
            //button2.Tag = "T";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                Image img = Image.FromFile(@"..\..\Virtual Maps\1st-rev.jpg");
                pb_VirtualMap.Image = img;
                pb_VirtualMap.SizeMode = PictureBoxSizeMode.Zoom;

                bunifuTransition1.ShowSync(pb_VirtualMap);

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                Image img = Image.FromFile(@"..\..\Virtual Maps\2nd-rev.jpg");
                pb_VirtualMap.Image = img;
                pb_VirtualMap.SizeMode = PictureBoxSizeMode.Zoom;

                bunifuTransition1.ShowSync(pb_VirtualMap);
            }
        }
    }
}
