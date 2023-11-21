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
        }

        private void chkCard_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
