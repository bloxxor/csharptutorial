using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using c = System.Console;
using Datenzugriff;

namespace prjPlzVerwaltung {
    internal class Program {
        static void Main(string[] args) {

            // Menü
            try {

                bool exit = false;

                do {

                    c.Clear();

                    string StrMessage = "Kundenverwaltung:\n\n";
                    StrMessage += "(O) Suche nach Ort\n";
                    StrMessage += "(B) Suche nach Bundesland\n";
                    StrMessage += "(P) Suche nach PLZ\n";
                    StrMessage += "(E) Beenden\n";

                    c.WriteLine(StrMessage);

                    c.Write("Eingabe: ");

                    string strWahl = c.ReadLine().ToUpper();

                    switch (strWahl) {
                        case "O":
                            c.WriteLine("Suche nach Ort: ");
                            SucheKunden.sucheOrt();
                            break;
                        case "B":
                            c.WriteLine("Suche nach Bundesland: ");
                            SucheKunden.sucheBundesland();
                            break;
                        case "P":
                            c.WriteLine("Suche nach PLZ: ");
                            SucheKunden.suchePlz();
                            break;
                        case "E":
                            c.WriteLine("Zum Beenden bitte die Any Key Taste drücken.");
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

        }
    }
}
