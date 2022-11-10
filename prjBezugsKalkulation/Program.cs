using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Datenbankverwaltung;
using Rechnungsverwaltung;

using c = System.Console;
using System.Text;

namespace prjBezugsKalkulation {
    internal class Program {
        static void Main(string[] args) {

            try {

                Rechnung rechnung = new Rechnung();

                string StrMessage = "Bezugskonsten-Kalkulations-Verwaltung: ---> Treffen Sie eine Wahl:\n\n";
                StrMessage += "(N) Neue Kalkulation anlegen\n";
                StrMessage += "(L) Liste aller Kalkulationen\n";
                StrMessage += "(E) Beenden\n";

                c.WriteLine(StrMessage);
                c.Write("Ihre Wahl lautet: ");
                string strWahl = c.ReadLine().ToUpper();

                switch (strWahl) {
                    case "N":
                        c.WriteLine("Daten eingeben: ");
                        rechnung.AddRechnung();
                        break;
                    case "L":
                        c.WriteLine("Alle Datensätze werden angezeigt:\n\n");
                        rechnung.ShowAllKalks();
                        break;
                    case "E":
                        c.WriteLine("Zum Beenden bitte die Any Key Taste drücken.");
                        c.ReadKey();
                        break;
                }

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
                if (Datenzugriff.cn.State != ConnectionState.Closed) {
                    Datenzugriff.cn.Close();
                }
            }

        }
    }
}
