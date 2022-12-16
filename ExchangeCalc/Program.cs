using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c = System.Console;

namespace ExchangeCalc {
    internal class Program {
        static void Main(string[] args) {

            double inputAmount = 4.36;
            double centFactor = 100;
            double[] coins = new double[] { 2.0, 1.0, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01 };
            double inputCentAmount = inputAmount * centFactor;
            double coinInCents, remainder, nextValue = 0;

            for (int i = 0; coins.Length != i; i++) {

                coinInCents = coins[i] * centFactor;
                remainder = inputCentAmount % coinInCents;
                nextValue = inputCentAmount - remainder;

                if (nextValue != 0) {
                    int coinsOut = (int)(nextValue / coinInCents);
                    inputCentAmount = (float)remainder;
                    c.WriteLine("{0} x {1} EUR", coinsOut, String.Format("{0:0.00}", Convert.ToDecimal(coins[i])));
                }

            }

            c.ReadKey();

        }
    }
}
