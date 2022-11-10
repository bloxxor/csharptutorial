using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenbankverwaltung {
    public static class Datenzugriff {

        // SQL Zugriff in Variable speichern
        static string conStrg = (@"Data Source=DESKTOP-MACHINE\SQLEXPRESS; Initial Catalog=dbBezugskalkulation; Integrated Security=sspi");

        // Verbinden & Übergabe der Login Variable
        public static SqlConnection cn = new SqlConnection(conStrg);

        public static string sCommand = "SELECT ListenEK, " +
            "Rabatt, " +
            "ZielEK, " +
            "Skonto, " +
            "BarEK, " +
            "BezugsK, " +
            "BezugsP FROM tblBezKalk ";

        // SQL-Adapter, in der die Datensätze gespeichert werden
        public static SqlDataAdapter daBezKalk = new SqlDataAdapter(sCommand, cn);

        // Data-Table erstellen, für die Anzeige
        public static DataTable dtBezKalk = new DataTable();

        public static string addKalk = "INSERT INTO tblBezKalk " +
            "(ListenEK" +
            ", Rabatt" +
            ", ZielEK" +
            ", Skonto" +
            ", BarEK" +
            ", BezugsK" +
            ", BezugsP) " +
            "VALUES(@ListenEK,@Rabatt,@ZielEK,@Skonto,@BarEK,@BezugsK,@BezugsP)";

    }

}
