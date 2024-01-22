using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotek_App
{
    public partial class LamnaTillbakaBok : Form
    {
        Lantagare valdAnvändare;

        public LamnaTillbakaBok()
        {
            InitializeComponent();
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
            användaredropdn.Items.Clear();
            for (int i = 0; i < Program.bibliotek.lantagare.Count(); i++)
            {
                användaredropdn.Items.Add(Program.bibliotek.lantagare[i].namn);
            }
        }

        private void återlämning_Click(object sender, EventArgs e)
        {
            if (bokdropdn.SelectedItem == null)
                return;

            if (användaredropdn.SelectedItem == null)
                return;

            int bokIndex = 0;
            int lantagareIndex = 0;

            for (int i = 0; i < Program.bibliotek.böcker.Count(); i++)
            {

                Debug.WriteLine($"\"{bokdropdn.SelectedItem}\"");

                if (bokdropdn.SelectedItem == Program.bibliotek.böcker[i].bokTitel)
                {
                    bokIndex = i;
                    Program.bibliotek.LämnaTillbakaBok(valdAnvändare, Program.bibliotek.böcker[bokIndex]);
                }
            }
            PopuleraBöcker();
            MessageBox.Show($"{Program.bibliotek.lantagare[lantagareIndex].namn} har lämnat tillbaks {Program.bibliotek.böcker[bokIndex].bokTitel}");
        }

        private void användaredropdn_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.bibliotek.lantagare.Count(); i++)
            {
                if (Program.bibliotek.lantagare[i].namn == användaredropdn.SelectedItem)
                {
                    valdAnvändare = Program.bibliotek.lantagare[i];
                }
            }
            PopuleraBöcker();
        }

        private void PopuleraBöcker()
        {
            bokdropdn.Items.Clear();
            bokdropdn.Text = "Böcker";
            for (int i = 0; i < valdAnvändare.lånadeBöcker.Count(); i++)
            {
                bokdropdn.Items.Add(valdAnvändare.lånadeBöcker[i]);
            }
        }
    }
}
