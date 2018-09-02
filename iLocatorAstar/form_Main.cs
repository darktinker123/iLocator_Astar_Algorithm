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
using System.Threading;

namespace iLocatorAstar
{
    public partial class form_Main : Form
    {
        public form_Main()
        {
            InitializeComponent();
        }

        string SystemFloor = "";

        ////////////////// SYSTEM UI CODES /////////////////////////////
        //////////////////// START HERE ////////////////////////////////
        ////////////////////////////////////////////////////////////////
        private void form_MainTest_Load(object sender, EventArgs e)
        {
            loadNodes();

            // Hide all Directories in Select Destition
            HidePanels();

            // Maximized Windows when Open
            WindowState = FormWindowState.Maximized;

            // Make sure Select User Form is Hide
            Form fc = Application.OpenForms["form_SelectUser"];
            if (fc != null)
            {
                fc.Hide();
            }

            // Transition System
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
            SelectedFloor();
        }

        public void SelectedFloor()
        {
            var text = File.ReadLines(Environment.CurrentDirectory.ToString() + @"..\..\..\setup\config.ini");

            foreach (var item in text)
            {
                SystemFloor = item.ToString();
            }

            switch (SystemFloor.ToString())
            {
                case "UG":
                    this.btn_UG_Click(btn_UG, EventArgs.Empty);
                    break;
                case "2nd":
                    this.btn_2nd_Click(btn_2nd, EventArgs.Empty);
                    break;
                case "3rd":
                    this.btn_3rd_Click(btn_3rd, EventArgs.Empty);
                    break;
                case "4th":
                    this.btn_4th_Click(btn_4th, EventArgs.Empty);
                    break;
                case "5th":
                    this.btn_5th_Click(btn_5th, EventArgs.Empty);
                    break;
                case "6th":
                    this.btn_6th_Click(btn_6th, EventArgs.Empty);
                    break;
                case "7th":
                    this.btn_7th_Click(btn_7th, EventArgs.Empty);
                    break;
                case "8th":
                    this.btn_8th_Click(btn_8th, EventArgs.Empty);
                    break;
                case "9th":
                    this.btn_9th_Click(btn_9th, EventArgs.Empty);
                    break;
                case "10th":
                    this.btn_10th_Click(btn_10th, EventArgs.Empty);
                    break;
            }
        }
        private void ButtonSeleted(object sender)
        {
            BunifuFlatButton selectedBtn = sender as BunifuFlatButton;

            foreach (Control c in tableLayoutPanel_FloorButtons.Controls)
            {
                BunifuFlatButton BtnSelected = c as BunifuFlatButton;

                if (c is BunifuFlatButton)
                {
                    BtnSelected.Normalcolor = Color.RoyalBlue;
                }
                selectedBtn.Normalcolor = Color.Blue;
                selectedBtn.Font = new Font(selectedBtn.Font.Name, selectedBtn.Font.Size, FontStyle.Bold);
            }
        }
        private void btn_UG_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSeleted(sender);

            // Show Virtual Map
            bunifuTransMaps.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                if (SystemFloor.ToString() == "UG")
                {
                       Image img = Image.FromFile(@"..\..\Virtual Maps\1st-rev-here.jpg");
                    pb_VirtualMap.Image = img;
                }
                else
                {
                    Image img = Image.FromFile(@"..\..\Virtual Maps\1st-rev.jpg");
                    pb_VirtualMap.Image = img;
                }
                pb_VirtualMap.SizeMode = PictureBoxSizeMode.StretchImage;
                bunifuTransMaps.ShowSync(pb_VirtualMap);
            }

            // Hide List of Directories in Select Destination
            HidePanels();

            // Make the Selected Layout Visible then Fill it in panel. Then hide it for Transition purposes.
            grpBox_UG.Visible = true;
            grpBox_UG.Dock = DockStyle.Fill;
            grpBox_UG.Visible = false;

            // Transition Code
            if (grpBox_UG.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(grpBox_UG);
                bunifuTransLabels.ShowSync(btn_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(grpBox_UG);
            }
        }

        private void btn_2nd_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSeleted(sender);

