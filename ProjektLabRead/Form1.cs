using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektLabRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TBX_User_Enter(object sender, EventArgs e)
        {
            if (TBX_User.Text == "Nutzername")
            {
                TBX_User.Text = null;
                TBX_User.ForeColor=Color.Black;
            }
        }

        private void TBX_User_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBX_User.Text))
            {
                TBX_User.Text = "Nutzername";
                TBX_User.ForeColor = Color.FromArgb(70, Color.Black);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TBX_User.ForeColor = Color.FromArgb(70, Color.Black);
            TBX_Pass.ForeColor = Color.FromArgb(70, Color.Black);
        }

        private void TBX_Pass_TextChanged(object sender, EventArgs e)
        {
        }

        private void TBX_Pass_Enter(object sender, EventArgs e)
        {
            if (TBX_Pass.Text == "Passwort")
            {
                TBX_Pass.Text = null;
                TBX_Pass.ForeColor=Color.Black;
                TBX_Pass.PasswordChar = '•';
            }
        }

        private void TBX_Pass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBX_Pass.Text))
            {
                TBX_Pass.Text = "Passwort";
                TBX_Pass.ForeColor = Color.FromArgb(70, Color.Black);
                TBX_Pass.PasswordChar = '\0';
            }
        }

        private void TBX_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_Login_Click(this,new EventArgs());
            }
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            Login login=new Login();
        }
    }
}
