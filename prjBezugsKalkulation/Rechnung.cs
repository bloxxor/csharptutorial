using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Datenbankverwaltung;

using c = System.Console;

namespace Rechnungsverwaltung {
    public class Rechnung {

        private int ID;
        private double ListenEK;
        private double Rabatt;
        private double ZielEK;
        private double Skonto;
        private double BarEK;
        private double BezugsK;
        private double BezugsP;

        public int id { get => ID; set => ID = value; }
        public double listenEK { get => ListenEK; set => ListenEK = value; }
        public double rabatt { get => Rabatt; set => Rabatt = value; }
        public double zielEK { get => ZielEK; set => ZielEK = value; }
        public double skonto { get => Skonto; set => Skonto = value; }
        public double barEK { get => BarEK; set => BarEK = value; }
        public double bezugsK { get => BezugsK; set => BezugsK = value; }
        public double bezugsP { get => BezugsP; set => BezugsP = value; }

        public void AddRechnung() {

            SqlCommand cmd = new SqlCommand(Datenzugriff.addKalk, Datenzugriff.cn);

            c.WriteLine("---- Neue Bezugskostenkalkulation: ");
            c.WriteLine("Listeneinkaufspreis eingeben: ");
            listenEK = Convert.ToDouble(c.ReadLine());
            c.WriteLine("Rabatt eingeben (%): ");
            rabatt = Convert.ToDouble(c.ReadLine());
            c.WriteLine("Skonto eingeben (%): ");
            skonto = Convert.ToDouble(c.ReadLine());
            c.WriteLine("Bezugskosten eingeben: (%)");
            bezugsK = Convert.ToDouble(c.ReadLine());

            zielEK = listenEK - (listenEK / 100) * rabatt;
            barEK = zielEK - (zielEK / 100) * skonto;
            bezugsP = barEK + (barEK / 100) * bezugsK;

            // Parameter von der INSERT Anweisung
            cmd.Parameters.Add("@ListenEK", System.Data.SqlDbType.Float).Value = listenEK;
            cmd.Parameters.Add("@Rabatt", System.Data.SqlDbType.Float).Value = rabatt;
            cmd.Parameters.Add("@ZielEK", System.Data.SqlDbType.Float).Value = zielEK;
            cmd.Parameters.Add("@Skonto", System.Data.SqlDbType.Float).Value = skonto;
            cmd.Parameters.Add("@BarEK", System.Data.SqlDbType.Float).Value = barEK;
            cmd.Parameters.Add("@BezugsK", System.Data.SqlDbType.Float).Value = bezugsK;
            cmd.Parameters.Add("@BezugsP", System.Data.SqlDbType.Float).Value = bezugsP;

            // Öffne Verbindung
            Datenzugriff.cn.Open();

            // Führt den INSERT am SQLServer aus
            cmd.ExecuteNonQuery();

            c.Clear();
            c.WriteLine("Der folgende Datensatz wurde erfolgreich gespeichert: ");
            c.WriteLine("LEK: " + listenEK);
            c.WriteLine("Rabatt: " + rabatt + "%");
            c.WriteLine("Ziel EK: " + zielEK);
            c.WriteLine("SKonto: " + skonto + "%");
            c.WriteLine("Bar EK: " + barEK);
            c.WriteLine("Bezugskosten: " + bezugsK);
            c.WriteLine("Bezugspreis: " + bezugsP);

            c.ReadKey();

        }

        public void ShowAllKalks() {

            Datenzugriff.cn.Open();

            int inRecords = Datenzugriff.daBezKalk.Fill(Datenzugriff.dtBezKalk);

            if (inRecords > 0) {

                foreach (DataRow dr in Datenzugriff.dtBezKalk.Rows) {
                    
                    c.WriteLine("Listen EK: " + dr[0] + " EUR");
                    c.WriteLine("- Rabatt: " + dr[1] + "%");
                    c.WriteLine("------------------------");
                    c.WriteLine("= Ziel EK: " + dr[2] + " EUR");
                    c.WriteLine("- SKonto: " + dr[3] + "%");
                    c.WriteLine("------------------------");
                    c.WriteLine("= Bar EK: " + dr[4] + " EUR");
                    c.WriteLine("+ Bezugskosten: " + dr[5] + "%");
                    c.WriteLine("------------------------");
                    c.WriteLine("= Bezugspreis: " + dr[6] + " EUR");
                    c.WriteLine("______________________________\n\n");

                }

                c.WriteLine("\nAnzahl der Kalkulationen: {0}", inRecords);
                c.ReadKey();

            }
            else {
                c.WriteLine("Leider keine Kalkulationen gefunden'!");
                c.ReadKey();
            }

        }

    }
}
