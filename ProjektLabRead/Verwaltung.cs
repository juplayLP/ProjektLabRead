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
        public Verwaltung(int status)
        {
            InitializeComponent();
            Dbase dtbl = new Dbase("Projektlabor", "root", "Ubuntu12.04!!");
            if (status == 1)
            {
                Userdata.DataSource = dtbl.CommandSelectAsDataTableFrom("User");
            }
            else
            {
                Userdata.DataSource =
                    dtbl.CommandSelectAsDataTableFrom("UserID, Vorname, Nachname, `E-Mail`, Keymember, IButtonID","user","WHERE 1");
            }
           Zugriffdata.DataSource = dtbl.CommandSelectAsDataTableFrom("Zuweisung");
        }

        private void Userdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Verwaltung_Resize(object sender, EventArgs e)
        {

        }

        private void Verwaltung_ResizeEnd(object sender, EventArgs e)
        {
            Tab.Height = this.Height-22;
            Tab.Width = this.Width - 15;
            Userdata.Height= Tab.Height-40;
            Userdata.Width = Tab.Width - 2;
            Zugriffdata.Height= Tab.Height-40;
            Zugriffdata.Width = Tab.Width - 2;
        }

        private void Verwaltung_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(e);

        }
    }
}

