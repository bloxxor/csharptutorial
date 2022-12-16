using ConsoleTables;
using Datenzugriff;
using System;
using System.Data;
using System.Data.SqlClient;
using c = System.Console;

namespace prjFahrtenbuch {
    public class Arbeitnehmer {

        int ID;
        string Vorname;
        string Nachname;

        public int id { get => ID; set => ID = value; }
        public string vorname { get => Vorname; set => Vorname = value; }
        public string nachname { get => Nachname; set => Nachname = value; }

        public void viewAn() {

            c.Clear();

            c.WriteLine("Alle ansehen: ");

            DataTable dataTable = Datenbank.ExecuteTable(
                "uspFahrtenbuchProcedures",
                new SqlParameter("@auswahl", "viewAn")
            );

            if (dataTable.Rows.Count > 0) {

                var table = new ConsoleTable("Vorname", "Nachname");

                foreach (DataRow dataRow in dataTable.Rows) {
                    table.AddRow(dataRow[0], dataRow[1]);
                }

                table.Write();

            }
            else {
                c.WriteLine("Keine Arbeitnehmer angelegt.");
            }

            c.ReadKey();

        }
        public void addAn() {

            // Add Arbeitnehmer Menu
            c.Clear();

            c.WriteLine("Arbeitnehmer hinzufügen:\n");

            c.WriteLine("Vorname:\n");
            vorname = c.ReadLine();

            c.WriteLine("Nachname:\n");
            nachname = c.ReadLine();

            Datenbank.WriteTable("uspFahrtenbuchProcedures",
                new SqlParameter("@auswahl", "addAn"),
                new SqlParameter("@an_vorname", vorname),
                new SqlParameter("@an_nachname", nachname)
            );

            c.ReadKey();

        }
        public void searchAn() {

            c.Clear();

            c.WriteLine("Arbeitnehmer suchen:\n");

            c.WriteLine("Nachname:\n");
            nachname = c.ReadLine();

            DataTable dataTable = Datenbank.ExecuteTable(
                "uspFahrtenbuchProcedures",
                new SqlParameter("@auswahl", "searchAn"),
                new SqlParameter("@an_nachname", nachname)
            );

            if (dataTable.Rows.Count > 0) {

                var table = new ConsoleTable("Vorname", "Nachname");

                foreach (DataRow dataRow in dataTable.Rows) {                    
                    table.AddRow(dataRow[0], dataRow[1]);
                }

                table.Write();
            }
            else {
                c.WriteLine("Keine Arbeitnehmer angelegt.");
            }

            c.ReadKey();

        }
        public void deleteAn() {

            c.Clear();

            c.WriteLine("Arbeitnehmer löschen:\n");

            // Arbeitnehmer hier anzeigen, um die ID zu finden
            selectAn();

            c.WriteLine("Arbeitnehmer-ID:\n");
            id = Convert.ToInt16(c.ReadLine());

            Datenbank.WriteTable("uspFahrtenbuchProcedures",
                  new SqlParameter("@auswahl", "deleteAn"),
                  new SqlParameter("@an_id", id));

            c.Write("Der Datensatz mit ArbeitnehmerID {0} wurde erfolgreich gelöscht...", id);

            c.ReadKey();

        }
        // For INSERT Fahrt
        public void selectAn() {

            c.Clear();

            c.WriteLine("Arbeitnehmer-ID für Fahrt auswählen: ");

            DataTable dataTable = Datenbank.ExecuteTable(
                "uspFahrtenbuchProcedures",
                new SqlParameter("@auswahl", "viewAnIDs")
            );

            if (dataTable.Rows.Count > 0) {

                c.WriteLine("{0,-12} {1,-12} {2,-24}", "ID", "Vorname", "Nachname");

                foreach (DataRow dataRow in dataTable.Rows) {
                    c.WriteLine("{0,-12}, {1,-12}, {2,-24}", dataRow[0], dataRow[1], dataRow[2]);
                }

            }
            else {
                c.WriteLine("Keine Arbeitnehmer angelegt.");
            }

        }

    }
}
