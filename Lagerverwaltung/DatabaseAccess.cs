using System;
using System.Data;
using System.Data.SqlClient;

namespace Inventory {
    public class DatabaseAccess {

        public static DataTable ExecuteTable(string StoredProcedureName, params SqlParameter[] sqlParameters) {

            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(
                @"Data Source=DESKTOP-MACHINE\SQLEXPRESS; 
                Initial Catalog=dbInventoryManagement; 
                Integrated Security=sspi")) {

                conn.Open();

                using (SqlCommand command = new SqlCommand()) {

                    command.Connection = conn;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = StoredProcedureName;

                    if (sqlParameters != null) {
                        foreach (SqlParameter param in sqlParameters) {
                            command.Parameters.Add(param);
                        }
                    }

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command)) {
                        dataAdapter.Fill(dataTable);
                    }

                }

                return dataTable;

            }

        }
        public static void WriteTable(string StoredProcedureName, params SqlParameter[] sqlParameters) {

            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(
                @"Data Source=DESKTOP-MACHINE\SQLEXPRESS; 
                Initial Catalog=dbEmployeeManagement; 
                Integrated Security=sspi")) {

                conn.Open();

                using (SqlCommand command = new SqlCommand()) {

                    command.Connection = conn;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = StoredProcedureName;

                    if (sqlParameters != null) {
                        foreach (SqlParameter param in sqlParameters) {
                            command.Parameters.Add(param);
                        }
                    }

                    int resultCount = command.ExecuteNonQuery();

                    if (resultCount > 0) {
                        Console.WriteLine("Erfolgreich.");
                    }
                    else {
                        Console.WriteLine("Fehlgeschlagen.");
                    }

                }

            }

        }

    }
}
