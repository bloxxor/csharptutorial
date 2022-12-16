using System;
using System.Collections;
using System.Windows.Forms;

namespace LagerbestandGesamt {
    public partial class lagerstandGesamt : Form {

        private ArrayList listeEingabe;
        public lagerstandGesamt() {
            InitializeComponent();
            this.listeEingabe = new ArrayList();
        }

        private void buttonEinfuegen_Click(object sender, EventArgs e) {

            Artikel artikel = new Artikel(
                Int32.Parse(this.textBoxArtikelNummer.Text),
                this.textBoxArtikelName.Text,
                Int32.Parse(this.textBoxArtikelEinzelpreis.Text),
                Int32.Parse(this.textBoxArtikelLagerstand.Text)
            );

            this.listeEingabe.Add(artikel);

            AnzeigeListe(this.listeEingabe);

            this.textBoxArtikelNummer.Clear();
            this.textBoxArtikelName.Clear();
            this.textBoxArtikelEinzelpreis.Clear();
            this.textBoxArtikelLagerstand.Clear();

        }

        private void AnzeigeListe(ArrayList liste) {

            // Alte Elemente löschen
            while (this.listViewArtikel.Items.Count > 0) {
                this.listViewArtikel.Items.RemoveAt(0);
            }

            double artikelLagerwertGesamt = 0.0;
            double lagerwertGesamt = 0.0;

            foreach (Artikel artikel in liste) {

                ListViewItem item = new ListViewItem();

                item.Text = artikel.id.ToString();
                item.SubItems.Add(artikel.artikelNr.ToString());
                item.SubItems.Add(artikel.artikelName.ToString());
                item.SubItems.Add(artikel.artikelPreis.ToString());
                item.SubItems.Add(artikel.lagerbestand.ToString());

                artikelLagerwertGesamt = artikel.artikelPreis * artikel.lagerbestand;
                item.SubItems.Add(artikelLagerwertGesamt.ToString());

                this.listViewArtikel.Items.Add(item);

                lagerwertGesamt += artikelLagerwertGesamt;

            }

            // Statistik-Wert
            this.textBoxLagerwertGesamt.Text = lagerwertGesamt.ToString("N2") + "€";

        }

    }
}
