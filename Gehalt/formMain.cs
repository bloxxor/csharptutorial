using System;
using System.Collections;
using System.Windows.Forms;

namespace Gehalt {
    public partial class formMain : Form {

        private ArrayList listeEingabe;
        public formMain() {
            InitializeComponent();
            this.listeEingabe = new ArrayList();
        }

        private void buttonHinzufuegen_Click(object sender, EventArgs e) {

            Person person = new Person(
                this.textBoxName.Text,
                Int32.Parse(this.textBoxAlter.Text),
                Int32.Parse(this.textBoxGehalt.Text)
            );

            this.listeEingabe.Add( person );

            AnzeigeListe(this.listeEingabe);

            this.textBoxName.Clear();
            this.textBoxAlter.Clear();
            this.textBoxGehalt.Clear();

        }

        private void AnzeigeListe(ArrayList liste) {

            // Liste sortieren
            AnzeigeListeComparer(liste);

            // Alte Elemente löschen
            while (this.listViewPersons.Items.Count > 0) {
                this.listViewPersons.Items.RemoveAt(0);
            }

            double alterDurchschnitt = 0.0;
            double gehaltDurchschnitt = 0.0;

            foreach (Person person in liste) { 

                ListViewItem item = new ListViewItem();

                item.Text = person.id.ToString();
                item.SubItems.Add(person.name);
                item.SubItems.Add(person.alter.ToString());
                item.SubItems.Add(person.gehalt.ToString());

                this.listViewPersons.Items.Add(item);

                alterDurchschnitt += (double)person.alter;
                gehaltDurchschnitt += (double)person.gehalt;

            }

            // Statistik-Werte
            alterDurchschnitt /= (double)liste.Count;
            gehaltDurchschnitt /= (double)liste.Count;

            this.textBoxAlterDurchschnitt.Text = alterDurchschnitt.ToString();
            this.textBoxGehaltDurchschnitt.Text = gehaltDurchschnitt.ToString("N2");
            this.textBoxAnzahl.Text = liste.Count.ToString();

        }

        private void AnzeigeListeComparer(ArrayList liste) {

            IComparer compare = new SortiereId();

            if(this.radioButtonSortName.Checked) {
                compare = new SortiereName();
            }

            if(this.radioButtonSortAlter.Checked) {
                compare = new SortiereAlter();
            }

            if(this.radioButtonSortGehalt.Checked) {
                compare = new SortiereGehalt();
            }

            liste.Sort(compare);

        }

        private void radioButtonSort_CheckedChanged(object sender, EventArgs e) {
            AnzeigeListe(this.listeEingabe);
        }

        // Nur zum Testen mit einer Datenbank - zum testen using Datenbank verwenden
        //private void formMain_Load(object sender, EventArgs e) {

        //    DataTable dataTable = Datenbank.ExecuteTable(
        //        "uspGehaltProcedure"
        //    );

        //    if (dataTable.Rows.Count > 0) {
        //        System.Console.WriteLine(dataTable.Columns);

        //        foreach (string i in dataTable.Columns) {
        //            System.Console.Write("{0} ", i);
        //        }

        //    }

        //}

    }


    // Normalerweise eigene *.cs Datei, zu Schulungszwecken hier
    public class SortiereId : IComparer {
        int IComparer.Compare(object links, object rechts) {
            return (( (Person)links ).id - ( (Person)rechts ).id);
        }
    }

    public class SortiereName : IComparer {
        int IComparer.Compare(object links, object rechts) {
            return String.Compare(( (Person)links).name, ((Person)rechts).name);
        }
    }
    public class SortiereAlter : IComparer {
        int IComparer.Compare(object links, object rechts) {
            return (((Person)links).alter - ((Person)rechts).alter);
        }
    }
    public class SortiereGehalt : IComparer {
        int IComparer.Compare(object links, object rechts) {
            return (((Person)links).gehalt - ((Person)rechts).gehalt);
        }
    }

}
