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
        int stat;
        public Verwaltung(int status)
        {
            InitializeComponent();
            int stat;
            Dbase dtbl = new Dbase("Projektlabor", "root", "");
            if (status == 1)
            {
                Userdata.DataSource = dtbl.CommandSelectAsDataTableFrom("User");
            }
            else
            {
                Userdata.DataSource =
                    dtbl.CommandSelectAsDataTableFrom("UserID, Vorname, Nachname, `E-Mail`, Keymember, IButtonID", "user", "WHERE 1");
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
            Tab.Height = this.Height - 22;
            Tab.Width = this.Width - 15;
            Userdata.Height = Tab.Height - 40;
            Userdata.Width = Tab.Width - 2;
            Zugriffdata.Height = Tab.Height - 40;
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
                TBX_Email.Text = Convert.ToString(selectedRow.Cells["Email"].Value);
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

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TBX_UID.Text != null) {
                int c;
                if(CBX_Key.Checked == true)
                {
                    c = 1;
                }
                else
                {
                    c = 0;
                }
                Dbase dba = new Dbase("Projektlabor", "root", "");
                dba.CommandUpdate("user", "Vorname = \' " + TBX_Vorname.Text + " \' ," + "Nachname = \' " + TBX_Nachname.Text + " \' ," +" Email = \' " + TBX_Email.Text + " \' ," + "Benutzername = \' " + TBX_Benutzername.Text + " \' ," + "iButtonID = \'" + TBX_Ibutton.Text + "\' ," + " Passwort = \' " + TBX_Passwort.Text + " \' ," + "Keymember = \' " + c +" \' ", "Where UserID = \' "+ TBX_UID.Text + " \' ");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TBX_Benutzername.Text = "";
            TBX_Nachname.Text = "";
            TBX_Vorname.Text = "";
            TBX_Passwort.Text = "";
            TBX_UID.Text = "";
            TBX_Ibutton.Text = "";
            TBX_Email.Text = "";
            CBX_Key.CheckState = CBX_Key.CheckState = CheckState.Unchecked;
        }

        private void TBX_IButt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e) //read ibutton
        {
            ReadKey read = new ReadKey(this);     //wert in textfeld schreiben
        }

        private void Button6_Click(object sender, EventArgs e) //Entziehen
        {
            Dbase krecht = new Dbase("Projektlabor", "root", "");

            var re = new List<string[]> { };
                re = krecht.CommandSelectAsListFrom("MaschinenID", "zuweisung"," where iButtonID = \'"+ TBX_IButt.Text+"\'");    //berrechtigungen des Ausgeählten IButtons anzeigen

            CMBX_Recht.Items.Clear();

            
            for(int o = 0;o < re.Count; o++)
            {
                string[] i = re[o];
                string y = i[0];
                CMBX_Recht.Items.Add(y); 
            }

            button8.Text = "delete";

            stat = 0;                           //status entziehen
        }

        private void Button5_Click(object sender, EventArgs e) //verleihen
        {
            Dbase brecht = new Dbase("Projektlabor", "root", "");
                                                                           //mögliche rechte anzeigen
            CMBX_Recht.Items.Clear();

            var bre = new List<string[]> { };
            bre = brecht.CommandSelectAsListFrom("MaschinenID", "zuweisung", " where iButtonID = \'" + TBX_IButt.Text + "\'");    //berrechtigungen des Ausgeählten IButtons anzeigen

            var equal = new List<string[]> { };
            equal = brecht.CommandSelectAsListFrom("MaschinenID","maschine","");

            for (int o = 0; o < equal.Count; o++)
            {
                string[] i = equal[o];
                for (int g = 0; g < bre.Count; g++)
                {
                    string[] h = bre[g];
                    if (i[0] == h[0])
                    {
                        break;
                    }
                    else
                    {
                        if (i[0] != h[0] && g == bre.Count - 1)
                        {
                            string y = i[0];
                            CMBX_Recht.Items.Add(y);
                        }
                    }
                }
                

            }

            stat = 1;                       //verleihen

            button8.Text = "set";
        }

        private void Button8_Click(object sender, EventArgs e)  //set bzw. delete
        {
           if(stat == 1)
            {
                Dbase ein = new Dbase("Projektlabor", "root", "");
                DateTime date = DateTime.Now;
                ein.CommandInsertInto("zuweisung", "iButtonID, MaschinenID, Datum", "\'" + TBX_IButt.Text + "\' , \'" + CMBX_Recht.SelectedItem.ToString() + "\', \'" + date.ToString("yyyy-MM-dd")+"\'"); // einfuegen
            }
            else
            {
                if(stat == 0)
                {
                    Dbase del = new Dbase("Projektlabor", "root", "");
                    del.CommandDelete("zuweisung", "WHERE iButtonID = \'" + TBX_IButt.Text + "\' AND MaschinenID = \'"+CMBX_Recht.SelectedItem.ToString()+"\'");
                }
            }
            
        }

        private void CMBX_Recht_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
