using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLocatorAstar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            bunifuTransition1.ShowSync(button1);
            bunifuTransition2.ShowSync(label1);
            bunifuTransition2.ShowSync(label2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 _Form2 = new Form2();
            _Form2.Show();
            this.Hide();
        }
    }
}
