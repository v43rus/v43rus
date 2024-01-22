using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotek_App
{
    public partial class HanteraAnvandare : Form
    {
        Lantagare valdAnvändare;

        public HanteraAnvandare()
        {
            InitializeComponent();
            PopuleraListor();
        }

        private void AnvandarLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.bibliotek.lantagare.Count(); i++)
            {
                if (Program.bibliotek.lantagare[i].namn == AnvandarLista.SelectedItem)
                {
                    valdAnvändare = Program.bibliotek.lantagare[i];
                }
            }

            Namn.Text = valdAnvändare.namn;
            Mobilnummer.Text = valdAnvändare.telefonNmr;
            Personnummer.Text = valdAnvändare.personnummer;

            InfoAnvandare.Clear();
            foreach (String s in valdAnvändare.lånadeBöcker)
            {
                InfoAnvandare.Text += $"{s} {Environment.NewLine}";
            }
        }

        private void NamnFalt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistreraAnvandarebtn_Click(object sender, EventArgs e)
        {
            if (NamnFalt.Text == "")
            {
                MessageBox.Show($"Vi behöver ett namn för att registrera en användare");
                return;
            }
            else if (PersonnummerFalt.Text.Length != 10 && PersonnummerFalt.Text.Length != 12)
            {
                MessageBox.Show($"Formatera ditt personnummer rätt (10 eller 12 siffror)!");
                return;
            }
            else if (MobilFalt.Text.Length != 10)
            {
                MessageBox.Show($"Ett mobilnr skall ha tio siffror (inga bindestreck)");
                return;
            }

            // JAG HADE FEL OKEJ, JAG VET. DU ÄR BÄST ERIK
            Program.bibliotek.RegistreraLåntagare(NamnFalt.Text, PersonnummerFalt.Text, MobilFalt.Text);
            MessageBox.Show($"Ny låntagare skapad - {NamnFalt.Text}");
            NamnFalt.Clear();
            MobilFalt.Clear();
            PersonnummerFalt.Clear();
            PopuleraListor();
        }

        private void bakåtbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Huvudmeny newForm = new Huvudmeny();
            newForm.ShowDialog(this);
            this.Close();
        }

        private void PopuleraListor()
        {
            AnvandarLista.Items.Clear();

            for (int i = 0; i < Program.bibliotek.lantagare.Count(); i++)
            {
                AnvandarLista.Items.Add(Program.bibliotek.lantagare[i].namn);
            }

            AnvandarLista.Text = "Användare";
        }

        private void Avregistreraanv_Click(object sender, EventArgs e)
        {

            if (AnvandarLista.SelectedItem == null)
                return;

            for (int i = 0; i < Program.bibliotek.lantagare.Count(); i++)
            {
                if (AnvandarLista.SelectedItem == Program.bibliotek.lantagare[i].namn)
                {
                    if (Program.bibliotek.lantagare[i].lånadeBöcker.Count == 0) {
                        MessageBox.Show($"{Program.bibliotek.lantagare[i].namn} har blivit borttagen.");
                        Program.bibliotek.Avreganv(Program.bibliotek.lantagare[i]);
                        Namn.Clear();
                        Personnummer.Clear();
                        Mobilnummer.Clear();
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"Användaren har lånade böcker.");
                        return;
                    }
                }
            }
            PopuleraListor();
        }
    }
}