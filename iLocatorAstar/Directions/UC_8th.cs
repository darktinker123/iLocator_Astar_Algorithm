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
    public partial class UC_8th : UserControl
    {
        public UC_8th(form_Main frm)
        {
            InitializeComponent();
            MainForm = frm;
        }

        form_Main MainForm;

        private void btn_8th_CASP_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 199);
        }

        private void btn_8th_EERM_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 189);
        }

        private void btn_8th_RM801_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 183);
        }

        private void btn_8th_RM802_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 184);
        }

        private void btn_8th_RM803_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 198);
        }

        private void btn_8th_RM804_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 185);
        }

        private void btn_8th_RM805_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 186);
        }

        private void btn_8th_RM806_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 197);
        }

        private void btn_8th_RM807_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 187);
        }

        private void btn_8th_RM808_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 188);
        }

        private void btn_8th_RM809_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 190);
        }

        private void btn_8th_RM810_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 191);
        }

        private void btn_8th_RM811_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 192);
        }

        private void btn_8th_RM812_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 193);
        }

        private void btn_8th_RM814_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 195);
        }

        private void btn_8th_RM815_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 196);
        }
    }

}
