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
    public partial class Lanabok : Form
    {
        

        public Lanabok()
        {
            InitializeComponent();
            PopuleraNamn();
            PopuleraBöcker();
        }

        private void användaredropdn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bokdropdn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PopuleraNamn()
        {
            användaredropdn.Items.Clear();
            for (int i = 0; i < Program.bibliotek.lantagare.Count(); i++)
            {
                användaredropdn.Items.Add(Program.bibliotek.lantagare[i].namn);
            }
        }

        private void PopuleraBöcker() { 
        bokdropdn.Items.Clear();
            for (int i = 0; i < Program.bibliotek.böcker.Count(); i++)
            {
                if (!Program.bibliotek.böcker[i].lånestatus)
                    bokdropdn.Items.Add(Program.bibliotek.böcker[i].bokTitel);
            }
            bokdropdn.Text = "Böcker";
        }


        private void lanabokBtn_Click(object sender, EventArgs e)
        {

            if (bokdropdn.SelectedItem == null)
                return;

            if (användaredropdn.SelectedItem == null)
                return;

            int bokIndex = 0;
            int lantagareIndex = 0;

            for (int i = 0; i < Program.bibliotek.böcker.Count(); i++)
            {
                if (bokdropdn.SelectedItem == Program.bibliotek.böcker[i].bokTitel)
                {
                    bokIndex = i;
                    break;
                }
            }
            for (int i = 0; i < Program.bibliotek.lantagare.Count(); i++)
            {
                if (användaredropdn.SelectedItem == Program.bibliotek.lantagare[i].namn)
                {
                    lantagareIndex = i;
                    break;
                }
            }

            Program.bibliotek.LånaBok(Program.bibliotek.lantagare[lantagareIndex], Program.bibliotek.böcker[bokIndex]);

            MessageBox.Show($"{Program.bibliotek.lantagare[lantagareIndex].namn} har lånat {Program.bibliotek.böcker[bokIndex].bokTitel}");
            PopuleraBöcker();
        }

        private void bakåtbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Huvudmeny newForm = new Huvudmeny();
            newForm.ShowDialog(this);
            this.Close();
        }
    }
}