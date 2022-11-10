// Meine Namespaces
using Datenbankverwaltung;
using System;
using System.Data;
using System.Data.SqlClient;
using c = System.Console;

namespace Studentenverwaltung {
    public class Student {

        private int ID;
        private string Vorname;
        private string Nachname;
        private string Geboren;
        private string GeborenIn;
        private string Mail;
        private string Uni;
        private string Ort;

        public int id {
            get => ID;
            set => ID = value;
        }
        public string vorname {
            get => Vorname;
            set => Vorname = value;
        }
        public string nachname {
            get => Nachname;
            set => Nachname = value;
        }
        public string geboren {
            get => Geboren;
            set => Geboren = value;
        }
        public string geborenIn {
            get => GeborenIn;
            set => GeborenIn = value;
        }
        public string mail {
            get => Mail;
            set => Mail = value;
        }
        public string uni {
            get => Uni;
            set => Uni = value;
        }
        public string ort {
            get => Ort;
            set => Ort = value;
        }

        public void AddStudent() {

            SqlCommand cmd = new SqlCommand(Datenzugriff.addStudent, Datenzugriff.cn);

            c.WriteLine("--------- Neuen Studenten einfügen:");
            c.Write("Vorname: ");
            vorname = Convert.ToString(c.ReadLine());
            c.Write("Nachname: ");
            nachname = Convert.ToString(c.ReadLine());
            c.Write("Geboren am: ");
            geboren = Convert.ToString(c.ReadLine());
            c.Write("Geboren in: ");
            geborenIn = Convert.ToString(c.ReadLine());
            c.Write("E-Mail: ");
            mail = Convert.ToString(c.ReadLine());
            c.Write("Universität: ");
            uni = Convert.ToString(c.ReadLine());
            c.Write("Ort der Universität: ");
            ort = Convert.ToString(c.ReadLine());

            // Parameter von der INSERT Anweisung: 
            cmd.Parameters.Add("@NName", System.Data.SqlDbType.NVarChar, 50).Value = nachname;
            cmd.Parameters.Add("@VName", System.Data.SqlDbType.NVarChar, 50).Value = vorname;
            cmd.Parameters.Add("@GebDat", System.Data.SqlDbType.Date).Value = geboren;
            cmd.Parameters.Add("@GebOrt", System.Data.SqlDbType.NVarChar, 50).Value = geborenIn;
            cmd.Parameters.Add("@Mail", System.Data.SqlDbType.NVarChar, 50).Value = mail;
            cmd.Parameters.Add("@Uni", System.Data.SqlDbType.NVarChar, 50).Value = uni;
            cmd.Parameters.Add("@Ort", System.Data.SqlDbType.NVarChar, 50).Value = ort;

            // Öffne Verbindung
            Datenzugriff.cn.Open();

            // Führt den INSERT am SQLServer aus
            cmd.ExecuteNonQuery();

            c.Clear();
            c.Write("Der neue Datensatz {0} {1} wurde erfolgreich gespeichert.", vorname, nachname);
            c.ReadKey();

        }

        public void searchStudent() {



        }

        public void ShowAllStudents() {

            Datenzugriff.cn.Open();

            int inRecords = Datenzugriff.daStudenten.Fill(Datenzugriff.dtStudenten);

            if (inRecords > 0) {

                c.WriteLine("{0,-10} {1,-10} {2,-10} {3,-8} {4,-20} {5,-15} {6,-12}\n", "Nachname", "Vorname", "Geb.Datum", "geb.in", "Mail-Adresse", "Universität", "Ort");

                foreach (DataRow dr in Datenzugriff.dtStudenten.Rows) {
                    c.WriteLine("{0,-10} {1,-10} {2,-10} {3,-8} {4,-20} {5,-15} {6,-12}", dr[0], dr[1], Convert.ToDateTime(dr[2]).ToString("dd/MM/yyyy"), dr[3], dr[4], dr[5], dr[6]);
                }

                c.WriteLine("\nAnzahl der Studenten: {0}", inRecords);
                c.ReadKey();

            }
            else {
                c.WriteLine("Leider keine Studenten gefunden'!");
                c.ReadKey();
            }

        }

    }
}
