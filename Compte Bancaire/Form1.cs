namespace Compte_Bancaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_compte_courant_Click(object sender, EventArgs e)
        {
            Form compte_Courant = new Form3(this.CompteCourant, this.Client, this);
            compte_Courant.Show();
        }

        private void button_compte_epargne_Click(object sender, EventArgs e)
        {
            Form compte_Epargne = new Form2(this.CompteEpargne, this.Client, this);
            compte_Epargne.Show();
        }

        public void refrechSolde()
        {
            textBox3.Text = CompteCourant.Solde.ToString();
        }
    }
}
