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
    public partial class UC_4th : UserControl
    {
        public UC_4th(form_Main frm)
        {
            InitializeComponent();
            MainForm = frm;
        }
        form_Main MainForm;

        private void btn_4th_DDRM_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 92);
        }

        private void btn_4th_EERM_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 93);
        }

        private void btn_4th_RM401_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 84);
        }

        private void btn_4th_RM402_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 85);
        }

        private void btn_4th_RM403_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 86);
        }

        private void btn_4th_RM404_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 87);
        }

        private void btn_4th_RM405_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 88);
        }

        private void AS_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 89);
        }

        private void btn_4th_RM407_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 90);
        }

        private void btn_4th_RM408_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 91);
        }

        private void btn_4th_RM409_Click(object sender, EventArgs e)
        {

        }

        private void A_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 94);
        }

        private void btn_4th_411_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 95);
        }

        private void btn_4th_RM412_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 96);
        }

        private void btn_4th_RM413_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 97);
        }

        private void btn_4th_RM414_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 82);
        }

        private void btn_4th_RM415_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 83);
        }
    }
}
