using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.IO;
using System.Threading;

namespace iLocatorAstar
{
    public partial class UC_5th : UserControl
    {
        public UC_5th(form_Main frm)
        {
            InitializeComponent();
            mainForm = frm;
        }

        form_Main mainForm;
        private void ButtonClick(object sender, EventArgs e)
        {
            BunifuThinButton2 btn = (BunifuThinButton2)sender;
            mainForm.thinButtonClick(btn);
        }
    }
}
