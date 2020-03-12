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
                TBX_Vorname.Visible = false;
                TBX_Benutzername.Visible = false;
                TBX_Nachname.Visible = false;
                TBX_Passwort.Visible = false;
                TBX_UID.Visible = false;
                TBX_Email.Visible = false;
                TBX_Ibutton.Visible = false;
                CBX_Key.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                button3.Visible = false;
                button2.Visible = false;
                button1.Visible = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (Userdata.SelectedCells.Count > 0)
            {
                int selectedrowindex = Userdata.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Userdata.Rows[selectedrowindex];  
                TBX_Vorname.Text = Convert.ToString(selectedRow.Cells["Vorname"].Value); 
                TBX_Nachname.Text = Convert.ToString(selectedRow.Cells["Nachname"].Value); 
                TBX_Email.Text = Convert.ToString(selectedRow.Cells["E-mail"].Value); 
                TBX_Benutzername.Text = Convert.ToString(selectedRow.Cells["Benutzername"].Value); 
                TBX_Passwort.Text = Convert.ToString(selectedRow.Cells["Passwort"].Value);
                TBX_Ibutton.Text = Convert.ToString(selectedRow.Cells["iButtonID"].Value);
                TBX_UID.Text = Convert.ToString(selectedRow.Cells["UserID"].Value);
                if (Convert.ToBoolean(selectedRow.Cells["KeyMember"].Value) == true)
                {
                    CBX_Key.CheckState = CheckState.Checked;
                    CBX_Key.Checked = true;
                }
                else
                {
                    CBX_Key.Checked = false;
                    CBX_Key.CheckState = CheckState.Unchecked;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReadKey read = new ReadKey(this);
        }
    }
}

