using ConsoleTables;
using DataAccess;
using System;
using System.Data;
using System.Data.SqlClient;
using c = System.Console;

namespace prjFaBu2 {
    internal class Ride {

        int ID;
        int AnID;
        int FzID;
        string Datum;
        string AbfahrtZeit;
        string AnkunftZeit;
        string Von;
        string Ueber;
        string Nach;
        string Zweck;
        int AbfahrtKm;
        int AnkunftKm;
        int BetrKm;
        int PrivatKm;

        public int id { get => ID; set => ID = value; }
        public int an_id { get => AnID; set => AnID = value; }
        public int fz_id { get => FzID; set => FzID = value; }
        public string datum { get => Datum; set => Datum = value; }
        public string abfahrt_zeit { get => AbfahrtZeit; set => AbfahrtZeit = value; }
        public string ankunft_zeit { get => AnkunftZeit; set => AnkunftZeit = value; }
        public string von { get => Von; set => Von = value; }
        public string ueber { get => Ueber; set => Ueber = value; }
        public string nach { get => Nach; set => Nach = value; }
        public string zweck { get => Zweck; set => Zweck = value; }
        public int abfahrt_km { get => AbfahrtKm; set => AbfahrtKm = value; }
        public int ankunft_km { get => AnkunftKm; set => AnkunftKm = value; }
        public int betr_km { get => BetrKm; set => BetrKm = value; }
        public int privat_km { get => PrivatKm; set => PrivatKm = value; }

