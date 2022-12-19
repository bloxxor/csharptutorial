namespace ArtikelRechner {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelArtNr = new System.Windows.Forms.Label();
            this.textArtNr = new System.Windows.Forms.TextBox();
            this.labelArtName = new System.Windows.Forms.Label();
            this.textArtName = new System.Windows.Forms.TextBox();
            this.labelMenge = new System.Windows.Forms.Label();
            this.textMenge = new System.Windows.Forms.TextBox();
            this.labelPreis = new System.Windows.Forms.Label();
            this.textEinzelpreis = new System.Windows.Forms.TextBox();
            this.labelGesamtPreis = new System.Windows.Forms.Label();
            this.labelMwStSatz = new System.Windows.Forms.Label();
            this.labelMwStEuro = new System.Windows.Forms.Label();
            this.labelVerkPreis = new System.Windows.Forms.Label();
            this.textGesamtPreis = new System.Windows.Forms.TextBox();
            this.textMwStSatz = new System.Windows.Forms.TextBox();
            this.textMwStEuro = new System.Windows.Forms.TextBox();
            this.textVerkPreis = new System.Windows.Forms.TextBox();
            this.buttonKalkulieren = new System.Windows.Forms.Button();
            this.buttonNeueKalkulation = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelArtNr
            // 
            this.labelArtNr.AutoSize = true;
            this.labelArtNr.Location = new System.Drawing.Point(33, 36);
            this.labelArtNr.Name = "labelArtNr";
            this.labelArtNr.Size = new System.Drawing.Size(65, 15);
            this.labelArtNr.TabIndex = 0;
            this.labelArtNr.Text = "Artikel-Nr.:";
            // 
            // textArtNr
            // 
            this.textArtNr.Location = new System.Drawing.Point(137, 33);
            this.textArtNr.Name = "textArtNr";
            this.textArtNr.Size = new System.Drawing.Size(100, 23);
            this.textArtNr.TabIndex = 0;
            // 
            // labelArtName
            // 
            this.labelArtName.AutoSize = true;
            this.labelArtName.Location = new System.Drawing.Point(33, 73);
            this.labelArtName.Name = "labelArtName";
            this.labelArtName.Size = new System.Drawing.Size(81, 15);
            this.labelArtName.TabIndex = 0;
            this.labelArtName.Text = "Artikel-Name:";
            // 
            // textArtName
            // 
            this.textArtName.Location = new System.Drawing.Point(137, 70);
            this.textArtName.Name = "textArtName";
            this.textArtName.Size = new System.Drawing.Size(100, 23);
            this.textArtName.TabIndex = 1;
            // 
            // labelMenge
            // 
            this.labelMenge.AutoSize = true;
            this.labelMenge.Location = new System.Drawing.Point(33, 115);
            this.labelMenge.Name = "labelMenge";
            this.labelMenge.Size = new System.Drawing.Size(47, 15);
            this.labelMenge.TabIndex = 0;
            this.labelMenge.Text = "Menge:";
            // 
            // textMenge
            // 
            this.textMenge.Location = new System.Drawing.Point(137, 112);
            this.textMenge.Name = "textMenge";
            this.textMenge.Size = new System.Drawing.Size(100, 23);
            this.textMenge.TabIndex = 2;
            // 
            // labelPreis
            // 
            this.labelPreis.AutoSize = true;
            this.labelPreis.Location = new System.Drawing.Point(33, 161);
            this.labelPreis.Name = "labelPreis";
            this.labelPreis.Size = new System.Drawing.Size(62, 15);
            this.labelPreis.TabIndex = 0;
            this.labelPreis.Text = "Einzelpreis";
            // 
            // textEinzelpreis
            // 
            this.textEinzelpreis.Location = new System.Drawing.Point(137, 158);
            this.textEinzelpreis.Name = "textEinzelpreis";
            this.textEinzelpreis.Size = new System.Drawing.Size(100, 23);
            this.textEinzelpreis.TabIndex = 3;
            // 
            // labelGesamtPreis
            // 
            this.labelGesamtPreis.AutoSize = true;
            this.labelGesamtPreis.Location = new System.Drawing.Point(33, 207);
            this.labelGesamtPreis.Name = "labelGesamtPreis";
            this.labelGesamtPreis.Size = new System.Drawing.Size(75, 15);
            this.labelGesamtPreis.TabIndex = 0;
            this.labelGesamtPreis.Text = "Gesamtpreis:";
            // 
            // labelMwStSatz
            // 
            this.labelMwStSatz.AutoSize = true;
            this.labelMwStSatz.Location = new System.Drawing.Point(33, 244);
            this.labelMwStSatz.Name = "labelMwStSatz";
            this.labelMwStSatz.Size = new System.Drawing.Size(66, 15);
            this.labelMwStSatz.TabIndex = 0;
            this.labelMwStSatz.Text = "MwSt.-Satz";
            // 
            // labelMwStEuro
            // 
            this.labelMwStEuro.AutoSize = true;
            this.labelMwStEuro.Location = new System.Drawing.Point(33, 286);
            this.labelMwStEuro.Name = "labelMwStEuro";
            this.labelMwStEuro.Size = new System.Drawing.Size(69, 15);
            this.labelMwStEuro.TabIndex = 0;
            this.labelMwStEuro.Text = "MwSt.-Euro";
            // 
            // labelVerkPreis
            // 
            this.labelVerkPreis.AutoSize = true;
            this.labelVerkPreis.Location = new System.Drawing.Point(33, 332);
            this.labelVerkPreis.Name = "labelVerkPreis";
            this.labelVerkPreis.Size = new System.Drawing.Size(79, 15);
            this.labelVerkPreis.TabIndex = 0;
            this.labelVerkPreis.Text = "Verkaufspreis:";
            // 
            // textGesamtPreis
            // 
            this.textGesamtPreis.Enabled = false;
            this.textGesamtPreis.Location = new System.Drawing.Point(137, 204);
            this.textGesamtPreis.Name = "textGesamtPreis";
            this.textGesamtPreis.Size = new System.Drawing.Size(100, 23);
            this.textGesamtPreis.TabIndex = 4;
            // 
            // textMwStSatz
            // 
            this.textMwStSatz.Location = new System.Drawing.Point(137, 241);
            this.textMwStSatz.Name = "textMwStSatz";
            this.textMwStSatz.Size = new System.Drawing.Size(100, 23);
            this.textMwStSatz.TabIndex = 5;
            // 
            // textMwStEuro
            // 
            this.textMwStEuro.Enabled = false;
            this.textMwStEuro.Location = new System.Drawing.Point(137, 283);
            this.textMwStEuro.Name = "textMwStEuro";
            this.textMwStEuro.Size = new System.Drawing.Size(100, 23);
            this.textMwStEuro.TabIndex = 6;
            // 
            // textVerkPreis
            // 
            this.textVerkPreis.Enabled = false;
            this.textVerkPreis.Location = new System.Drawing.Point(137, 329);
            this.textVerkPreis.Name = "textVerkPreis";
            this.textVerkPreis.Size = new System.Drawing.Size(100, 23);
            this.textVerkPreis.TabIndex = 7;
            // 
            // buttonKalkulieren
            // 
            this.buttonKalkulieren.Location = new System.Drawing.Point(273, 249);
            this.buttonKalkulieren.Name = "buttonKalkulieren";
            this.buttonKalkulieren.Size = new System.Drawing.Size(131, 23);
            this.buttonKalkulieren.TabIndex = 8;
            this.buttonKalkulieren.Text = "Kalkulieren";
            this.buttonKalkulieren.UseVisualStyleBackColor = true;
            this.buttonKalkulieren.Click += new System.EventHandler(this.buttonKalkulieren_Click);
            // 
            // buttonNeueKalkulation
            // 
            this.buttonNeueKalkulation.Location = new System.Drawing.Point(273, 289);
            this.buttonNeueKalkulation.Name = "buttonNeueKalkulation";
            this.buttonNeueKalkulation.Size = new System.Drawing.Size(131, 23);
            this.buttonNeueKalkulation.TabIndex = 9;
            this.buttonNeueKalkulation.Text = "Neue Kalkulation";
            this.buttonNeueKalkulation.UseVisualStyleBackColor = true;
            this.buttonNeueKalkulation.Click += new System.EventHandler(this.buttonNeueKalkulation_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(273, 329);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(131, 23);
            this.buttonBeenden.TabIndex = 10;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 409);
            this.Controls.Add(this.textArtNr);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonNeueKalkulation);
            this.Controls.Add(this.buttonKalkulieren);
            this.Controls.Add(this.textVerkPreis);
            this.Controls.Add(this.textEinzelpreis);
            this.Controls.Add(this.textMwStEuro);
            this.Controls.Add(this.textMenge);
            this.Controls.Add(this.textMwStSatz);
            this.Controls.Add(this.textArtName);
            this.Controls.Add(this.textGesamtPreis);
            this.Controls.Add(this.labelVerkPreis);
            this.Controls.Add(this.labelMwStEuro);
            this.Controls.Add(this.labelPreis);
            this.Controls.Add(this.labelMwStSatz);
            this.Controls.Add(this.labelMenge);
            this.Controls.Add(this.labelGesamtPreis);
            this.Controls.Add(this.labelArtName);
            this.Controls.Add(this.labelArtNr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelArtNr;
        private TextBox textArtNr;
        private Label labelArtName;
        private TextBox textArtName;
        private Label labelMenge;
        private TextBox textMenge;
        private Label labelPreis;
        private TextBox textEinzelpreis;
        private Label labelGesamtPreis;
        private Label labelMwStSatz;
        private Label labelMwStEuro;
        private Label labelVerkPreis;
        private TextBox textGesamtPreis;
        private TextBox textMwStSatz;
        private TextBox textMwStEuro;
        private TextBox textVerkPreis;
        private Button buttonKalkulieren;
        private Button buttonNeueKalkulation;
        private Button buttonBeenden;
    }
}