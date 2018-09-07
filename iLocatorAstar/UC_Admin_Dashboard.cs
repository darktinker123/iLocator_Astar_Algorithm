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

        private void UC_Admin_Dashboard_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"..\..\Virtual Maps\1st-rev-here.jpg");
            pb_VirtualMap.Image = img;
            cmb_floorSelection.SelectedIndex = 0;
        }

        private void cmb_floorSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image img = null;
            switch (cmb_floorSelection.Text)
            {
                case "UG":
                    img = Image.FromFile(@"..\..\Virtual Maps\1st-rev-here.jpg");
                    break;
                case "3rd":
                    img = Image.FromFile(@"..\..\Virtual Maps\3rd-rev-here.jpg");
                    break;
                case "5th":
                    img = Image.FromFile(@"..\..\Virtual Maps\5th-rev.jpg");
                    break;
                case "7th":
                    img = Image.FromFile(@"..\..\Virtual Maps\7th-rev-here.jpg");
                    break;
                default:
                    img = Image.FromFile(@"..\..\Virtual Maps\9th-rev.jpg");
                    break;
            }

            pb_VirtualMap.Image = img;
        }

    }
}
