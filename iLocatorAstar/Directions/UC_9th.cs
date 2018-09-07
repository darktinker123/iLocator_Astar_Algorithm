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
    public partial class UC_9th : UserControl
    {
        public UC_9th(form_Main frm)
        {
            InitializeComponent();
            MainForm = frm;
        }
        form_Main MainForm;

        private void btn_9th_SHS_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 227);
        }

        private void btn_9th_EERM_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 221);
        }

        private void btn_9th_RM901_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 215);
        }

        private void btn_9th_RM902_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 216);
        }

        private void a_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 217);
        }

        private void btn_9th_RM904_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 218);
        }

        private void btn_9th_RM905_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 219);
        }

        private void btn_9th_RM906_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 220);
        }

        private void btn_9th_RM907_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 230);
        }

        private void btn_9th_RM908_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 231);
        }

        private void btn_9th_RM909_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 222);
        }

        private void btn_9th_RM910_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 223);
        }

        private void btn_9th_RM911_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 224);
        }

        private void btn_9th_RM912_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 225);
        }

        private void btn_9th_RM913_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 226);
        }

        private void btn_9th_RM914_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 228);
        }

        private void btn_9th_RM915_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 229);
        }
    }
}
