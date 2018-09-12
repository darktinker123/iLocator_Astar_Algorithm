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
    public partial class form_Login : Form
    {
        public form_Login()
        {
            InitializeComponent();
        }

        private void form_Login_Load(object sender, EventArgs e)
        {
            bunifuTxtBox_Username.Text = "Username";
            bunifuTxtBox_Password.Text = "Password";
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bunifuTxtBox_Username_Enter(object sender, EventArgs e)
        {
            if (bunifuTxtBox_Username.Text == "Username")
            {
                bunifuTxtBox_Username.Text = "";
            }
        }
        private void bunifuTxtBox_Username_Leave(object sender, EventArgs e)
        {
            if (bunifuTxtBox_Username.Text == "")
            {
                bunifuTxtBox_Username.Text = "Username";
            }
        }
        private void bunifuTxtBox_Password_Enter(object sender, EventArgs e)
        {
            if (bunifuTxtBox_Password.Text == "Password")
            {
                bunifuTxtBox_Password.Text = "";
                bunifuTxtBox_Password.isPassword = true;
            }
        }
        private void bunifuTxtBox_Password_Leave(object sender, EventArgs e)
        {
            if (bunifuTxtBox_Password.Text == "")
            {
                bunifuTxtBox_Password.isPassword = false;
                bunifuTxtBox_Password.Text = "Password";
            }
        }
        private void btn_AdminLogin_Click(object sender, EventArgs e)
        {
            if (bunifuTxtBox_Username.Text == "admin" && bunifuTxtBox_Password.Text == "admin123")
            {
                form_AdminDashboard AdminDashBoardForm = new form_AdminDashboard();
                AdminDashBoardForm.BringToFront();
                AdminDashBoardForm.Show();
                this.Dispose();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn_AdminLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_AdminLogin_Click(this, new EventArgs());
            }
        }
        private void bunifuTxtBox_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_AdminLogin_Click(e, new EventArgs());
            }
        }

        private void bunifuTxtBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_AdminLogin_Click(e, new EventArgs());
            }
        }


    }
}
