using Datenzugriff;
using System;
using System.Data;
using System.Data.SqlClient;
using c = System.Console;

namespace prjPlzVerwaltung {
    public class SucheKunden {

        public static void sucheOrt() {

            c.Clear();

            c.WriteLine("Ort eingeben:");
            string ort = c.ReadLine();

            DataTable dataTable = DatenZugr.ExecuteDataTable(
                "uspSucheOrt",
                new SqlParameter("@ort", ort)
            );

            if (dataTable.Rows.Count > 0) {

                c.WriteLine();

                c.WriteLine("{0,-8} {1,-20} {2,-35}", "PLZ", "Stadt", "Bundesland");

                Console.WriteLine(new String('-', 100).Replace("-", "-"));

                foreach (DataRow dataRow in dataTable.Rows) {
                    c.WriteLine("{0,-8} {1,-20} {2, -35}",
                        dataRow[0],
                        dataRow[1],
                        dataRow[2]
                    );
                }

            }
            else {
                c.WriteLine("Nichts gefunden.");
            }

            // Press key to exit
            c.ReadKey();

        }

        public static void sucheBundesland() {

            c.Clear();

            c.WriteLine("Bundesland eingeben:");
            string bundesland = c.ReadLine();

            DataTable dataTable = DatenZugr.ExecuteDataTable(
                "uspSucheBundesland",
                new SqlParameter("@bundesland", bundesland)
            );

            c.WriteLine();

            if (dataTable.Rows.Count > 0) {

                c.WriteLine("{0,-8} {1,-20} {2,-35}", "PLZ", "Stadt", "Bundesland");

                Console.WriteLine(new String('-', 100).Replace("-", "-"));

                foreach (DataRow dataRow in dataTable.Rows) {
                    c.WriteLine("{0,-8} {1,-20} {2, -35}",
                        dataRow[0],
                        dataRow[1],
                        dataRow[2]
                    );
                }
            }
            else {
                c.WriteLine("Nichts gefunden.");
            }

            // Press key to exit
            c.ReadKey();

        }

        public static void suchePlz() {

            c.Clear();

            c.WriteLine("PLZ eingeben:");
            string plz = c.ReadLine();

            DataTable dataTable = DatenZugr.ExecuteDataTable(
                "uspSuchePlz",
                new SqlParameter("@plz", plz)
            );

            c.WriteLine();

            if (dataTable.Rows.Count > 0) {

                c.WriteLine("{0,-8} {1,-20} {2,-35}", "PLZ", "Stadt", "Bundesland");

                Console.WriteLine(new String('-', 100).Replace("-", "-"));

                foreach (DataRow dataRow in dataTable.Rows) {
                    c.WriteLine("{0,-8} {1,-20} {2, -35}",
                        dataRow[0],
                        dataRow[1],
                        dataRow[2]
                    );
                }

            }
            else {
                c.WriteLine("Nichts gefunden.");
            }

            // Press key to exit
            c.ReadKey();

        }

    }

}
