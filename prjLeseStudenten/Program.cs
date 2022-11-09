using System;
using System.Data;
using System.Data.SqlClient;

using c = System.Console;

namespace prjLeseStudenten {
    internal class Program {
        static void Main(string[] args) {

            try {

                Datenzugriff.cn.Open();

                int inRecords = Datenzugriff.daStudenten.Fill(Datenzugriff.dtStudenten);

                if (inRecords > 0) {

                    c.WriteLine("Unsere alphabetische Studentenliste...\n\n");
                    c.WriteLine("{0,-10} {1,-10} {2,-10} {3,-8} {4,-20} {5,-15} {6,-12}\n", "Nachname", "Vorname", "Geb.Datum", "geb.in", "Mail-Adresse", "Universität", "Ort");

                    foreach (DataRow dr in Datenzugriff.dtStudenten.Rows) {
                        c.WriteLine("{0,-10} {1,-10} {2,-10} {3,-8} {4,-20} {5,-15} {6,-12}", dr[0], dr[1], Convert.ToDateTime(dr[2]).ToString("dd/MM/yyyy"), dr[3], dr[4], dr[5], dr[6]);
                    }

                    c.WriteLine("\nAnzahl der Studenten: {0}", inRecords);
                    c.ReadKey();

                }
                else {
                    c.WriteLine("Leider keine Studenten gefunden'!");
                    c.ReadKey();
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
