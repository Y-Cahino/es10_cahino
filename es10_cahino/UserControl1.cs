using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es10_cahino
{
    public partial class UserControl1: UserControl
    {
        private Articolo[] articoli;
        private ListBox Ricevuta;
        public UserControl1()
        {
            InitializeComponent();
            articoli = new Articolo[0];
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            Ricevuta.Items.Clear();
            bool hasCard=chkCard.Checked;
            foreach(var articolo in articoli)
            {
                articolo.sconto_pr(hasCard);
                //mostra i dettagli sulla listbox
                Ricevuta.Items.Add($"{articolo.N} - Prezzo: {articolo.Pr}");
            }
            double totale = 0;
            foreach(var articolo in articoli)
            {
                totale += articolo.Pr;
            }
            Ricevuta.Items.Add($"Totale: {totale}");
        }
        private void add_Click(object sender, EventArgs e)
        {
            string code = code1.Text;
            string n = desc.Text;
            double pr = double.Parse(price.Text);
            Articolo newArticoli;
            if(Convert.ToDouble(code) < 1000)
            {

            }
        }
            private void chkCard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void code_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
