using System.Data;
using System.Data.SqlClient;

namespace Datenbankverwaltung {
	public static class Datenzugriff {

		// SQL Zugriff in Variable speichern
		static string conStrg = (@"Data Source=DESKTOP-MACHINE\SQLEXPRESS; Initial Catalog=dbStudentenVerwaltung; Integrated Security=sspi");

		// Verbinden & Übergabe der Login Variable
		public static SqlConnection cn = new SqlConnection(conStrg);

		// Query
		public static string sCommand = "SELECT STUD_Nachname, " +
			"STUD_Vorname, " +
			"STUD_GebDatum, " +
			"STUD_GebOrt, " +
			"STUD_MAIL, " +
			"STUD_Uni, " +
			"STUD_Ort FROM tblStudenten " +
			"ORDER BY STUD_Nachname";

		// SQL-Adapter, in der die Datensätze gespeichert werden
		public static SqlDataAdapter daStudenten = new SqlDataAdapter(sCommand, cn);

		// Data-Table erstellen, für die Anzeige
		public static DataTable dtStudenten = new DataTable();

		public static string addStudent = "INSERT INTO tblStudenten " +
			"(STUD_Nachname" +
			", STUD_Vorname" +
			", STUD_GebDatum" +
			", STUD_GebOrt" +
			", STUD_Mail" +
			", STUD_Uni" +
			", STUD_Ort) " +
			"VALUES(@NName,@VName,@GebDat,@GebOrt,@Mail,@Uni,@Ort)";

	}

}
