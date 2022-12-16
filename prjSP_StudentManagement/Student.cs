using DataAccess;
using System;
using System.Data;
using System.Data.SqlClient;
using c = System.Console;

namespace prjSP_StudentManagement {

    namespace Studentenverwaltung {
        public class Student {

            private int ID;
            private string Name;
            private string Lastname;
            private string Birthday;
            private string Birthplace;
            private string Email;
            private string University;
            private string UniverityLocation;

            public int id { get => ID; set => ID = value; }
            public string name { get => Name; set => Name = value; }
            public string lastname { get => Lastname; set => Lastname = value; }
            public string birthday { get => Birthday; set => Birthday = value; }
            public string birthplace { get => Birthplace; set => Birthplace = value; }
            public string email { get => Email; set => Email = value; }
            public string university { get => University; set => University = value; }
            public string universityLocation { get => UniverityLocation; set => UniverityLocation = value; }

            public void AddStudent() {

                c.WriteLine("Neuen Studenten einfügen:");

                c.Write("Vorname: ");
                name = Convert.ToString(c.ReadLine());

                c.Write("Nachname: ");
                lastname = Convert.ToString(c.ReadLine());

                c.Write("Geboren am: ");
                birthday = Convert.ToString(c.ReadLine());

                c.Write("Geboren in: ");
                birthplace = Convert.ToString(c.ReadLine());

                c.Write("E-Mail: ");
                email = Convert.ToString(c.ReadLine());

                c.Write("Universität: ");
                university = Convert.ToString(c.ReadLine());

                c.Write("Ort der Universität: ");
                universityLocation = Convert.ToString(c.ReadLine());

                DatabaseConnector.WriteDatabase("uspStudentManagement",
                    new SqlParameter("@selected", "addStudent"),
                    new SqlParameter("@name", name),
                    new SqlParameter("@lastname", lastname),
                    new SqlParameter("@birthday", birthday),
                    new SqlParameter("@birthplace", birthplace),
                    new SqlParameter("@email", email),
                    new SqlParameter("@university", university),
                    new SqlParameter("@university_location", universityLocation)
                );

                c.ReadKey();

            }

            public void searchStudent() {

                c.Clear();

                c.WriteLine("Suchen nach Nachname: \n");
                lastname = Convert.ToString(c.ReadLine());

                DataTable dataTable = DatabaseConnector.ExecuteDataTable(
                    "uspStudentManagement",
                    new SqlParameter("@selected", "searchStudent"),
                    new SqlParameter("@lastname", lastname)
                );
                c.WriteLine("{0,0} {1,-10} {2,-10}\n",
                "ID", "Nachname", "Vorname");

                if (dataTable.Rows.Count > 0) {

                    foreach (DataRow dataRow in dataTable.Rows) {
                        c.WriteLine("[{0}]  {1,-10} {2,-10} {3,-8} {4,-8} {5,-20} {6,-15}",
                        dataRow[0], dataRow[1], dataRow[2], Convert.ToDateTime(dataRow[3]).ToString("dd/MM/yyyy"), dataRow[4], dataRow[5], dataRow[6]);
                    }

                }
                else {
                    c.WriteLine("Leider keine Studenten gefunden'!");
                }

                c.WriteLine("Weiter...");

                c.ReadKey();

            }

            public void ShowAllStudents() {

                c.Clear();

                c.WriteLine("Alle Studenten: ");

                DataTable dataTable = DatabaseConnector.ExecuteDataTable(
                    "uspStudentManagement",
                    new SqlParameter("@selected", "showAllStudents")
                );

                if (dataTable.Rows.Count > 0) {

                    c.WriteLine("{0,0} {1,-10} {2,-10} {3,-10} {4,-8} {5,-20} {6,-15}\n",
                        "Nachname", "Vorname", "Geb.Datum", "geb.in", "Mail-Adresse", "Universität", "Ort");

                    foreach (DataRow dataRow in dataTable.Rows) {
                        c.WriteLine("[{0}]  {1,-10} {2,-10} {3,-8} {4,-8} {5,-20} {6,-15}",
                        dataRow[0], dataRow[1], Convert.ToDateTime(dataRow[2]).ToString("dd/MM/yyyy"), dataRow[3], dataRow[4], dataRow[5], dataRow[6]);
                    }

                    c.WriteLine("\nAnzahl der Studenten: {0}", dataTable.Rows.Count);

                }
                else {
                    c.WriteLine("Leider keine Studenten gefunden'!");
                }

                c.WriteLine("Weiter...");
                c.ReadKey();

            }

            public void deleteStudent() {

                DataTable dataTable = DatabaseConnector.ExecuteDataTable(
                    "uspStudentManagement",
                    new SqlParameter("@selected", "viewIDs")
                );

                if (dataTable.Rows.Count > 0) {

                    c.WriteLine("" +
                        "{0,0} {1,-10} {2,-10}\n",
                        "ID", "Nachname", "Vorname"
                    );

                    foreach (DataRow dataRow in dataTable.Rows) {
                        c.WriteLine("[{0}]  {1,-10} {2,-10}",
                            dataRow[0], dataRow[1], dataRow[2]);
                    }

                    c.WriteLine("\nAnzahl der Studenten: {0}", dataTable.Rows.Count);

                }
                else {
                    c.WriteLine("Leider keine Studenten gefunden'!");
                }

                c.WriteLine("ID des Studenten eingeben, der gelöscht werden soll: \n");

                id = Convert.ToInt16(c.ReadLine());

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Student wird endgültig gelöscht.\n\nWeiter? (J/N)");

                string acceptDelete = c.ReadLine();

                if (acceptDelete == "J") {

                    DatabaseConnector.WriteDatabase("uspStudentManagement",
                        new SqlParameter("@selected", "deleteStudent"),
                        new SqlParameter("@id", id)
                    );

                }
                else {
                    c.Clear();
                    c.WriteLine("Abgebrochen. Gehe zurück...");
                }

                Console.ResetColor();

                c.ReadKey();

            }

        }
    }

}
