using System.Data;
using System.Data.SqlClient;

namespace Datenbankverwaltung {
    public static class Datenzugriff {

        // SQL Zugriff in Variable speichern
        static string str = (@"Data Source=DESKTOP-MACHINE\SQLEXPRESS; Initial Catalog=dbStudentenVerwaltung; Integrated Security=sspi");

        // Verbinden & Übergabe der Login Variable
        public static SqlConnection connection = new SqlConnection(str);

        // Query
        public static string selectAllCommand = "SELECT " +
            "STUD_ID, " +
            "STUD_Nachname, " +
            "STUD_Vorname, " +
            "STUD_GebDatum, " +
            "STUD_GebOrt, " +
            "STUD_MAIL, " +
            "STUD_Uni, " +
            "STUD_Ort " +
            "FROM tblStudenten " +
            "ORDER BY STUD_Nachname";

        // selectAllCommand Query-Result über SQL-Data-Adapter
        public static SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectAllCommand, connection);

        // Data-Table erstellen, für die Anzeige
        public static DataTable dataTable = new DataTable();

        // INSERT Query
        public static string addStudent = "INSERT INTO tblStudenten " +
            "(STUD_Nachname" +
            ", STUD_Vorname" +
            ", STUD_GebDatum" +
            ", STUD_GebOrt" +
            ", STUD_Mail" +
            ", STUD_Uni" +
            ", STUD_Ort) " +
            "VALUES(@NName,@VName,@GebDat,@GebOrt,@Mail,@Uni,@Ort)";

        // SEARCH Query
        public static string searchCommand = "SELECT * " +
            "FROM tblStudenten " +
            "WHERE STUD_Nachname LIKE '%@SearchValue%'";

        // DELETE Query
        public static string deleteCommand = "DELETE FROM tblStudenten " +
            "WHERE " +
            "STUD_ID=@ID";

    }

}
