using System.Data;
using System.Data.SqlClient;
using c = System.Console;

namespace prjLeseKunden {
	internal class Program {
		static void Main(string[] args) {

			try {

				//Öffnen der Verbindung zum SQL Server
				Datenzugriff.cn.Open();

				//Anzahl der gefundenen DS
				int inRecords = Datenzugriff.daKunde.Fill(Datenzugriff.dtKunde);

				if (inRecords > 0) {

					c.WriteLine("Unsere alphabetische Kundenliste...\n\n");
					c.WriteLine("{0,-12} {1,-12} {2,-10} {3,-18} {4,-20}\n", "Nachname", "Vorname", "Plz", "Ort", "Strasse");

					foreach (DataRow dr in Datenzugriff.dtKunde.Rows) {
						c.WriteLine("{0,-12} {1,-12} {2,-10} {3,-18} {4,-20}", dr[0], dr[1], dr[2], dr[3], dr[4]);
					}

					c.WriteLine("\nAnzahl der Kunden: {0}", inRecords);
					c.ReadKey();

				}
				else {
					c.WriteLine("Leider wurden keine Kunden gefunden!");
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