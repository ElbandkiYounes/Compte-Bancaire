namespace Compte_Bancaire
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            crediter_value = new TextBox();
            debiter_value = new TextBox();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(393, 268);
            button1.Name = "button1";
            button1.Size = new Size(103, 29);
            button1.TabIndex = 0;
            button1.Text = "Description";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(502, 268);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Quiter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 52);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 2;
            label1.Text = "Numero Carte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 85);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 3;
            label2.Text = "Decouvert Max";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(200, 49);
            textBox2.Name = "textBox2";
            textBox2.Text = CompteCourant.DecouvertAutorise.ToString();
            textBox2.Size = new Size(230, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(200, 82);
            textBox1.Name = "textBox1";
            textBox1.Text = CompteCourant.NumeroCB.ToString();
            textBox1.Size = new Size(230, 27);
            textBox1.TabIndex = 7;
            // 
            // crediter_value
            // 
            crediter_value.Location = new Point(200, 115);
            crediter_value.Name = "crediter_value";
            crediter_value.Size = new Size(230, 27);
            crediter_value.TabIndex = 8;
            // 
            // debiter_value
            // 
            debiter_value.Location = new Point(200, 148);
            debiter_value.Name = "debiter_value";
            debiter_value.Size = new Size(230, 27);
            debiter_value.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(74, 115);
            button3.Name = "button3";
            button3.Size = new Size(120, 29);
            button3.TabIndex = 10;
            button3.Text = "Crediter";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(74, 150);
            button4.Name = "button4";
            button4.Size = new Size(120, 29);
            button4.TabIndex = 11;
            button4.Text = "Debiter";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 309);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(debiter_value);
            Controls.Add(crediter_value);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Compte Courant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox crediter_value;
        private TextBox debiter_value;
        private Button button3;
        private Button button4;

        // Data

        Client Client { get; set; }
        CompteCourant CompteCourant { get; set; }
    }
}