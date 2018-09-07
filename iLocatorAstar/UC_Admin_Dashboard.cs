using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace iLocatorAstar
{
    public partial class UC_Admin_Dashboard : UserControl
    {
        public UC_Admin_Dashboard()
        {
            InitializeComponent();
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


        int startingNode;

        private void btn_setStartingFloor_Click(object sender, EventArgs e)
        {
            switch (cmb_floorSelection.Text)
            {
                case "UG":
                    startingNode = 1;
                    break;
                case "3rd":
                    startingNode = 42;
                    break;
                case "5th":
                    startingNode = 106;
                    break;
                case "7th":
                    startingNode = 145;
                    break;
                case "9th":
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
