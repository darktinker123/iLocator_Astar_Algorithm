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
    public partial class UC_UG : UserControl
    {
        public UC_UG(form_Main frm)
        {
            InitializeComponent();
            MainForm = frm;
        }

        form_Main MainForm;
        
        private void btn_UG_3DLab_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 24);
        }

        private void btn_UG_AcerLab_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 18);
        }

        private void btn_UG_Canteen_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 5);
        }

        private void btn_UG_EERoom_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 11);
        }

        private void btn_UG_FemaleCR_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 23);
        }

        private void btn_UG_MaleCR_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 15);
        }

        private void btn_UG_MacLab_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 17);
        }

        private void btn_UG_Penbank_Click(object sender, EventArgs e)
        {
            //MainForm.performAStar(1, );
        }

        private void btn_UG_RecordsRoom_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 10);
        }

        private void btn_UG_Rm101_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 6);
        }

        private void btn_UG_Rm102_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 7);
        }

        private void btn_UG_Rm103_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 8);
        }

        private void btn_UG_Rm104_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 9);
        }

        private void btn_UG_SchoolClinic_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 5);
        }

        private void btn_UG_SDO_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 21);
        }

        private void btn_UG_SWS_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 25);
        }
    }
}
