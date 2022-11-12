using Datenbankverwaltung;
using Studentenverwaltung;
using System.Data;
using System.Data.SqlClient;
using c = System.Console;

namespace prjLeseStudenten {
    internal class Program {
        static void Main(string[] args) {

            try {

                bool exit = false;

                do {

                    c.Clear();

                    Student student = new Student();

                    string StrMessage = "Studenten-Verwaltung:\n\n";
                    StrMessage += "(N) Neuen Studenten anlegen\n";
                    StrMessage += "(S) Studenten suchen\n";
                    StrMessage += "(L) Liste aller Studenten\n";
                    StrMessage += "(D) Lösche Studenten\n";
                    StrMessage += "(E) Beenden\n";

                    c.WriteLine(StrMessage);
                    c.Write("Eingabe: ");

                    string strWahl = c.ReadLine().ToUpper();

                    switch (strWahl) {
                        case "N":
                            c.WriteLine("Daten eingeben: ");
                            student.AddStudent();
                            break;
                        case "S":
                            student.searchStudent();
                            break;
                        case "L":
                            c.WriteLine("Unsere alphabetische Studentenliste...\n\n");
                            student.ShowAllStudents();
                            break;
                        case "D":
                            c.WriteLine("Student löschen:\n\n");
                            student.ShowAllStudents();
                            student.deleteStudent();
                            break;
                        case "E":
                            c.WriteLine("Zum Beenden bitte die Any Key Taste drücken.");
                            c.ReadKey();
                            exit = true;
                            break;
                        case "X":
                            student.easterEgg();
                            break;
                    }

                } while (!exit);

            }
            catch (SqlException e) {

                string msg = "";
                for (int i = 0; i < e.Errors.Count; i++) {
                    msg += "Error #" + i + " Message: " + e.Errors[i].Message + "\n";
                }

                c.WriteLine(msg);
                c.ReadKey();

            }
            finally {
                if (Datenzugriff.connection.State != ConnectionState.Closed) {
                    Datenzugriff.connection.Close();
                }
            }

        }
    }
}
