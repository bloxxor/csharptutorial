using System;
using c = System.Console;

namespace prjFaBu2 {
    public class Menu {

        // Menus
        public static void mainMenu() {

            bool exit = false;

            do {

                c.Clear();

                Employee employee = new Employee();
                Car car = new Car();
                Ride ride = new Ride();

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

                string selection = Convert.ToString(c.ReadLine().ToLower());

                switch (selection) {
                    case "1":
                        ride.viewFa();
                        break;
                    case "2":
                        ride.addFa();
                        break;
                    case "3":
                        ride.searchFa();
                        break;
                    case "4":
                        ride.deleteFa();
                        break;
                    case "5":
                        employee.viewAn();
                        break;
                    case "6":
                        employee.addAn();
                        break;
                    case "7":
                        employee.searchAn();
                        break;
                    case "8":
                        employee.deleteAn();
                        break;
                    case "9":
                        car.viewFz();
                        break;
                    case "10":
                        car.addFz();
                        break;
                    case "11":
                        car.searchFz();
                        break;
                    case "12":
                        car.deleteFz();
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
