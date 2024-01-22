using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotek_App
{
    internal static class Program
    {
        public static Bibliotek bibliotek = new Bibliotek();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // DEFAULT BÖCKER
            bibliotek.böcker.Add(new Bok("Hypnotisören", "Lars Kepler"));
            bibliotek.böcker.Add(new Bok("WoW Game Guide", "Onyxia"));
            bibliotek.böcker.Add(new Bok("Exploring the world of Lucid Dreaming", "Stephen LaBerge"));
            // DEFAULT LÅNETAGARE
            bibliotek.lantagare.Add(new Lantagare("Erik Andersson", "0403145616", "076-8919556"));
            bibliotek.lantagare.Add(new Lantagare("Rasmus Misikangas", "83122450326", "078-5645123"));
            bibliotek.lantagare.Add(new Lantagare("Leonard Jensen", "9110231111", "076-8455689"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Huvudmeny());
        }
    }
}