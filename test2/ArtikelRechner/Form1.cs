namespace ArtikelRechner {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void buttonNeueKalkulation_Click(object sender, EventArgs e) {
            this.textArtNr.Clear();
            this.textArtName.Clear();
            this.textMenge.Clear();
            this.textEinzelpreis.Clear();
            this.textGesamtPreis.Clear();
            this.textMwStSatz.Clear();
            this.textMwStEuro.Clear();
            this.textVerkPreis.Clear();
        }

        private void buttonKalkulieren_Click(object sender, EventArgs e) {

            // Art.Nr, Bez., Menge, Einzelpreis, (Gesamtpreis), Mwst-Satz, (MwSt Eur), (Verkaufspreis)

            string artName;
            double artNr, artMenge, artEinzelpreis, artGesamtpreis, artMwStSatz, artMwStEuro, artVerkaufspreis;

            if (double.TryParse(this.textArtNr.Text, out artNr)) {

                if (this.textArtName.Text != "") {

                    if (double.TryParse(this.textMenge.Text, out artMenge)) {

                        if (double.TryParse(this.textEinzelpreis.Text, out artEinzelpreis)) {

                            // Rechne Gesamtpreis
                            artGesamtpreis = artMenge * artEinzelpreis;
                            this.textGesamtPreis.Text = artGesamtpreis.ToString("N2") + " €";

                            // MwSt Satz ausgefüllt?
                            if (double.TryParse(this.textMwStSatz.Text, out artMwStSatz)) {

                                // MwSt Gesamt
                                artMwStEuro = ((artMwStSatz / 100) * artGesamtpreis);

                                // Brutto
                                artVerkaufspreis = artGesamtpreis + artMwStEuro;

                                // Felder füllen
                                this.textMwStEuro.Text = artMwStEuro.ToString("N2") + " €";
                                this.textVerkPreis.Text = artVerkaufspreis.ToString("N2") + " €";

                            }
                            else {
                                textMwStSatz.Text = null;
                                MessageBox.Show("MwSt.-Satz ist leer.");
                                this.textMwStSatz.Focus();
                            }

                        }
                        else {
                            textEinzelpreis.Text = null;
                            MessageBox.Show("Einzelpreis ist leer.");
                            this.textEinzelpreis.Focus();
                        }

                    }
                    else {
                        textMenge.Text = null;
                        MessageBox.Show("Artikel-Menge ist leer.");
                        this.textMenge.Focus();
                    }

                }
                else {
                    textArtName.Text = "";
                    MessageBox.Show("Artikel-Name. ist leer.");
                    this.textArtName.Focus();
                }

            }
            else {
                this.textArtNr.Text = null;
                MessageBox.Show("Artikel-Nr. ist leer.");
                this.textArtNr.Focus();
            }

            // Validierung der Textboxen
            // Felder müssen in einer groupBox sein!
            //foreach (var control in groupBox.Controls) {
            //    var textBox = control as TextBox;
            //    if (string.IsNullOrWhiteSpace(textBox.Text)) {
            //        MessageBox.Show("Bitte füllen Sie alle Felder aus!", "Fehler",
            //               MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        textBox.Focus();
            //        break;
            //    }
            //}

        }

            private void buttonBeenden_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show(
                "Beenden?",
                "Art.-Rechner",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes) {
                Application.Exit();
            }

        }

    }

}