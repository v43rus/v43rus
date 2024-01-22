using Bibliotek_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek_App
{
    public class Lantagare
    {
        public string namn = " ";
        public string personnummer = " ";
        public string telefonNmr = " ";
        public List<string> lånadeBöcker = new List<string>();

        public Lantagare(string namn, string personnummer, string telefonNmr)
        {
            this.namn = namn;
            this.personnummer = personnummer;
            this.telefonNmr = telefonNmr;
        }
    }
}