        public void viewFa() {

            c.Clear();

            c.WriteLine("Alle ansehen: ");

            // SELECT
            DataTable dataTable = DataAccess.Database.ExecuteTable(
                "uspFahrtenbuchProcedures",
                new SqlParameter("@auswahl", "viewFahrt")
            );

            if (dataTable.Rows.Count > 0) {

                c.WriteLine("Fahrtenbuch");

                var table = new ConsoleTable(
                    "Fahrt-Datum",
                    "An. Nachname",
                    "An. Vorname",
                    "Fz. Marke",
                    "Fz. Kennzeichen",
                    "Abfahrt Zeit",
                    "Ankunft Zeit",
                    "Von",
                    "Über",
                    "Nach",
                    "Zweck",
                    "Abfahrt KM",
                    "Ankunft KM",
                    "Betr. KM",
                    "Priv. KM"
                );

                foreach (DataRow dataRow in dataTable.Rows) {

                    table.AddRow(
                        Convert.ToDateTime(dataRow[0]).ToString("dd/MM/yyyy"),
                        dataRow[1],
                        dataRow[2],
                        dataRow[3],
                        dataRow[4],
                        Convert.ToDateTime(dataRow[5]).ToString("HH:mm"),
                        Convert.ToDateTime(dataRow[6]).ToString("HH:mm"),
                        dataRow[7],
                        dataRow[8],
                        dataRow[9],
                        dataRow[10],
                        dataRow[11],
                        dataRow[12],
                        dataRow[13],
                        dataRow[14]
                    );

                }

                table.Write();

            }
            else {
                c.WriteLine("Keine Fahrten gefunden.");
            }

            c.ReadKey();

        }
        public void addFa() {

            c.Clear();

            c.WriteLine("Wer ist gefahren?\n");

            // Zeige IDs der Arbeitnehmer
            Employee arbeitnehmer = new Employee();
            arbeitnehmer.selectAn();

            c.WriteLine("Arbeitnehmer-ID eingeben:");
            int an_id = Convert.ToInt16(c.ReadLine());

            c.WriteLine("Welches Fahrzeug wurde benutzt?\n");
            Car fahrzeug = new Car();
            fahrzeug.selectFz();

            c.WriteLine("Fahrzeug-ID eingeben:");
            int fz_id = Convert.ToInt16(c.ReadLine());

            c.WriteLine("Datum der Fahrt:\n");
            datum = Convert.ToString(c.ReadLine());

            c.WriteLine("Abfahrtszeit:\n");
            abfahrt_zeit = Convert.ToString(c.ReadLine());

            c.WriteLine("Ankunftszeit:\n");
            ankunft_zeit = Convert.ToString(c.ReadLine());

            c.WriteLine("Von:\n");
            von = c.ReadLine();

            c.WriteLine("Über:\n");
            ueber = c.ReadLine();

            c.WriteLine("Nach:\n");
            nach = c.ReadLine();

            c.WriteLine("Zweck:\n");
            zweck = c.ReadLine();

            c.WriteLine("Abfahrt km:\n");
            abfahrt_km = Convert.ToInt16(c.ReadLine());

            c.WriteLine("Ankunft km:\n");
            ankunft_km = Convert.ToInt16(c.ReadLine());

            c.WriteLine("Betr. KM:\n");
            betr_km = Convert.ToInt16(c.ReadLine());

            c.WriteLine("Priv. KM:\n");
            privat_km = Convert.ToInt16(c.ReadLine());

            // INSERT
            Database.WriteTable("uspFahrtenbuchProcedures",
                new SqlParameter("@auswahl", "addFahrt"),
                new SqlParameter("@an_id", an_id),
                new SqlParameter("@fahrzeug_id", fz_id),
                new SqlParameter("@fa_datum", datum),
                new SqlParameter("@fa_abfahrt_zeit", abfahrt_zeit),
                new SqlParameter("@fa_ankunft_zeit", ankunft_zeit),
                new SqlParameter("@fa_von", von),
                new SqlParameter("@fa_ueber", ueber),
                new SqlParameter("@fa_nach", nach),
                new SqlParameter("@fa_zweck", zweck),
                new SqlParameter("@fa_abfahrt_km", abfahrt_km),
                new SqlParameter("@fa_ankunft_km", ankunft_km),
                new SqlParameter("@fa_betr_km", betr_km),
                new SqlParameter("@fa_privat_km", privat_km)
            );

            c.ReadKey();

        }
        public void searchFa() {

            // evtl. Loop für eingabe? (zweck oder nach oder datum)
            c.Clear();

            c.WriteLine("Fahrt suchen:\n");

            c.WriteLine("Kennzeichen:\n");
            string kennzeichen = c.ReadLine();

            // FIND
            DataTable dataTable = DataAccess.Database.ExecuteTable(
                "uspFahrtenbuchProcedures",
                new SqlParameter("@auswahl", "searchFa"),
                new SqlParameter("@fz_kennzeichen", kennzeichen)

            );

            if (dataTable.Rows.Count > 0) {

                c.WriteLine("{0,0} {1,-15} {2,-15} {3,-15} {4,-15} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}",
                    "Fahrt-Datum",
                    "An. Nachname",
                    "An. Vorname",
                    "Fz. Marke",
                    "Fz. Kennzeichen",
                    "Abfahrt Zeit",
                    "Ankunft Zeit",
                    "Von",
                    "Über",
                    "Nach",
                    "Zweck",
                    "Abfahrt KM",
                    "Ankunft KM",
                    "Betr. KM",
                    "Priv. KM"
                );

                foreach (DataRow dataRow in dataTable.Rows) {
                    c.WriteLine("{0,0} {1,-15} {2,-25} {3,-35} {4,-40}, {5,-20} {6} {7} {8} {9} {10} {11} {12} {13} {14}",
                    Convert.ToDateTime(dataRow[0]).ToString("dd/MM/yyyy"),
                    dataRow[1],
                    dataRow[2],
                    dataRow[3],
                    dataRow[4],
                    dataRow[5],
                    dataRow[6],
                    dataRow[7],
                    dataRow[8],
                    dataRow[9],
                    dataRow[10],
                    dataRow[11],
                    dataRow[12],
                    dataRow[13],
                    dataRow[14]
                );
                }

                c.WriteLine("\nAnzahl der Fahrten: {0}", dataTable.Rows.Count);

            }
            else {
                c.WriteLine("Keine Fahrten gefunden.");
            }

            c.ReadKey();
        }
        public void deleteFa() {

            c.Clear();

            c.WriteLine("Fahrt löschen:\n");

            // Fahrten hier anzeigen, um die ID zu finden

            c.WriteLine("Fahrten-ID:\n");
            id = Convert.ToInt16(c.ReadLine());

            Database.WriteTable("uspFahrtenbuchProcedures",
                  new SqlParameter("@auswahl", "deleteAn"),
                  new SqlParameter("@an_id", id));

            c.Write("Der Datensatz mit MitarbeiterID {0} wurde erfolgreich gelöscht...", id);

            c.ReadKey();

        }

    }
}
