// Datenbankklassen
using System.Data;
using System.Data.SqlClient;

namespace prjLeseKunden {
	public static class Datenzugriff {

		// Zugriff auf den SQL-Server
		// Server-Name, DB-Name, Security (dbuser, dbname)
		static string conStrg = (@"Data Source=DESKTOP-MACHINE\SQLEXPRESS; Initial Catalog=dbKundenArchiv; Integrated Security=sspi");
		// sspi = Security Support Provider Interface - Provider für Authentifizierung am SQL-Server

		// SQLConnection mit Übergabe des Verbindungsstrings
		public static SqlConnection cn = new SqlConnection(conStrg);

		// SQL Query
		public static string sCommand = "SELECT k.KUN_ZName," +
			"k.KUN_VName," +
			"a.ADR_PLZ," +
			"a.ADR_Ort," +
			"a.ADR_Strasse " +
			"FROM tblAdresse AS a INNER JOIN tblKunde AS k ON a.KUN_ID = k.KUN_ID " +
			"ORDER BY k.KUN_ZName";

		// für die Datensätze die am SQL-Server gefunden werden --> SQL-DataAdapter
		public static SqlDataAdapter daKunde = new SqlDataAdapter(sCommand, cn);

		// für die Anzeige der DS in der Konsole --> DataTable
		public static DataTable dtKunde = new DataTable();

	}
}
