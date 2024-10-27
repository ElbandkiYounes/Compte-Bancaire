using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compte_Bancaire
{
    public partial class Form3 : Form
    {

        private Form1 form1;

        public Form3(CompteCourant compteCourant, Client client,Form1 form1)
        {
            this.CompteCourant = compteCourant;
            this.Client = client;
            this.form1 = form1;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("un compte d'épargne sert à stocker des fonds avec des intérêts limités et un accès moins fréquent.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.crediter_value.Text))
            {
                try
                {
                    this.CompteCourant.Crediter(double.Parse(this.crediter_value.Text));
                    MessageBox.Show($"Opération effectuée avec succès : {this.crediter_value.Text} MAD Est Crediter");
                    form1.refrechSolde();
                }
                catch
                {
                    MessageBox.Show("Operation echouee");
                }

            }
            else
            {
                MessageBox.Show("Entree Un Montant");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if(!string.IsNullOrEmpty(this.debiter_value.Text))
            {
                try
                {
                    if (this.CompteCourant.Debiter(double.Parse(this.debiter_value.Text)))
                    {
                        MessageBox.Show($"Opération effectuée avec succès : {this.debiter_value.Text} MAD Est Debiter");
                        form1.refrechSolde();
                    }
                    else
                    {
                        MessageBox.Show("Operation echouee");
                    }

                }
                catch
                {
                    MessageBox.Show("Operation echouee");
                }
                
            }
            else
            {
                MessageBox.Show("Entree Un Montant");
            }

        }
    }
}
