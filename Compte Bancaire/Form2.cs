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
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(CompteEpargne compteEpargne, Client cilent, Form1 form1 )
        {
            this.CompteEpargne = compteEpargne;
            this.Client = cilent;
            this.form1 = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("un compte courant est un compte bancaire qui permet à son titulaire de déposer et de retirer de l'argent à tout moment.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.crediter_value.Text))
            {
                try
                {
                    this.CompteEpargne.Crediter(double.Parse(this.crediter_value.Text));
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

            if (!string.IsNullOrEmpty(this.debiter_value.Text))
            {
                try
                {
                    if (this.CompteEpargne.Debiter(double.Parse(this.debiter_value.Text)))
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
