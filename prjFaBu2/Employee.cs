using ConsoleTables;
using DataAccess;
using System;
using System.Data;
using System.Data.SqlClient;
using c = System.Console;

namespace prjFaBu2 {
    public class Employee {

        int ID;
        string Name;
        string Lastname;

        public int id { get => ID; set => ID = value; }
        public string name { get => Name; set => Name = value; }
        public string lastname { get => Lastname; set => Lastname = value; }

        public void viewAn() {

            c.Clear();

            c.WriteLine("Alle ansehen: ");

            DataTable dataTable = Database.ExecuteTable(
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
            name = c.ReadLine();

            c.WriteLine("Nachname:\n");
            name = c.ReadLine();

            Database.WriteTable("uspFahrtenbuchProcedures",
                new SqlParameter("@auswahl", "addAn"),
                new SqlParameter("@an_vorname", name),
                new SqlParameter("@an_nachname", lastname)
            );

            c.ReadKey();

        }
        public void searchAn() {

            c.Clear();

            c.WriteLine("Arbeitnehmer suchen:\n");

            c.WriteLine("Nachname:\n");
            lastname = c.ReadLine();

            DataTable dataTable = Database.ExecuteTable(
                "uspFahrtenbuchProcedures",
                new SqlParameter("@auswahl", "searchAn"),
                new SqlParameter("@an_nachname", lastname)
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

            Database.WriteTable("uspFahrtenbuchProcedures",
                  new SqlParameter("@auswahl", "deleteAn"),
                  new SqlParameter("@an_id", id));

            c.Write("Der Datensatz mit ArbeitnehmerID {0} wurde erfolgreich gelöscht...", id);

            c.ReadKey();

        }
        // For INSERT Fahrt
        public void selectAn() {

            c.Clear();

            c.WriteLine("Arbeitnehmer-ID für Fahrt auswählen: ");

            DataTable dataTable = Database.ExecuteTable(
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
