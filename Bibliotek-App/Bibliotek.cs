using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek_App
{
    public class Bibliotek
    {
        public List<Bok> böcker = new List<Bok>();
        public List<Lantagare> lantagare = new List<Lantagare>();

        public void RegistreraBok(string bokTitel, string författare)
        {
            Bok bok = new Bok(bokTitel, författare);
            böcker.Add(bok);
        }

        public void RegistreraLåntagare(string namn, string personnummer, string telefonNmr)
        {
            Lantagare lantagare = new Lantagare(namn, personnummer, telefonNmr);
            this.lantagare.Add(lantagare);
        }

        public void LånaBok(Lantagare lantagare, Bok bok)
        {
            lantagare.lånadeBöcker.Add($"{bok.bokTitel}");
            bok.lånestatus = true;
        }

        public void LämnaTillbakaBok(Lantagare lantagare, Bok bok)
        {
            lantagare.lånadeBöcker.Remove($"{bok.bokTitel}");
            bok.lånestatus = false;
        }

        public void Avreganv(Lantagare lantagare)
        {
            Program.bibliotek.lantagare.Remove(lantagare);
        }

        public void Avregistrerabok(Bok bok)
        {
            Program.bibliotek.böcker.Remove(bok);
        }
    }
}
