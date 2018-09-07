using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLocatorAstar
{
    public partial class UC_3rd : UserControl
    {
        public UC_3rd(form_Main frm)
        {
            InitializeComponent();
            MainForm = frm;
        }

        form_Main MainForm;

        private void btn_3rd_3DAnimLab_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 47);
        }

        private void btn_3rd_CCNALab_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 47);
        }

        private void btn_3rd_CCS_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 52);
        }

        private void btn_3rd_Lab6_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 66);
        }

        private void btn_3rd_DataCenter_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 65);
        }

        private void btn_3rd_DNTS_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 64);
        }

        private void btn_3rd_EERoom_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 57);
        }

        private void asd_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 59);
        }

        private void btn_3rd_MCR_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 58);
        }

        private void btn_3rd_RM301_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 51);
        }

        private void btn_3rd_RM302_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 53);
        }

        private void btn_3rd_RM303_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 54);
        }

        private void btn_3rd_RM304_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 55);
        }
    }
}
