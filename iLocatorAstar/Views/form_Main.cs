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

        string startingFlr = "";

        //DECLARATION OF USER CONTROL
        UC_UG usercontrolUG;
        UC_2nd usercontrol2nd;
        UC_3rd usercontrol3rd;
        UC_4th usercontrol4th;
        UC_5th usercontrol5th;
        UC_6th usercontrol6th;
        UC_7th usercontrol7th;
        UC_8th usercontrol8th;
        UC_9th usercontrol9th;
        UC_10th usercontrol10th;

        ////////////////// SYSTEM UI CODES /////////////////////////////
        //////////////////// START HERE ////////////////////////////////
        ////////////////////////////////////////////////////////////////
        public string currentFloor;
        private void form_Main_Load(object sender, EventArgs e)
        {
             loadNodes();
            initializeDictionary();
            HidePanels();   //HIDE ALL DIRECTORIES
            WindowState = FormWindowState.Maximized;
            bunifuFadeTransition.ShowSync(panel_ContainerMain);
            InitializeUserControl();
            LoadConfigFile();
        }

        //READ CONFIG FILE
        private void LoadConfigFile()
        {
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
                        if (int.Parse(values[1]) < ballList.Count ||
                            int.Parse(values[1]) == ballList.Count &&
                             int.Parse(values[1]) > 0)
                        {
                            startingNode = int.Parse(values[1]);
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Starting Point invalid! Please check the system's configuration file.");
                            startingNode = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Starting Point invalid! Please check the system's configuration file.");
                        startingNode = 0;
                        break;
                    }

                }
            }

            IdentifyStartingFlr(startingNode);
        }

        private void InitializeUserControl()
        {
            usercontrolUG = new UC_UG(this);
            usercontrol2nd = new UC_2nd(this);
            usercontrol3rd = new UC_3rd(this);
            usercontrol4th = new UC_4th(this);
            usercontrol5th = new UC_5th(this);
            usercontrol6th = new UC_6th(this);
            usercontrol7th = new UC_7th(this);
            usercontrol8th = new UC_8th(this);
            usercontrol9th = new UC_9th(this);
            usercontrol10th = new UC_10th(this);
        }

        //IDENTIFY STARTING FLOOR BASED ON CONFIG FILE
        //SELECT BUTTON AND DISPLAY MAP UPON LOAD
        private void IdentifyStartingFlr(int startingnode)
        {
            switch (startingnode)
            {
                case 1:
                    startingFlr = "UG";
                    ButtonSelected(btn_UG);
                    LoadMap("UG");
                    ShowUserControl(usercontrolUG);
                    break;
                case 42:
                    startingFlr = "3rd";
                    LoadMap("3rd");
                    ShowUserControl(usercontrol3rd);
                    break;
                case 106:
                    startingFlr = "5th";
                    LoadMap("5th");
                    ShowUserControl(usercontrol5th);
                    break;
                case 145:
                    startingFlr = "7th";
                    ButtonSelected(btn_7th);
                    LoadMap("7th");
                    ShowUserControl(usercontrol7th);
                    break;
                default:
                    startingFlr = "9th";
                    ButtonSelected(btn_9th);
                    LoadMap("9th");
                    ShowUserControl(usercontrol9th);
                    break;
            }
        }
       

        Image img = null;
        Image mapUG = Image.FromFile(@"..\..\bin\debug\Maps\1st-rev.jpg");
        Image map2nd = Image.FromFile(@"..\..\bin\debug\Maps\2nd-rev.jpg");
        Image map3rd = Image.FromFile(@"..\..\bin\debug\Maps\3rd-rev.jpg");
        Image map4th = Image.FromFile(@"..\..\bin\debug\Maps\4th-rev.jpg");
        Image map5th = Image.FromFile(@"..\..\bin\debug\Maps\5th-rev.jpg");
        Image map6th = Image.FromFile(@"..\..\bin\debug\Maps\6th-rev.jpg");
        Image map7th = Image.FromFile(@"..\..\bin\debug\Maps\7th-rev.jpg");
        Image map8th = Image.FromFile(@"..\..\bin\debug\Maps\8th-rev.jpg");
        Image map9th = Image.FromFile(@"..\..\bin\debug\Maps\9th-rev.jpg");
        Image map10th = Image.FromFile(@"..\..\bin\debug\Maps\10th-rev.jpg");

        //LOADING OF MAP, ACCEPTS A STRING PARAMETER TO IDENTIFY WHICH FLOOR TO DISPLAY
        private void LoadMap(string flr)
        {
            if (flr == startingFlr) //IF FLR IS THE STARTING FLR THEN LOAD MAP WITH YOU ARE HERE INDICATOR
            {
                switch (flr)
                {
                    case "UG":
                        img = Image.FromFile(@"..\..\bin\debug\Maps\1st-rev-here.jpg");;
                        break;
                    case "3rd":
                        img = Image.FromFile(@"..\..\bin\debug\Maps\3rd-rev-here.jpg");;
                        break;
                    case "5th":
                        img = Image.FromFile(@"..\..\bin\debug\Maps\5th-rev-here.jpg");;
                        break;
                    case "7th":
                        img = Image.FromFile(@"..\..\bin\debug\Maps\7th-rev-here.jpg");;
                        break;
                    default:
                        img = Image.FromFile(@"..\..\bin\debug\Maps\9th-rev-here.jpg");;
                        break;
                }
            }

            else
            {
                //FLR IS NOT THE STARTING FLR, LOAD NORMAL MAP
                switch (flr)
                {
                    case "UG":
                        img = mapUG;
                        break;
                    case "2nd":
                        img = map2nd;
                        break;
                    case "3rd":
                        img = map3rd;
                        break;
                    case "4th":
                        img = map4th;
                        break;
                    case "5th":
                        img = map5th;
                        break;
                    case "6th":
                        img = map6th;
                        break;
                    case "7th":
                        img = map7th;
                        break;
                    case "8th":
                        img = map8th;
                        break;
                    case "9th":
                        img = map9th;
                        break;
                    default:
                        img = map10th;
                        break;
                }
            }
            pb_VirtualMap.Image = img;
            pb_VirtualMap.SizeMode = PictureBoxSizeMode.Zoom;
            bunifuLeafTransition.ShowSync(pb_VirtualMap);

            DisplayFlrNumber(flr);

        }

        //SHOWING OF USERCONTROL AND THIN BUTTONS        
        private void ShowUserControl(UserControl uc)
        {
            if (panel_ContainerSelectDestination.Visible == false)
            {
                panel_ContainerSelectDestination.Controls.Add(uc);
                bunifuLeafTransition.ShowSync(panel_ContainerSelectDestination);
                ShowAddonButtons();
            }
            else
            {
                bunifuLeafTransition.HideSync(panel_ContainerSelectDestination);
            }
        }

        private void DisplayFlrNumber(string flrname)
        {
            //if (flrname=="UG")
            //{
            //    flrname = "Upper Ground";
            //}

            lblFloor.Text = flrname+" Floor";
        }

        //CODE FOR CHANGING THE COLOR OF SELECTED BUTTON
        private void ButtonSelected(object sender)
        {
            BunifuFlatButton selectedBtn = sender as BunifuFlatButton;

            foreach (Control c in tableLayoutPanel_FloorButtons.Controls)
            {
                BunifuFlatButton BtnSelected = c as BunifuFlatButton;

                if (c is BunifuFlatButton)
                {
                    BtnSelected.Normalcolor = Color.RoyalBlue;
                    BtnSelected.Textcolor = Color.White;
                }
                selectedBtn.Normalcolor = Color.Yellow;
                selectedBtn.Textcolor = Color.Black;
                //selectedBtn.Font = new Font(selectedBtn.Font.Name, selectedBtn.Font.Size, FontStyle.Bold);
            }
        }
      
        private void btn_UG_Click(object sender, EventArgs e)
        {

            // Code for changing the Selected Button Color
            this.ButtonSelected(sender);

            // Show Virtual Map
            bunifuLeafTransition.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                LoadMap("UG");
            }

            // Hide List of Directories in Select Destination
            HidePanels();
            ShowUserControl(usercontrolUG);
            showNodes(0, 33);
        }

        private void btn_2nd_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSelected(sender);

            // Show Virtual Maps
            bunifuLeafTransition.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                LoadMap("2nd");
            }

            HidePanels();
            ShowUserControl(usercontrol2nd);
            showNodes(32, 41);
        }

        private void btn_3rd_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSelected(sender);

            // Show Virtual Maps
            bunifuLeafTransition.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                LoadMap("3rd");
            }

            HidePanels();
            ShowUserControl(usercontrol3rd);
            showNodes(40, 68);
        }

        private void btn_4th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSelected(sender);

            // Show Virtual Maps
            bunifuLeafTransition.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                LoadMap("4th");
            }

            HidePanels();
            ShowUserControl(usercontrol4th);
            showNodes(67, 101);
        }

        private void btn_5th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSelected(sender);

            // Show Virtual Maps
            bunifuLeafTransition.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                LoadMap("5th");
            }

            HidePanels();
            ShowUserControl(usercontrol5th);
            showNodes(100, 118);
        }

        private void btn_6th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSelected(sender);

            // Show Virtual Maps
            bunifuLeafTransition.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                LoadMap("6th");

            }
            HidePanels();
            ShowUserControl(usercontrol6th);
            showNodes(117, 144);
        }

        private void btn_7th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSelected(sender);

            // Show Virtual Maps
            bunifuLeafTransition.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                LoadMap("7th");
            }

            HidePanels();
            ShowUserControl(usercontrol7th);
            showNodes(143, 174);
        }

        private void btn_8th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSelected(sender);

            // Show Virtual Maps
            bunifuLeafTransition.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                LoadMap("8th");

            }

            HidePanels();
            ShowUserControl(usercontrol8th);
            showNodes(173, 206);
        }

        private void btn_9th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSelected(sender);

            // Show Virtual Maps
            bunifuLeafTransition.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                LoadMap("9th");
            }

            HidePanels();
            ShowUserControl(usercontrol9th);
            showNodes(205, 238);
        }

        private void btn_10th_Click(object sender, EventArgs e)
        {
            // Code for changing the Selected Button Color
            this.ButtonSelected(sender);

            // Show Virtual Maps
            bunifuLeafTransition.HideSync(pb_VirtualMap);

            if (pb_VirtualMap.Visible == false)
            {
                LoadMap("10th");
            }

            HidePanels(); 
            ShowUserControl(usercontrol10th);
            showNodes(237, 259);
        }

        //Hide all Panel in Select Destinatoin
        public void HidePanels()
        {
            panel_ContainerSelectDestination.Visible = false;
            panel_ContainerSelectDestination.Controls.Clear();
        }

        public void ShowAddonButtons()
        {
            bunifuFadeTransition.ShowSync(btn_BackToHome);
            bunifuFadeTransition.ShowSync(lbl_GoHome);
            bunifuFadeTransition.ShowSync(btn_Replay);
            bunifuFadeTransition.ShowSync(lbl_Replay);
        }
        
        // Fix for Double Thick line in Panel
        private void panel_ContainerFloorSelector_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel_ContainerFloorSelector.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void panel_UniverseSelectDestination_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.panel_UniverseSelectDestination.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);

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

        //SHOWING OF NODES UPON FORM LOAD
        public void showNodes(int min, int max)
        {
            for (int x = 1; x < ballList.Count; x++)
            {
                if (x > min && x < max && destinations.ContainsKey(x))
                {
                    drawVertex(ballList[x - 1].X, ballList[x - 1].Y, (x).ToString());
                }
            }
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

        public int startingNode;

        int[] stairs = { 14, 39, 37, 60, 62, 77, 79, 112, 114, 124, 126, 150, 152, 212, 214, 244, 180, 182 };
        public Dictionary<int, string> destinations = new Dictionary<int, string>();

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
            destinations.Add(47, "CNNA Lab and 3D Animation Lab");
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
            destinations.Add(98, "Canteen (4th Floor)");
            destinations.Add(82, "Room 414");
            destinations.Add(83, "Room 415");
            //5th Floor
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
            destinations.Add(164, "Canteen (7th Floor)");
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
                blue = Brushes.DeepSkyBlue;
            }
            else
            {
                blue = Brushes.MediumSeaGreen;
            }

            Font myFont = new Font("Arial", 8, FontStyle.Bold);
            g.FillEllipse(blue, posx - 10, posy - 10, 20, 20);
            g.DrawString(label, myFont, Brushes.Black, new Point(posx - 7, posy - 6));
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
                pen = new Pen(Brushes.DeepPink, 2);
            }
            else
            {
                pen = new Pen(Brushes.Purple, 2);
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

        int cummulativeDistance;
        string shortestPath;
        public void retrace(List<int> result, int destinationNode)
        {
            bool isStairs = false;
            cummulativeDistance = 0;
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
                    pb_VirtualMap.Image = mapUG;
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
                    pb_VirtualMap.Image = map2nd;
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
                    pb_VirtualMap.Image = map3rd; 
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
                    pb_VirtualMap.Image = map4th;
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
                    pb_VirtualMap.Image = map5th;
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
                    pb_VirtualMap.Image = map6th;
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
                    pb_VirtualMap.Image = map7th;
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
                    pb_VirtualMap.Image = map8th;
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
                    pb_VirtualMap.Image = map9th;
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
                    pb_VirtualMap.Image = map10th;
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

                cummulativeDistance = cummulativeDistance + Distance(ballList[result[i] - 1], ballList[result[i + 1] - 1]);
            }
            drawVertex(vertex[destinationNode].X, vertex[destinationNode].Y, destinationNode.ToString());
            isTracingGoal = false;

            //NEW
            //Distance formula and display
            //For every 50 computed distance = 2 meters
            //You can change the formula
            //Average walking speed is 1.4 meters per second
            double estimatedDistance = (cummulativeDistance / 50) * 3;
            double estimatedTime = estimatedDistance / 1.4;

            TimeSpan ts = TimeSpan.FromSeconds(estimatedTime);
            int tsMinutes = ts.Minutes;
            int tsSeconds = ts.Seconds;

            lbl_EstimatedDistance.Text = "Estimated Distance: " + estimatedDistance + " Meters";
            lbl_EstimatedTime.Text = "Estimated Time: " + tsMinutes + " Minutes and " + tsSeconds + " Seconds";

            for (int i = 0; i < result.Count; i++)
            {
                shortestPath = shortestPath + " " + result[i];
                if (i + 1 != result.Count)
                {
                    shortestPath = shortestPath + " -";
                }
            }

            resetFloorsBool();
        }

        public void resetFloorsBool()
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
            onTenth = false;
        }

        List<int> NodesResult;
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
            NodesResult = result;
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

        public string usertype = "";
        DataClasses1DataContext db = new DataClasses1DataContext();

        //METHOD FOR SELECTING LOCATIONS (CLICKING OF THIN BUTTONS)        
        public void thinButtonClick(BunifuThinButton2 btn)
        {
            string btnName = btn.ButtonText;
            int nodeNumber = destinations.FirstOrDefault(x => x.Value == btnName).Key;
            endingNode = nodeNumber;
            performAStar(startingNode, nodeNumber);
            db.sp_AddUserLogs(usertype, currentFloor, btnName, DateTime.Now);
        }

        int endingNode;
        private void btn_Replay_Click(object sender, EventArgs e)
        {
            retrace(NodesResult, endingNode);
        }

        private void pb_VirtualMap_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

    }
}
