using prjSP_StudentManagement.Studentenverwaltung;
using System.Data.SqlClient;
using c = System.Console;

namespace prjSP_StudentManagement {
    public static class MainMenu {

        public static void Menu() {

            try {

                bool exit = false;

                do {

                    c.Clear();

                    Student student = new Student();

                    string mainMenu = "Bitte auswählen:\n\n" +
                        "[N] Student anlegen\n" +
                        "[S] Student suchen\n" +
                        "[A] Studenten anzeigen\n" +
                        "[L] Student löschen\n" +
                        "[E] Beenden\n";

                    c.WriteLine(mainMenu);

                    string selected = c.ReadLine().ToLower();

                    switch (selected) {
                        case "n":
                            student.AddStudent();
                            break;
                        case "s":
                            student.searchStudent();
                            break;
                        case "a":
                            c.WriteLine("Alle Studenten: \n");
                            student.ShowAllStudents();
                            break;
                        case "l":
                            c.WriteLine("Studenten löschen: \n");
                            student.deleteStudent();
                            break;
                        case "e":
                            c.WriteLine("Beliebige Taste drücken...");
                            c.ReadKey();
                            exit = true;
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

            c.ReadKey();

        }

    }
}