            // Show Virtual Maps
            bunifuTransMaps.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                Image img = Image.FromFile(@"..\..\Virtual Maps\2nd-rev.jpg");
                pb_VirtualMap.Image = img;
                pb_VirtualMap.SizeMode = PictureBoxSizeMode.Zoom;
                bunifuTransMaps.ShowSync(pb_VirtualMap);

            }
            HidePanels();
            grpBox_2ndFloor.Visible = true;
            grpBox_2ndFloor.Dock = DockStyle.Fill;
            grpBox_2ndFloor.Visible = false;
            if (grpBox_2ndFloor.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(grpBox_2ndFloor);
                bunifuTransLabels.ShowSync(btn_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(grpBox_2ndFloor);
            }
        }

        private void btn_3rd_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSeleted(sender);

            // Show Virtual Maps
            bunifuTransMaps.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                if (SystemFloor.ToString() == "3rd")
                {
                    Image img = Image.FromFile(@"..\..\Virtual Maps\3rd-rev-here.jpg");
                    pb_VirtualMap.Image = img;
                }
                else
                {
                    Image img = Image.FromFile(@"..\..\Virtual Maps\3rd-rev.jpg");
                    pb_VirtualMap.Image = img;
                }
                pb_VirtualMap.SizeMode = PictureBoxSizeMode.Zoom;
                bunifuTransMaps.ShowSync(pb_VirtualMap);
            }
            HidePanels();
            grpBox_3rdFloor.Visible = true;
            grpBox_3rdFloor.Dock = DockStyle.Fill;
            grpBox_3rdFloor.Visible = false;

            if (grpBox_3rdFloor.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(grpBox_3rdFloor);
                bunifuTransLabels.ShowSync(btn_BackToHome); 
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(grpBox_3rdFloor);
            }
        }

        private void btn_4th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSeleted(sender);

            // Show Virtual Maps
            bunifuTransMaps.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                Image img = Image.FromFile(@"..\..\Virtual Maps\4th-rev.jpg");
                pb_VirtualMap.Image = img;
                pb_VirtualMap.SizeMode = PictureBoxSizeMode.Zoom;
                bunifuTransMaps.ShowSync(pb_VirtualMap);
            }

            HidePanels();
            grpBox_5thFloor.Visible = true;
            grpBox_5thFloor.Dock = DockStyle.Fill;
            grpBox_5thFloor.Visible = false;

            if (grpBox_5thFloor.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(grpBox_5thFloor);
                bunifuTransLabels.ShowSync(btn_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(grpBox_5thFloor);
            }
        }

        private void btn_5th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSeleted(sender);

            // Show Virtual Maps
            bunifuTransMaps.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                Image img = Image.FromFile(@"..\..\Virtual Maps\5th-rev.jpg");
                pb_VirtualMap.Image = img;
                pb_VirtualMap.SizeMode = PictureBoxSizeMode.Zoom;
                bunifuTransMaps.ShowSync(pb_VirtualMap);
            }

            HidePanels();
            grpBox_5thFloor.Visible = true;
            grpBox_5thFloor.Dock = DockStyle.Fill;
            grpBox_5thFloor.Visible = false;

            if (grpBox_5thFloor.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(grpBox_5thFloor);
                bunifuTransLabels.ShowSync(btn_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(grpBox_5thFloor);
            }
        }

        private void btn_6th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSeleted(sender);

            // Show Virtual Maps
            bunifuTransMaps.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                Image img = Image.FromFile(@"..\..\Virtual Maps\6th-rev.jpg");
                pb_VirtualMap.Image = img;
                pb_VirtualMap.SizeMode = PictureBoxSizeMode.Zoom;

                bunifuTransMaps.ShowSync(pb_VirtualMap);

            }
            HidePanels();
            grpBox_7thFloor.Visible = true;
            grpBox_7thFloor.Dock = DockStyle.Fill;
            grpBox_7thFloor.Visible = false;

            if (grpBox_7thFloor.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(grpBox_7thFloor);
                bunifuTransLabels.ShowSync(btn_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(grpBox_7thFloor);
            }
        }

        private void btn_7th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSeleted(sender);

            // Show Virtual Maps
            bunifuTransMaps.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                if (SystemFloor.ToString() == "7th")
                {
                    Image img = Image.FromFile(@"..\..\Virtual Maps\7th-rev-here.jpg");
                    pb_VirtualMap.Image = img;
                }
                else
                {
                    Image img = Image.FromFile(@"..\..\Virtual Maps\7th-rev.jpg");
                    pb_VirtualMap.Image = img;
                }
                pb_VirtualMap.SizeMode = PictureBoxSizeMode.Zoom;

                bunifuTransMaps.ShowSync(pb_VirtualMap);
            }

            HidePanels();
            grpBox_7thFloor.Visible = true;
            grpBox_7thFloor.Dock = DockStyle.Fill;
            grpBox_7thFloor.Visible = false;

            if (grpBox_7thFloor.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(grpBox_7thFloor);
                bunifuTransLabels.ShowSync(btn_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(grpBox_7thFloor);
            }
        }

        private void btn_8th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSeleted(sender);

            // Show Virtual Maps
            bunifuTransMaps.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                Image img = Image.FromFile(@"..\..\Virtual Maps\8th-rev.jpg");
                pb_VirtualMap.Image = img;
                pb_VirtualMap.SizeMode = PictureBoxSizeMode.Zoom;
                bunifuTransMaps.ShowSync(pb_VirtualMap);

            }

            HidePanels();
            grpBox_8thFloor.Visible = true;
            grpBox_8thFloor.Dock = DockStyle.Fill;
            grpBox_8thFloor.Visible = false;
            if (grpBox_8thFloor.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(grpBox_8thFloor);
                bunifuTransLabels.ShowSync(btn_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(grpBox_8thFloor);
            }
        }

        private void btn_9th_Click(object sender, EventArgs e)
        {            
            // Code for changing the Selected Button Color
            this.ButtonSeleted(sender);

            // Show Virtual Maps
            bunifuTransMaps.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                Image img = Image.FromFile(@"..\..\Virtual Maps\9th-rev.jpg");
                pb_VirtualMap.Image = img;
                pb_VirtualMap.SizeMode = PictureBoxSizeMode.Zoom;
                bunifuTransMaps.ShowSync(pb_VirtualMap);
            }

            HidePanels();
            grpBox_9thFloor.Visible = true;
            grpBox_9thFloor.Dock = DockStyle.Fill;
            grpBox_9thFloor.Visible = false;

            if (grpBox_9thFloor.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(grpBox_9thFloor);
                bunifuTransLabels.ShowSync(btn_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(grpBox_9thFloor);
            }
        }

        private void btn_10th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSeleted(sender);

            // Show Virtual Maps
            bunifuTransMaps.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                Image img = Image.FromFile(@"..\..\Virtual Maps\10th-rev.jpg");
                pb_VirtualMap.Image = img;
                pb_VirtualMap.SizeMode = PictureBoxSizeMode.Zoom;
                bunifuTransMaps.ShowSync(pb_VirtualMap);
            }

            HidePanels();
            grpBox_10thFloor.Visible = true;
            grpBox_10thFloor.Dock = DockStyle.Fill;
            grpBox_10thFloor.Visible = false;

            if (grpBox_10thFloor.Visible == false)
            {
                bunifuTransSelectDestination.ShowSync(grpBox_10thFloor);
                bunifuTransLabels.ShowSync(btn_BackToHome);
                bunifuTransLabels.ShowSync(lbl_GoHome);
            }
            else
            {
                bunifuTransSelectDestination.HideSync(grpBox_10thFloor);
            }
        }

        //Hide all Panel in Select Destinatoin
        public void HidePanels()
        {
            grpBox_UG.Visible = false;
            grpBox_2ndFloor.Visible = false;
            grpBox_3rdFloor.Visible = false;
            grpBox_4thFloor.Visible = false;
            grpBox_5thFloor.Visible = false;
            grpBox_6thFloor.Visible = false;
            grpBox_7thFloor.Visible = false;
            grpBox_8thFloor.Visible = false;
            grpBox_9thFloor.Visible = false;
            grpBox_10thFloor.Visible = false;
        }

        //Code for Close Application
        private void btn_Close_Click(object sender, EventArgs e)
        {
            System_Message _MessegeSystem = new System_Message();
            _MessegeSystem.ShowDialog();
        }

        // Fix for Double Thick line in Panel
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


        // Back to Home Button
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
        ////////////////// SYSTEM ALGORITHM CODE //////////////////////////////////////
        ////////////////////// START HERE //////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////
        bool onFirst = false;
        bool onSecond = false;
        bool onThird = false;
        bool onFourth = false;
        bool onFifth = false;
        bool onSixth = false;
        bool onSeventh = false;
        bool onEighth = false;
        bool onNinth = false;
        bool onTenth = false;

        int[] stairs = { 14, 39, 37, 60, 62, 77, 79, 112, 114, 124, 126, 150, 152, 212, 214, 244, 180, 182 };
        Dictionary<int, string> destinations = new Dictionary<int, string>();

        List<Point> ballList = new List<Point>();
        List<Point> text = new List<Point>();
        Dictionary<int, Point> vertex = new Dictionary<int, Point>();
        List<Tuple<int, int>> edge = new List<Tuple<int, int>>();
        int[] heuristics;

        int[] vertices;
        int[] start = new int[500];
        int[] end = new int[500];
        int ctr = 0;
        int edgeCount = 0;

        bool isTracingGoal = false;

        public void initializeDictionary()
        {
            //UG
            destinations.Add(5, "School Clinic");
            destinations.Add(6, "Room 101");
            destinations.Add(7, "Room 102");
            destinations.Add(8, "Room 103");
            destinations.Add(9, "Room 104");
            destinations.Add(10, "Records Room");
            destinations.Add(11, "E.E. Room (UG)");
            destinations.Add(15, "Male CR (UG)");
            destinations.Add(23, "Female CR (UG)");
            destinations.Add(24, "3D Animation Lab");
            destinations.Add(25, "SWS Office");
            destinations.Add(26, "Research Office");
            destinations.Add(21, "Software Development Office");
            destinations.Add(17, "Macintosh Computer Laboratory");
            destinations.Add(18, "Acer IOT Laboratory");
            destinations.Add(16, "Information Desk");
            //3rd Floor
            destinations.Add(47, "CNNA Laboratory & 3D Animation Laboratory");
            destinations.Add(67, "Computer Laboratory");
            destinations.Add(52, "College of Computer Studies");
            destinations.Add(51, "Room 301");
            destinations.Add(53, "Room 302");
            destinations.Add(54, "Room 303");
            destinations.Add(55, "Room 304");
            destinations.Add(57, "E.E. Room (3rd Floor)");
            destinations.Add(58, "Male CR (3rd Floor)");
            destinations.Add(59, "Female CR (3rd Floor)");
            destinations.Add(64, "DNTS Office");
            destinations.Add(65, "Data Center");
            destinations.Add(66, "Computer Hardware Servicing");
            //4th Floor
            destinations.Add(84, "Room 401");
            destinations.Add(85, "Room 402");
            destinations.Add(86, "Room 403");
            destinations.Add(87, "Room 404");
            destinations.Add(88, "Room 405");
            destinations.Add(89, "Room 406");
            destinations.Add(90, "Room 407");
            destinations.Add(91, "Room 408");
            destinations.Add(92, "Digital Drafting Room");
            destinations.Add(93, "E.E. Room (4th Floor)");
            destinations.Add(94, "Room 410");
            destinations.Add(95, "Room 411");
            destinations.Add(96, "Room 412");
            destinations.Add(97, "Room 413");
            destinations.Add(98, "Canteen");
            destinations.Add(82, "Room 414");
            destinations.Add(83, "Room 415");
            destinations.Add(107, "Library");
            destinations.Add(110, "Innovention Center");
            destinations.Add(111, "Kaizen Center");
            destinations.Add(117, "Male CR (5th Floor)");
            destinations.Add(116, "Female CR (5th Floor)");
            //6th Floor
            destinations.Add(127, "Home Management Lab");
            destinations.Add(128, "Kitchen");
            destinations.Add(129, "Learning Resource Center 3");
            destinations.Add(130, "E.E. Room (6th Floor)");
            destinations.Add(131, "Learning Resource Center 1");
            destinations.Add(132, "Learning Resource Center 2");
            destinations.Add(133, "Room 601");
            destinations.Add(134, "Room 602");
            destinations.Add(135, "Room 603");
            destinations.Add(136, "College of Business and Management");
            destinations.Add(137, "Simulated Hospital Condition");
            //7th Floor
            destinations.Add(165, "Reception Area");
            destinations.Add(164, "Canteen");
            destinations.Add(160, "Speech Lab");
            destinations.Add(159, "Guidance Office Counciling and Testing Room");
            destinations.Add(158, "Guidance Office");
            destinations.Add(157, "Scholarship Office");
            destinations.Add(154, "E.E. Room (7th Floor)");
            destinations.Add(155, "Male CR (7th Floor)");
            destinations.Add(156, "Female CR (7th Floor)");
            destinations.Add(162, "Cashier");
            destinations.Add(161, "Administration Office");
            destinations.Add(163, "Prayer Area");
            //8th Floor
            destinations.Add(183, "Room 801");
            destinations.Add(184, "Room 802");
            destinations.Add(185, "Room 804");
            destinations.Add(186, "Room 805");
            destinations.Add(187, "Room 807");
            destinations.Add(188, "Room 808");
            destinations.Add(197, "Room 806");
            destinations.Add(198, "Room 803");
            destinations.Add(199, "CASP Office");
            destinations.Add(189, "E.E. Room (8th Floor)");
            destinations.Add(190, "Room 809");
            destinations.Add(191, "Room 810");
            destinations.Add(192, "Room 811");
            destinations.Add(193, "Room 812");
            destinations.Add(194, "Room 813");
            destinations.Add(195, "Room 814");
            destinations.Add(196, "Room 815");
            //9th Floor
            destinations.Add(215, "Room 901");
            destinations.Add(216, "Room 902");
            destinations.Add(217, "Room 903");
            destinations.Add(218, "Room 904");
            destinations.Add(219, "Room 905");
            destinations.Add(220, "Room 906");
            destinations.Add(230, "Room 907");
            destinations.Add(229, "Room 915");
            destinations.Add(221, "E.E. Room (9th Floor)");
            destinations.Add(222, "Room 909");
            destinations.Add(223, "Room 910");
            destinations.Add(224, "Room 911");
            destinations.Add(225, "Room 912");
            destinations.Add(226, "Room 913");
            destinations.Add(227, "Room Senior High School Office");
            destinations.Add(228, "Room 914");
            destinations.Add(231, "Room 908");
            //10th Floor
            destinations.Add(253, "Basketball Court");
            destinations.Add(248, "E.E. Room (10th Floor)");
            destinations.Add(249, "Male CR (10th Floor)");
            destinations.Add(250, "Female CR (10th Floor)");
            destinations.Add(252, "Stage");
            destinations.Add(254, "P.E. & NSTP Office");
            destinations.Add(256, "Technical Area");
            destinations.Add(258, "Receiving Room");
        }

        public void reset()
        {
            ballList = new List<Point>();
            text = new List<Point>();
            vertex = new Dictionary<int, Point>();
            start = new int[500];
            end = new int[500];
            ctr = 0;
            edgeCount = 0;
            pb_VirtualMap.Refresh(); 
        }

        public void drawVertex(int posx, int posy, string label)
        {
            Bitmap bmp = new Bitmap(pb_VirtualMap.Width, pb_VirtualMap.Height);
            Graphics g = pb_VirtualMap.CreateGraphics();
            Brush blue;
            if (isTracingGoal)
            {
                blue = Brushes.Black;
            }
            else
            {
                blue = Brushes.LightGreen;
            }

            Font myFont = new Font("Arial", 8, FontStyle.Bold);
            g.FillEllipse(blue, posx - 10, posy - 10, 20, 20);
            g.DrawString(label, myFont, Brushes.LightGreen, new Point(posx - 7, posy - 6));
        }

        public void ConnectVertex(Point p1, Point p2, string label1, string label2)
        {
            int dist = Distance(p1, p2);
            int half = dist / 2;
            Bitmap bmp = new Bitmap(pb_VirtualMap.Width, pb_VirtualMap.Height);
            Graphics g = pb_VirtualMap.CreateGraphics();
            Pen pen;
            if (isTracingGoal)
            {
                pen = new Pen(Brushes.Red, 2);
            }
            else
            {
                pen = new Pen(Brushes.DarkBlue, 2);
            }

            g.DrawLine(pen, p1, p2);

            Font myFont = new Font("Arial", 6, FontStyle.Bold);

            Point mid = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
        }

        public static int Distance(Point p1, Point p2)
        {
            int dx = p1.X - p2.X;
            int dy = p1.Y - p2.Y;

            double distance = Math.Sqrt(dx * dx + dy * dy);

            return (int)Math.Round(distance, MidpointRounding.AwayFromZero);
        }

        public void loadNodes()
        {
            reset();
            string[] inputs = File.ReadAllLines(Environment.CurrentDirectory + @"\Nodes\Final Nodes");

            for (int x = 1; x < inputs.Length; x++)
            {
                if (inputs[x] == "connections:")
                {
                    x++;
                    for (int i = x; i < inputs.Length; i++)
                    {
                        string[] values = inputs[i].Split(',');
                        start[edgeCount] = int.Parse(values[0]);
                        end[edgeCount] = int.Parse(values[1]);

                        edgeCount++;
                    }
                    break;
                }

                string[] locations = inputs[x].Split(',');
                ballList.Add(new Point(int.Parse(locations[0]), int.Parse(locations[1])));
                text.Add(new Point(int.Parse(locations[0]), int.Parse(locations[1])));
                vertex.Add(x, new Point(int.Parse(locations[0]), int.Parse(locations[1])));
                // if (ctr >173)
                // {
                //drawVertex(int.Parse(locations[0]), int.Parse(locations[1]), (x).ToString());
                //  }
                //Counter for continuation of adding of nodes
                ctr = x;
            }
        }

        public void retrace(List<int> result, int destinationNode)
        {
            bool isStairs = false;
            pb_VirtualMap.Refresh();
            isTracingGoal = true;
            for (int i = 0; i < result.Count - 1; i++)
            {
                if (result[i] > 0 && result[i] < 33 && onFirst == false)
                {
                    onFirst = true;
                    onSecond = false;
                    onThird = false;
                    onFourth = false;
                    onFifth = false;
                    onSixth = false;
                    onSeventh = false;
                    onEighth = false;
                    onNinth = false;
                    onTenth = false;
                    pb_VirtualMap.Image = new Bitmap(Environment.CurrentDirectory + @"\Maps\1.jpg");
                    Application.DoEvents();
                    Thread.Sleep(500);

                }
                if (result[i] > 32 && result[i] < 41 && onSecond == false)
                {
                    onFirst = false;
                    onSecond = true;
                    onThird = false;
                    onFourth = false;
                    onFifth = false;
                    onSixth = false;
                    onSeventh = false;
                    onEighth = false;
                    onNinth = false;
                    onTenth = false;
                    pb_VirtualMap.Image = new Bitmap(Environment.CurrentDirectory + @"\Maps\2.jpg");
                    Application.DoEvents();
                    Thread.Sleep(500);
                }
                if (result[i] > 40 && result[i] < 68 && onThird == false)
                {
                    onFirst = false;
                    onSecond = false;
                    onThird = true;
                    onFourth = false;
                    onFifth = false;
                    onSixth = false;
                    onSeventh = false;
                    onEighth = false;
                    onNinth = false;
                    onTenth = false;
                    pb_VirtualMap.Image = new Bitmap(Environment.CurrentDirectory + @"\Maps\3.jpg");
                    Application.DoEvents();
                    Thread.Sleep(500);
                }
                if (result[i] > 67 && result[i] < 101 && onFourth == false)
                {
                    onFirst = false;
                    onSecond = false;
                    onThird = false;
                    onFourth = true;
                    onFifth = false;
                    onSixth = false;
                    onSeventh = false;
                    onEighth = false;
                    onNinth = false;
                    onTenth = false;
                    pb_VirtualMap.Image = new Bitmap(Environment.CurrentDirectory + @"\Maps\4.jpg");
                    Application.DoEvents();
                    Thread.Sleep(500);
                }
                if (result[i] > 100 && result[i] < 117 && onFifth == false)
                {
                    onFirst = false;
                    onSecond = false;
                    onThird = false;
                    onFourth = false;
                    onFifth = true;
                    onSixth = false;
                    onSeventh = false;
                    onEighth = false;
                    onNinth = false;
                    onTenth = false;
                    pb_VirtualMap.Image = new Bitmap(Environment.CurrentDirectory + @"\Maps\5.jpg");
                    Application.DoEvents();
                    Thread.Sleep(500);
                }
                if (result[i] > 116 && result[i] < 144 && onSixth == false)
                {
                    onFirst = false;
                    onSecond = false;
                    onThird = false;
                    onFourth = false;
                    onFifth = false;
                    onSixth = true;
                    onSeventh = false;
                    onEighth = false;
                    onNinth = false;
                    onTenth = false;
                    pb_VirtualMap.Image = new Bitmap(Environment.CurrentDirectory + @"\Maps\6.jpg");
                    Application.DoEvents();
                    Thread.Sleep(500);
                }
                if (result[i] > 143 && result[i] < 174 && onSeventh == false)
                {
                    onFirst = false;
                    onSecond = false;
                    onThird = false;
                    onFourth = false;
                    onFifth = false;
                    onSixth = false;
                    onSeventh = true;
                    onEighth = false;
                    onNinth = false;
                    onTenth = false;
                    pb_VirtualMap.Image = new Bitmap(Environment.CurrentDirectory + @"\Maps\7.jpg");
                    Application.DoEvents();
                    Thread.Sleep(500);
                }
                if (result[i] > 173 && result[i] < 206 && onEighth == false)
                {
                    onFirst = false;
                    onSecond = false;
                    onThird = false;
                    onFourth = false;
                    onFifth = false;
                    onSixth = false;
                    onSeventh = false;
                    onEighth = true;
                    onNinth = false;
                    onTenth = false;
                    pb_VirtualMap.Image = new Bitmap(Environment.CurrentDirectory + @"\Maps\8.jpg");
                    Application.DoEvents();
                    Thread.Sleep(500);
                }
                if (result[i] > 205 && result[i] < 238 && onNinth == false)
                {
                    onFirst = false;
                    onSecond = false;
                    onThird = false;
                    onFourth = false;
                    onFifth = false;
                    onSixth = false;
                    onSeventh = false;
                    onEighth = false;
                    onNinth = true;
                    onTenth = false;
                    pb_VirtualMap.Image = new Bitmap(Environment.CurrentDirectory + @"\Maps\9.jpg");
                    Application.DoEvents();
                    Thread.Sleep(500);
                }
                if (result[i] > 237 && result[i] < 259 && onTenth == false)
                {
                    onFirst = false;
                    onSecond = false;
                    onThird = false;
                    onFourth = false;
                    onFifth = false;
                    onSixth = false;
                    onSeventh = false;
                    onEighth = false;
                    onNinth = false;
                    onTenth = true;
                    pb_VirtualMap.Image = new Bitmap(Environment.CurrentDirectory + @"\Maps\10.jpg");
                    Application.DoEvents();
                    Thread.Sleep(500);
                }
                /* if (Array.Exists(stairs, element => element == result[i]) && Array.Exists(stairs, element => element == result[i + 1]))
                 {
                     isStairs = true;
                     drawVertex(vertex[result[i]].X, vertex[result[i]].Y, result[i].ToString());
                 }
                 if (!isStairs)
                 {*/
                ConnectVertex(vertex[result[i]], vertex[result[i + 1]], result[i].ToString(), result[i + 1].ToString());
                drawVertex(vertex[result[i]].X, vertex[result[i]].Y, result[i].ToString());
                //}
                Thread.Sleep(800);
                isStairs = false;
            }
            drawVertex(vertex[destinationNode].X, vertex[destinationNode].Y, destinationNode.ToString());
            isTracingGoal = false;
        }

        public void performAStar(int startingNode, int endingNode)
        {
            showHeuristic(endingNode);
            vertices = new int[vertex.Count];
            var graph = new GraphAstar<int>();
            for (int i = 0; i < vertex.Count; i++)
            {
                vertices[i] = i + 1;
                graph.setLocation(vertices[i], new Point(vertex[i + 1].X, vertex[i + 1].Y));
            }

            edge = new List<Tuple<int, int>>();
            for (int i = 0; i < edgeCount; i++)
            {
                edge.Add(Tuple.Create(start[i], end[i]));
                graph.setIndividualDistance(Tuple.Create(start[i], end[i]), Distance(new Point(vertex[start[i]].X, vertex[start[i]].Y), new Point(vertex[end[i]].X, vertex[end[i]].Y)));

            }
            string t = "";
            foreach (var a in graph.withCost)
            {
                t += a.Key + "::" + a.Value;
            }

            graph.init(vertices, edge);

            var algorithms = new GraphAlgorithms();

            var nodes = algorithms.AStar(graph, startingNode, endingNode, heuristics).Reverse();
            List<int> result = new List<int>();
            foreach (var item in nodes)
            {
                result.Add(item);
            }
            retrace(result, endingNode);
        }

        public void showHeuristic(int endingNode)
        {
            heuristics = new int[vertex.Count + 1];
            Point end = new Point(vertex[endingNode].X, vertex[endingNode].Y);
            for (int i = 1; i < vertex.Count + 1; i++)
            {
                heuristics[i] = Distance(new Point(vertex[i].X, vertex[i].Y), end);
            }
        }

        private void btn_UG_3DLab_Click(object sender, EventArgs e)
        {
            performAStar(1, 17);
        }
    }
}
