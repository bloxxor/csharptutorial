using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace EmployeeManagement {
    public class Employee {

        private string EmpID;
        private string Name;
        private string City;
        private string Department;
        private string Gender;

        public string empID { get => EmpID; set => EmpID = value; }
        public string name { get => Name; set => Name = value; }
        public string city { get => City; set => City = value; }
        public string department { get => Department; set => Department = value; }
        public string gender { get => Gender; set => Gender = value; }

        public void saveRecord() {

            DatabaseAccess.WriteTable(
                "uspEmployeeManagement",
                new SqlParameter("@selected", "saveRecord"),
                new SqlParameter("@empID", empID),
                new SqlParameter("@name", name),
                new SqlParameter("@city", city),
                new SqlParameter("@department", department),
                new SqlParameter("@gender", gender)
            );

        }
        public DataTable fetchData() {

            DataTable dataTable = DatabaseAccess.ExecuteTable(
                "uspEmployeeManagement",
                new SqlParameter("@selected", "fetchData"),
                new SqlParameter("@name", name),
                new SqlParameter("@city", city),
                new SqlParameter("@department", department),
                new SqlParameter("@gender", gender)
            );

            return dataTable;

        }

        public DataTable fetchRecord(string empID) {

            DataTable dataTable = DatabaseAccess.ExecuteTable(
                "uspEmployeeManagement",
                new SqlParameter("@selected", "fetchRecord"),
                new SqlParameter("@empID", empID)
            );

            return dataTable;

        }

        public void deleteRecord(string empID) {
            DatabaseAccess.WriteTable(
                "uspEmployeeManagement",
                new SqlParameter("@selected", "deleteRecord"),
                new SqlParameter("@empID", empID)
            );
        }

    }

}
