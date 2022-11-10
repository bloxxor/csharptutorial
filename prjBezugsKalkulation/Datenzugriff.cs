using System;
using System.Data;
using System.Data.SqlClient;

namespace Datenbankverwaltung {
    public static class Datenzugriff {

        // SQL Zugriff in Variable speichern
        static string conStrg = (@"Data Source=DESKTOP-MACHINE\SQLEXPRESS; Initial Catalog=dbBezugskalkulation; Integrated Security=sspi");

        // Verbinden & Übergabe der Login Variable
        public static SqlConnection cn = new SqlConnection(conStrg);

        public static string sCommand = "SELECT " +
            "Menge, " +
            "ListenEK, " +
            "ListenEKGesamt, " +
            "Rabatt, " +
            "ZielEK, " +
            "Skonto, " +
            "BarEK, " +
            "BezugsK, " +
            "BezugsP " +
            "FROM tblBezKalk ";

        // SQL-Adapter, in der die Datensätze gespeichert werden
        public static SqlDataAdapter daBezKalk = new SqlDataAdapter(sCommand, cn);

        // Data-Table erstellen, für die Anzeige
        public static DataTable dtBezKalk = new DataTable();

        public static string addKalk = "INSERT INTO tblBezKalk " +
            "(Menge" +
            ", ListenEK" +
            ", ListenEKGesamt" +
            ", Rabatt" +
            ", ZielEK" +
            ", Skonto" +
            ", BarEK" +
            ", BezugsK" +
            ", BezugsP) " +
            "VALUES(@Menge,@ListenEK,@ListenEKGesamt,@Rabatt,@ZielEK,@Skonto,@BarEK,@BezugsK,@BezugsP)";

    }

}
