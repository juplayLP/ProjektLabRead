using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using WinDruckauftrag;

namespace ProjektLabRead
{
    class Login
    {
        Dbase db =new Dbase("Projektlabor","root","");
        public Login(string user, string Pass)
        {

        }

        public Login(string rootkey)
        {

        }
    }
}
