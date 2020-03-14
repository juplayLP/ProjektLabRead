using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WinDruckauftrag;

namespace ProjektLabRead
{
    class Login
    {
        Dbase db =new Dbase("Projektlabor","root","");
        public Login(string user, string Pass)
        {
            var allowedlogins = db.CommandSelectAsListFrom("Benutzername, Passwort", "user", "WHERE `Keymember` = 1");
            foreach (var login in allowedlogins)
            {
                if (user == login[0] && Pass == login[1])
                {
                    Verwaltung vw = new Verwaltung(1);
                    vw.Show();
                }
            }

        }

        public Login(string rootkey)
        {
            var allowedlogins = db.CommandSelectAsListFrom("IButtonID", "user", "WHERE `Keymember` = 1");
            foreach (var login in allowedlogins)
            {
                if (rootkey == login[0])
                {
                    Verwaltung vw = new Verwaltung(0);
                    vw.Show();

                }
            }
        }
    }
}
