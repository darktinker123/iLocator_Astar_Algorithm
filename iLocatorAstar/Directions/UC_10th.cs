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
    public partial class UC_10th : UserControl
    {
        public UC_10th(form_Main frm)
        {
            InitializeComponent();
            MainForm = frm;
        }
        form_Main MainForm;

        private void btn_10th_BasketBallCourt_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 253);
        }

        private void btn_10th_FCR_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 250);
        }

        private void btn_10th_MCR_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 249);
        }

        private void btn_10th_PENSTPOffice_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 254);
        }

        private void btn_10th_ReceivingArea_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 258);
        }

        private void btn_10th_TechnicalArea_Click(object sender, EventArgs e)
        {
            MainForm.performAStar(1, 256);
        }
    }
}
