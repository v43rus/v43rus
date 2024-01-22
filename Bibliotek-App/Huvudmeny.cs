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
    public partial class Huvudmeny : Form
    {

        public Huvudmeny()
        {
            InitializeComponent();
        }


        private void RegistreraBok_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistreraBok newForm = new RegistreraBok();
            newForm.ShowDialog(this);
            this.Close();
        }

        private void LånaBok_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lanabok newForm = new Lanabok();
            newForm.ShowDialog(this);
            this.Close();
        }
        
        private void HanteraAnvändare_Click(object sender, EventArgs e)
        {
            this.Hide();
            HanteraAnvandare newForm = new HanteraAnvandare();
            newForm.ShowDialog(this);
            this.Close();
        }

        private void LämnaTillbakaBok_Click(object sender, EventArgs e)
        {
            this.Hide();
            LamnaTillbakaBok newForm = new LamnaTillbakaBok();
            newForm.ShowDialog(this);
            this.Close();
        }
    }
}