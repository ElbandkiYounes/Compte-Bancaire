namespace Compte_Bancaire
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        Client Client { get; set; }
        CompteCourant CompteCourant { get; set; }
        CompteEpargne CompteEpargne { get; set; }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Client = new Client(0000, "EL BANDKI", "YOUNES");
            CompteCourant = new CompteCourant(Client, 100000, "MAD", 2000, 1111);
            CompteEpargne = new CompteEpargne(Client, 200000, "MAD", 4000);
            button_compte_courant = new Button();
            button_compte_epargne = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button_compte_courant
            // 
            button_compte_courant.Location = new Point(220, 268);
            button_compte_courant.Name = "button_compte_courant";
            button_compte_courant.Size = new Size(180, 29);
            button_compte_courant.TabIndex = 1;
            button_compte_courant.Text = "Compte Courant";
            button_compte_courant.UseVisualStyleBackColor = true;
            button_compte_courant.Click += button_compte_courant_Click;
            // 
            // button_compte_epargne
            // 
            button_compte_epargne.Location = new Point(415, 268);
            button_compte_epargne.Name = "button_compte_epargne";
            button_compte_epargne.Size = new Size(180, 29);
            button_compte_epargne.TabIndex = 0;
            button_compte_epargne.Text = "Compte Epargne";
            button_compte_epargne.UseVisualStyleBackColor = true;
            button_compte_epargne.Click += button_compte_epargne_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 61);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Nom ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 99);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Prenom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 141);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 4;
            label3.Text = "Solde ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 187);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 5;
            label4.Text = "Devise ";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(157, 58);
            textBox1.Name = "textBox1";
            textBox1.Text = Client.Nom;
            textBox1.Size = new Size(212, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(157, 96);
            textBox2.Name = "textBox2";
            textBox2.Text = Client.Prenom;
            textBox2.Size = new Size(212, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(157, 134);
            textBox3.Name = "textBox3";
            textBox3.Text = CompteCourant.Solde.ToString();
            textBox3.Size = new Size(212, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(157, 180);
            textBox4.Name = "textBox4";
            textBox4.Text = CompteCourant.Devise;
            textBox4.Size = new Size(212, 27);
            textBox4.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 309);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_compte_epargne);
            Controls.Add(button_compte_courant);
            Name = "Form1";
            Text = "Compte Boncaire";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_compte_courant;
        private Button button_compte_epargne;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
