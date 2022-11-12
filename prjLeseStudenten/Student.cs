// Meine Namespaces
using Datenbankverwaltung;
using System;
using System.Data;
using System.Data.SqlClient;
using c = System.Console;

namespace Studentenverwaltung {
    public class Student {

        private int ID;
        private string Vorname;
        private string Nachname;
        private string Geboren;
        private string GeborenIn;
        private string Mail;
        private string Uni;
        private string Ort;

        public int id {
            get => ID;
            set => ID = value;
        }
        public string vorname {
            get => Vorname;
            set => Vorname = value;
        }
        public string nachname {
            get => Nachname;
            set => Nachname = value;
        }
        public string geboren {
            get => Geboren;
            set => Geboren = value;
        }
        public string geborenIn {
            get => GeborenIn;
            set => GeborenIn = value;
        }
        public string mail {
            get => Mail;
            set => Mail = value;
        }
        public string uni {
            get => Uni;
            set => Uni = value;
        }
        public string ort {
            get => Ort;
            set => Ort = value;
        }

        public void AddStudent() {

            c.Clear();

            // INSERT Query
            SqlCommand cmd = new SqlCommand(Datenzugriff.addStudent, Datenzugriff.connection);

            c.WriteLine("Neuen Studenten einfügen:");

            c.Write("Vorname: ");
            vorname = Convert.ToString(c.ReadLine());

            c.Write("Nachname: ");
            nachname = Convert.ToString(c.ReadLine());

            c.Write("Geboren am: ");
            geboren = Convert.ToString(c.ReadLine());

            c.Write("Geboren in: ");
            geborenIn = Convert.ToString(c.ReadLine());

            c.Write("E-Mail: ");
            mail = Convert.ToString(c.ReadLine());

            c.Write("Universität: ");
            uni = Convert.ToString(c.ReadLine());

            c.Write("Ort der Universität: ");
            ort = Convert.ToString(c.ReadLine());

            // Parameter an die INSERT Anweisung übergeben 
            cmd.Parameters.Add("@NName", SqlDbType.NVarChar, 50).Value = nachname;
            cmd.Parameters.Add("@VName", SqlDbType.NVarChar, 50).Value = vorname;
            cmd.Parameters.Add("@GebDat", SqlDbType.Date).Value = geboren;
            cmd.Parameters.Add("@GebOrt", SqlDbType.NVarChar, 50).Value = geborenIn;
            cmd.Parameters.Add("@Mail", SqlDbType.NVarChar, 50).Value = mail;
            cmd.Parameters.Add("@Uni", SqlDbType.NVarChar, 50).Value = uni;
            cmd.Parameters.Add("@Ort", SqlDbType.NVarChar, 50).Value = ort;

            // Öffne Verbindung
            Datenzugriff.connection.Open();

            // Execute Query
            cmd.ExecuteNonQuery();

            // Schliesse Verbingung
            Datenzugriff.connection.Close();

            c.Clear();

            c.Write("Datensatz von \"{0} {1}\" wurde erfolgreich gespeichert.", vorname, nachname);

            c.ReadKey();

        }

        public void searchStudent() {

            c.Clear();

            c.WriteLine("Suchen nach Nachname: \n");
            nachname = Convert.ToString(c.ReadLine());

            //SqlCommand cmd = new SqlCommand(Datenzugriff.searchCommand, Datenzugriff.connection);
            //cmd.Parameters.AddWithValue("@SearchValue", nachname);

            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM tblStudenten WHERE STUD_Nachname LIKE '%" + nachname + "%'",
                Datenzugriff.connection
            );

            Datenzugriff.connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            c.WriteLine("{0,0} {1,-10} {2,-10} {3,-10} {4,-8} {5,-20} {6,-15} {7,-12}\n", "[ID]",
                    "Nachname", "Vorname", "Geb.Datum", "geb.in", "Mail-Adresse", "Universität", "Ort");

            while (reader.Read()) {

                c.WriteLine("[{0}] {1,-10} {2,-10} {3,-8} {4,-8} {5,-20} {6,-15} {7,-12}",
                    reader[0], reader[1], reader[2], Convert.ToDateTime(reader[3]).ToString("dd/MM/yyyy"), reader[4], reader[5], reader[6], reader[7]
                );

            }

            reader.Close();

            Datenzugriff.connection.Close();

            c.WriteLine("Weiter...");

            c.ReadKey();

        }

        public void ShowAllStudents() {

            Datenzugriff.dataTable.Clear();

            Datenzugriff.connection.Open();

            int inRecords = Datenzugriff.sqlDataAdapter.Fill(Datenzugriff.dataTable);

            if (inRecords > 0) {

                c.WriteLine("{0,0} {1,-10} {2,-10} {3,-10} {4,-8} {5,-20} {6,-15} {7,-12}\n", "[ID]",
                    "Nachname", "Vorname", "Geb.Datum", "geb.in", "Mail-Adresse", "Universität", "Ort");

                foreach (DataRow dataRow in Datenzugriff.dataTable.Rows) {
                    c.WriteLine("[{0}]  {1,-10} {2,-10} {3,-8} {4,-8} {5,-20} {6,-15} {7,-12}",
                        dataRow[0], dataRow[1], dataRow[2], Convert.ToDateTime(dataRow[3]).ToString("dd/MM/yyyy"), dataRow[4], dataRow[5], dataRow[6], dataRow[7]);
                }

                c.WriteLine("\nAnzahl der Studenten: {0}", inRecords);

            }
            else {
                c.WriteLine("Leider keine Studenten gefunden'!");
            }

            c.WriteLine("Weiter...");

            Datenzugriff.connection.Close();

            c.ReadKey();

        }

        public void deleteStudent() {

            c.WriteLine("ID des Studenten eingeben, der gelöscht werden soll: \n");
            id = Convert.ToInt16(c.ReadLine());

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Student wird endgültig gelöscht.\n\nWeiter? (J/N)");

            string acceptDelete = c.ReadLine();

            if (acceptDelete == "J") {

                SqlCommand cmd = new SqlCommand(Datenzugriff.deleteCommand, Datenzugriff.connection);

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                Datenzugriff.connection.Open();

                cmd.ExecuteNonQuery();

                Datenzugriff.connection.Close();

                c.WriteLine("Student gelöscht.");

            }
            else {
                c.Clear();
                c.WriteLine("Abgebrochen. Gehe zurück...");
            }

            Console.ResetColor();

            c.ReadKey();

        }

        public void easterEgg() {

            int i = 0;

            do {

                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Easter".PadRight(Console.WindowWidth - 1));

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Egg".PadRight(Console.WindowWidth - 1));

                c.WriteLine("");

                i++;

            } while (i < 1000000);

        }

    }
}
