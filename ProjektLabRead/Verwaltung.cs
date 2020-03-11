using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinDruckauftrag;

namespace ProjektLabRead
{
    public partial class Verwaltung : Form
    {
        public Verwaltung()
        {
            InitializeComponent();
            Dbase dtbl = new Dbase("Projektlabor", "root", "");
           Userdata.DataSource = dtbl.CommandSelectAsDataTableFrom("User");
        }

        private void Userdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
