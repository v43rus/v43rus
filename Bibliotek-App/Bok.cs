using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek_App
{
    public class Bok
    {
        public string bokTitel;
        public string författare;
        public string låntagare = " ";
        public bool lånestatus = false;

        public Bok(string bokTitel, string författare)
        {
            this.bokTitel = bokTitel;
            this.författare = författare;
        }
    }
}
