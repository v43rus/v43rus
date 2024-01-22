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
    public partial class RegistreraBok : Form
    {
        public RegistreraBok()
        {
            InitializeComponent();
            PopuleraBöcker();
        }

        private void RegistreraBok_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (titelFält.Text == "" || författarFält.Text == "")
            {
                MessageBox.Show($"Båda fälten måste fyllas i för att registrera en bok");
                return;
            }

            Program.bibliotek.RegistreraBok(titelFält.Text, författarFält.Text);
            MessageBox.Show($"Ny bok skapad - \"{titelFält.Text}\" skriven av {författarFält.Text}");
            titelFält.Clear();
            författarFält.Clear();
        }

        private void bakåtbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Huvudmeny newForm = new Huvudmeny();
            newForm.ShowDialog(this);
            this.Close();
        }

        private void PopuleraBöcker()
        {
            bokdropdn.Items.Clear();
            for (int i = 0; i < Program.bibliotek.böcker.Count(); i++)
            {
                bokdropdn.Items.Add(Program.bibliotek.böcker[i].bokTitel);
            }
            bokdropdn.Text = "Böcker";
        }

        private void avregistrerabok_Click(object sender, EventArgs e)
        {
            if (bokdropdn.SelectedItem == null)
                return;

            for (int i = 0; i < Program.bibliotek.böcker.Count(); i++)
            {
                if (bokdropdn.SelectedItem == Program.bibliotek.böcker[i].bokTitel)
                {
                    if (!Program.bibliotek.böcker[i].lånestatus)
                    {
                        MessageBox.Show($"{Program.bibliotek.böcker[i].bokTitel} har blivit borttagen.");
                        Program.bibliotek.Avregistrerabok(Program.bibliotek.böcker[i]);
                        PopuleraBöcker();
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"Du kan inte ta bort en bok som är utlånad.");
                        return;
                    }
                }
            }
        }
    }
}