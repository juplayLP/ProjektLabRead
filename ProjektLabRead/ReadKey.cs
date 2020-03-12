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
    public partial class ReadKey : Form
    {
        public ReadKey(Verwaltung vw)
        {
            InitializeComponent();
            Read();
        }

        private static async void Read()
        {
            iButton button = new iButton();
            var ids = await Task.FromResult<string>(button.read_IDs());
            MessageBox.Show(ids);
            string[] kid = ids.Split(';');
            ActiveForm.Hide();

        }
    }
}
