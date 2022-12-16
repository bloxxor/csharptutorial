using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess {
    public class DatabaseConnector {

        // DataTable füllen mit Stored Procedures
        public static DataTable ExecuteDataTable(string storedProcedureName, params SqlParameter[] sqlParameters) {

            // Initialisiere DataTable
            DataTable dataTable = new DataTable();

            // Connect to Database
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MACHINE\SQLEXPRESS; Initial Catalog=dbStudentManagement; Integrated Security=sspi")) {

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

        public static void WriteDatabase(string storedProcedureName, params SqlParameter[] sqlParameters) {

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MACHINE\SQLEXPRESS; Initial Catalog=dbStudentManagement; Integrated Security=sspi")) {

                conn.Open();

                using (SqlCommand command = new SqlCommand()) {

                    command.Connection = conn;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedureName;

                    if (sqlParameters != null) {
                        foreach (SqlParameter sqlParameter in sqlParameters) {
                            command.Parameters.Add(sqlParameter);
                        }
                    }

                    int resultCount = command.ExecuteNonQuery();

                    if (resultCount > 0) {
                        Console.WriteLine("Befehl erfolgreich ausgeführt.");
                    }
                    else {
                        Console.WriteLine("Befehl konnt nicht ausgeführt werden.");
                    }

                }

            }

        }

    }
}
