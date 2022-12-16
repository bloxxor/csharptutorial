using System;
using System.Data;
using System.Data.SqlClient;
using ConsoleTables;
using Datenzugriff;
using c = System.Console;

namespace prjFahrtenbuch {
    public class Fahrzeug {

        int ID;
        string Marke;
        string Kennzeichen;

        public int id { get => ID; set => ID = value; }
        public string marke { get => Marke; set => Marke = value; }
        public string kennzeichen { get => Kennzeichen; set => Kennzeichen = value; }

        public void viewFz() {

            c.Clear();

            c.WriteLine("Alle ansehen: ");

            // SELECT
            DataTable dataTable = Datenbank.ExecuteTable(
                "uspFahrtenbuchProcedures",
                new SqlParameter("@auswahl", "viewFz")
            );

            if ( dataTable.Rows.Count > 0 ) {

                var table = new ConsoleTable("Marke", "Kennzeichen");

                foreach (DataRow dataRow in dataTable.Rows ) {
                    table.AddRow(dataRow[0], dataRow[1]);
                }

                c.WriteLine();
                
                table.Write();

            }

            c.ReadKey();

        }
        public void addFz() {

            c.Clear();

            c.WriteLine("Fahrzeug hinzufügen:\n");

            c.WriteLine("Marke:\n");
            marke = c.ReadLine();

            c.WriteLine("Kennzeichen:\n");
            kennzeichen = c.ReadLine();

            Datenzugriff.Datenbank.WriteTable(
                "uspFahrtenbuchProcedures",
                new SqlParameter("@auswahl", "addFz"),
                new SqlParameter("@fz_marke", marke),
                new SqlParameter("@fz_kennzeichen", kennzeichen)
            );

            // INSERT

            c.ReadKey();

        }
        public void searchFz() {

            // evtl. Loop für eingabe? (marke oder kennzeichen)
            c.Clear();

            c.WriteLine("Fahrzeug suchen:\n");

            c.WriteLine("Kennzeichen:\n");
            kennzeichen = c.ReadLine();

            // FIND
            DataTable dataTable = Datenbank.ExecuteTable(
                "uspFahrtenbuchProcedures",
                new SqlParameter("@auswahl", "searchFz"),
                new SqlParameter("@fz_kennzeichen", kennzeichen)
            );

            if (dataTable.Rows.Count > 0) {

                c.WriteLine("{0,0} {1,-20}", "Vorname", "Nachname");

                foreach (DataRow dataRow in dataTable.Rows) {
                    c.WriteLine("{0,0}, {1,-20}", dataRow[0], dataRow[1]);
                }

            }
            else {
                c.WriteLine("Keine Fahrzeuge angelegt.");
            }

            c.ReadKey();

        }
        public void deleteFz() {

            c.Clear();

            c.WriteLine("Fahrzeug löschen:\n");
            
            // Fahrzeug hier anzeigen, um die ID zu finden
            selectFz();

            c.WriteLine("ID eingeben:\n");
            id = Convert.ToInt16(c.ReadLine());

            Datenbank.WriteTable("uspFahrtenbuchProcedures",
                  new SqlParameter("@auswahl", "deleteFz"),
                  new SqlParameter("@fahrzeug_id", id));

            c.Write("Der Datensatz mit FahrzeugID {0} wurde erfolgreich gelöscht...", id);

            c.ReadKey();

        }

        // For INSERT Fahrt
        public void selectFz() {

            c.Clear();

            c.WriteLine("Fahrzeug-ID für Fahrt auswählen: ");

            DataTable dataTable = Datenbank.ExecuteTable(
                "uspFahrtenbuchProcedures",
                new SqlParameter("@auswahl", "viewFzIDs")
            );

            if (dataTable.Rows.Count > 0) {

                c.WriteLine("{0,0} {1,-10} {2,-20}", "ID", "Marke", "Kennzeichen");

                foreach (DataRow dataRow in dataTable.Rows) {
                    c.WriteLine("{0,0}, {1,-20}, {2,-20}", dataRow[0], dataRow[1], dataRow[2]);
                }

            }
            else {
                c.WriteLine("Keine Fahrzeuge angelegt.");
            }

        }

    }

}
