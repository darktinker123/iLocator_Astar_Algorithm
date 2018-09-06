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
            MainForm.performAStar(1, 10);
        }
    }
}
