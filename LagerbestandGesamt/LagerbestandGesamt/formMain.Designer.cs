namespace LagerbestandGesamt {
    partial class lagerstandGesamt {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.labelLagerbestand = new System.Windows.Forms.Label();
            this.listViewArtikel = new System.Windows.Forms.ListView();
            this.columnHeaderArtikelNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArtikelName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArtikelEinzelpreis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArtikelLagerstand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArtikelLagerwert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxAuswertung = new System.Windows.Forms.GroupBox();
            this.textBoxLagerwertGesamt = new System.Windows.Forms.TextBox();
            this.labelLagerwertGesamt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxArtikelLagerstand = new System.Windows.Forms.TextBox();
            this.labelLagerstand = new System.Windows.Forms.Label();
            this.textBoxArtikelEinzelpreis = new System.Windows.Forms.TextBox();
            this.labelEinzelpreis = new System.Windows.Forms.Label();
            this.textBoxArtikelName = new System.Windows.Forms.TextBox();
            this.labelArtikelName = new System.Windows.Forms.Label();
            this.textBoxArtikelNummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEinfuegen = new System.Windows.Forms.Button();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonUnsortiert = new System.Windows.Forms.RadioButton();
            this.groupBoxAuswertung.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLagerbestand
            // 
            this.labelLagerbestand.AutoSize = true;
            this.labelLagerbestand.Location = new System.Drawing.Point(12, 9);
            this.labelLagerbestand.Name = "labelLagerbestand";
            this.labelLagerbestand.Size = new System.Drawing.Size(72, 13);
            this.labelLagerbestand.TabIndex = 0;
            this.labelLagerbestand.Text = "Lagerbestand";
            // 
            // listViewArtikel
            // 
            this.listViewArtikel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderArtikelNr,
            this.columnHeaderArtikelName,
            this.columnHeaderArtikelEinzelpreis,
            this.columnHeaderArtikelLagerstand,
            this.columnHeaderArtikelLagerwert});
            this.listViewArtikel.HideSelection = false;
            this.listViewArtikel.Location = new System.Drawing.Point(12, 25);
            this.listViewArtikel.Name = "listViewArtikel";
            this.listViewArtikel.Size = new System.Drawing.Size(773, 198);
            this.listViewArtikel.TabIndex = 1;
            this.listViewArtikel.UseCompatibleStateImageBehavior = false;
            this.listViewArtikel.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderArtikelNr
            // 
            this.columnHeaderArtikelNr.Text = "Artikel-Nr.";
            // 
            // columnHeaderArtikelEinzelpreis
            // 
            this.columnHeaderArtikelEinzelpreis.Text = "Einzelpreis";
            // 
            // columnHeaderArtikelLagerstand
            // 
            this.columnHeaderArtikelLagerstand.Text = "Lagerstand";
            // 
            // columnHeaderArtikelLagerwert
            // 
            this.columnHeaderArtikelLagerwert.Text = "Lagerwert";
            // 
            // groupBoxAuswertung
            // 
            this.groupBoxAuswertung.Controls.Add(this.textBoxLagerwertGesamt);
            this.groupBoxAuswertung.Controls.Add(this.labelLagerwertGesamt);
            this.groupBoxAuswertung.Location = new System.Drawing.Point(15, 229);
            this.groupBoxAuswertung.Name = "groupBoxAuswertung";
            this.groupBoxAuswertung.Size = new System.Drawing.Size(223, 71);
            this.groupBoxAuswertung.TabIndex = 2;
            this.groupBoxAuswertung.TabStop = false;
            this.groupBoxAuswertung.Text = "Auswertung";
            // 
            // textBoxLagerwertGesamt
            // 
            this.textBoxLagerwertGesamt.Location = new System.Drawing.Point(103, 29);
            this.textBoxLagerwertGesamt.Name = "textBoxLagerwertGesamt";
            this.textBoxLagerwertGesamt.ReadOnly = true;
            this.textBoxLagerwertGesamt.Size = new System.Drawing.Size(114, 20);
            this.textBoxLagerwertGesamt.TabIndex = 1;
            // 
            // labelLagerwertGesamt
            // 
            this.labelLagerwertGesamt.AutoSize = true;
            this.labelLagerwertGesamt.Location = new System.Drawing.Point(6, 32);
            this.labelLagerwertGesamt.Name = "labelLagerwertGesamt";
            this.labelLagerwertGesamt.Size = new System.Drawing.Size(91, 13);
            this.labelLagerwertGesamt.TabIndex = 0;
            this.labelLagerwertGesamt.Text = "Lagerwert gesamt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxArtikelLagerstand);
            this.groupBox1.Controls.Add(this.labelLagerstand);
            this.groupBox1.Controls.Add(this.textBoxArtikelEinzelpreis);
            this.groupBox1.Controls.Add(this.labelEinzelpreis);
            this.groupBox1.Controls.Add(this.textBoxArtikelName);
            this.groupBox1.Controls.Add(this.labelArtikelName);
            this.groupBox1.Controls.Add(this.textBoxArtikelNummer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(244, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 209);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auswertung";
            // 
            // textBoxArtikelLagerstand
            // 
            this.textBoxArtikelLagerstand.Location = new System.Drawing.Point(125, 107);
            this.textBoxArtikelLagerstand.Name = "textBoxArtikelLagerstand";
            this.textBoxArtikelLagerstand.Size = new System.Drawing.Size(140, 20);
            this.textBoxArtikelLagerstand.TabIndex = 1;
            // 
            // labelLagerstand
            // 
            this.labelLagerstand.AutoSize = true;
            this.labelLagerstand.Location = new System.Drawing.Point(57, 110);
            this.labelLagerstand.Name = "labelLagerstand";
            this.labelLagerstand.Size = new System.Drawing.Size(63, 13);
            this.labelLagerstand.TabIndex = 0;
            this.labelLagerstand.Text = "Lagerstand:";
            this.labelLagerstand.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxArtikelEinzelpreis
            // 
            this.textBoxArtikelEinzelpreis.Location = new System.Drawing.Point(125, 81);
            this.textBoxArtikelEinzelpreis.Name = "textBoxArtikelEinzelpreis";
            this.textBoxArtikelEinzelpreis.Size = new System.Drawing.Size(140, 20);
            this.textBoxArtikelEinzelpreis.TabIndex = 1;
            // 
            // labelEinzelpreis
            // 
            this.labelEinzelpreis.AutoSize = true;
            this.labelEinzelpreis.Location = new System.Drawing.Point(59, 84);
            this.labelEinzelpreis.Name = "labelEinzelpreis";
            this.labelEinzelpreis.Size = new System.Drawing.Size(60, 13);
            this.labelEinzelpreis.TabIndex = 0;
            this.labelEinzelpreis.Text = "Einzelpreis:";
            this.labelEinzelpreis.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxArtikelName
            // 
            this.textBoxArtikelName.Location = new System.Drawing.Point(125, 55);
            this.textBoxArtikelName.Name = "textBoxArtikelName";
            this.textBoxArtikelName.Size = new System.Drawing.Size(140, 20);
            this.textBoxArtikelName.TabIndex = 1;
            // 
            // labelArtikelName
            // 
            this.labelArtikelName.AutoSize = true;
            this.labelArtikelName.Location = new System.Drawing.Point(49, 58);
            this.labelArtikelName.Name = "labelArtikelName";
            this.labelArtikelName.Size = new System.Drawing.Size(70, 13);
            this.labelArtikelName.TabIndex = 0;
            this.labelArtikelName.Text = "Artikel Name:";
            this.labelArtikelName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxArtikelNummer
            // 
            this.textBoxArtikelNummer.Location = new System.Drawing.Point(125, 29);
            this.textBoxArtikelNummer.Name = "textBoxArtikelNummer";
            this.textBoxArtikelNummer.Size = new System.Drawing.Size(140, 20);
            this.textBoxArtikelNummer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artikel-Nr.:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonEinfuegen
            // 
            this.buttonEinfuegen.Location = new System.Drawing.Point(530, 229);
            this.buttonEinfuegen.Name = "buttonEinfuegen";
            this.buttonEinfuegen.Size = new System.Drawing.Size(258, 209);
            this.buttonEinfuegen.TabIndex = 3;
            this.buttonEinfuegen.Text = "Einfügen";
            this.buttonEinfuegen.UseVisualStyleBackColor = true;
            this.buttonEinfuegen.Click += new System.EventHandler(this.buttonEinfuegen_Click);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonUnsortiert);
            this.groupBox2.Location = new System.Drawing.Point(15, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 128);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sortierung";
            // 
            // radioButtonUnsortiert
            // 
            this.radioButtonUnsortiert.AutoSize = true;
            this.radioButtonUnsortiert.Location = new System.Drawing.Point(9, 28);
            this.radioButtonUnsortiert.Name = "radioButtonUnsortiert";
            this.radioButtonUnsortiert.Size = new System.Drawing.Size(70, 17);
            this.radioButtonUnsortiert.TabIndex = 0;
            this.radioButtonUnsortiert.TabStop = true;
            this.radioButtonUnsortiert.Text = "Unsortiert";
            this.radioButtonUnsortiert.UseVisualStyleBackColor = true;
            // 
            // lagerstandGesamt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonEinfuegen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxAuswertung);
            this.Controls.Add(this.listViewArtikel);
            this.Controls.Add(this.labelLagerbestand);
            this.Name = "lagerstandGesamt";
            this.Text = "Lagerauswertung";
            this.groupBoxAuswertung.ResumeLayout(false);
            this.groupBoxAuswertung.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLagerbestand;
        private System.Windows.Forms.ListView listViewArtikel;
        private System.Windows.Forms.GroupBox groupBoxAuswertung;
        private System.Windows.Forms.TextBox textBoxLagerwertGesamt;
        private System.Windows.Forms.Label labelLagerwertGesamt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxArtikelLagerstand;
        private System.Windows.Forms.Label labelLagerstand;
        private System.Windows.Forms.TextBox textBoxArtikelEinzelpreis;
        private System.Windows.Forms.Label labelEinzelpreis;
        private System.Windows.Forms.TextBox textBoxArtikelName;
        private System.Windows.Forms.Label labelArtikelName;
        private System.Windows.Forms.TextBox textBoxArtikelNummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEinfuegen;
        private System.Windows.Forms.ColumnHeader columnHeaderArtikelNr;
        private System.Windows.Forms.ColumnHeader columnHeaderArtikelName;
        private System.Windows.Forms.ColumnHeader columnHeaderArtikelEinzelpreis;
        private System.Windows.Forms.ColumnHeader columnHeaderArtikelLagerstand;
        private System.Windows.Forms.ColumnHeader columnHeaderArtikelLagerwert;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonUnsortiert;
    }
}

