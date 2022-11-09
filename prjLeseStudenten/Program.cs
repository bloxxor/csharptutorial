using System;
using System.Data;
using System.Data.SqlClient;
using Datenbankverwaltung;
using Studentenverwaltung;

using c = System.Console;

namespace prjLeseStudenten {
	internal class Program {
		static void Main(string[] args) {

			try {

				Student student = new Student();

				string StrMessage = "Studenten-Verwaltung: ---> Treffen Sie eine Wahl:\n\n";
				StrMessage += "(N) Neuen Studenten anlegen\n";
				StrMessage += "(B) Studenten suchen\n";
				StrMessage += "(L) Liste aller Studenten\n";
				StrMessage += "(E) Beenden\n";

				c.WriteLine(StrMessage);
				c.Write("Ihre Wahl lautet: ");
				string strWahl = c.ReadLine().ToUpper();

				switch (strWahl) {
					case "N":
						c.WriteLine("Daten eingeben: ");
						student.AddStudent();
						break;
					case "B":
						break;
					case "L":
                        c.WriteLine("Unsere alphabetische Studentenliste...\n\n");
                        student.ShowAllStudents(); 
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
