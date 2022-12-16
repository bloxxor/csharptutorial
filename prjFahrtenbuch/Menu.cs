using System;
using c = System.Console;

namespace prjFahrtenbuch {
    public class Menu {

        // Menus
        public static void mainMenu() {

            bool exit = false;

            do {

                c.Clear();

                Arbeitnehmer arbeitnehmer = new Arbeitnehmer();
                Fahrzeug fahrzeug = new Fahrzeug();
                Fahrt fahrt = new Fahrt();

                // Main Menu
                c.WriteLine("Hauptmenü");
                c.WriteLine(new String('-', 80).Replace("-", "-"));
                string mainMenuItems = "" +
                    "(1) Alle Fahrten anzeigen\n" +
                    "(2) Fahrt eintragen\n" +
                    "(3) Fahrt suchen\n" +
                    //"(4) Fahrt löschen\n" +
                    new String('-', 80).Replace("-", "-") +
                    "\n" +
                    "(5) Alle Arbeitnehmer zeigen\n" +
                    "(6) Arbeitnehmer hinzufügen\n" +
                    "(7) Arbeitnehmer suchen\n" +
                    //"(8) Arbeitnehmer löschen\n" +
                    new String('-', 80).Replace("-", "-") +
                    "\n" +
                    "(9) Alle Fahrzeuge anzeigen\n" +
                    "(10) Fahrzeug hinzufügen\n" +
                    "(11) Fahrzeug suchen\n" +
                    //"(12) Fahrzeug löschen\n" +
                    "(x) Beenden\n";
                c.WriteLine(mainMenuItems);

                string auswahl = Convert.ToString(c.ReadLine().ToLower());

                switch (auswahl) {
                    case "1":
                        fahrt.viewFa();
                        break;
                    case "2":
                        fahrt.addFa();
                        break;
                    case "3":
                        fahrt.searchFa();
                        break;
                    case "4":
                        fahrt.deleteFa();
                        break;
                    case "5":
                        arbeitnehmer.viewAn();
                        break;
                    case "6":
                        arbeitnehmer.addAn();
                        break;
                    case "7":
                        arbeitnehmer.searchAn();
                        break;
                    case "8":
                        arbeitnehmer.deleteAn();
                        break;
                    case "9":
                        fahrzeug.viewFz();
                        break;
                    case "10":
                        fahrzeug.addFz();
                        break;
                    case "11":
                        fahrzeug.searchFz();
                        break;
                    case "12":
                        fahrzeug.deleteFz();
                        break;
                    case "x":
                        exit = true;
                        break;
                    default:
                        break;
                }

            } while (!exit);

        }

    }
}
