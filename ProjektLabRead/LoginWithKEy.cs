using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinZugriffssteuerung;

namespace ProjektLabRead
{
    public partial class LoginWithKEy : Form
    {
        public LoginWithKEy()
        {
            InitializeComponent();
        }

        private static async void keyUsed()
        {
            iButton button = new iButton();
            var ids = await Task.FromResult<string>(button.read_IDs());
            MessageBox.Show(ids);
            string[] kid = ids.Split(';');
            ActiveForm.Hide();
            Login login=new Login(kid[0]);
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BTN_return_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void LoginWithKEy_Load(object sender, EventArgs e)
        {
            keyUsed();
        }
    }
}
