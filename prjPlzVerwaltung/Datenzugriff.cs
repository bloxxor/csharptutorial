using System.Data;
using System.Data.SqlClient;

namespace Datenzugriff {
    public class DatenZugr {

        // DataTable füllen mit Stored Procedures
        public static DataTable ExecuteDataTable(string storedProcedureName, params SqlParameter[] sqlParameters) {

            // Initialisiere DataTable
            DataTable dataTable = new DataTable();

            // Connect to Database
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MACHINE\SQLEXPRESS; Initial Catalog=dbKundenArchiv; Integrated Security=sspi")) {

                // Open DB Connection
                conn.Open();

                using (SqlCommand command = new SqlCommand()) {

                    command.Connection = conn;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedureName;

                    if (sqlParameters != null) {
                        foreach (SqlParameter parameterName in sqlParameters) {
                            command.Parameters.Add(parameterName);
                        }
                    }

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command)) { 
                        dataAdapter.Fill(dataTable);
                    }

                }

            }

            return dataTable;

        }

    }
}
