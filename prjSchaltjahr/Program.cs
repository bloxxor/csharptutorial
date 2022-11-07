using System;

using c = System.Console;

namespace prjSchaltjahr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int intJahr = int.Parse(c.ReadLine());
            bool richtig = SchaltjahrBerechnen.istSchaltjahr((int)intJahr);

            c.WriteLine("Jahr eingeben: ");
            c.Write(": ");

            if (richtig)
            {
                c.WriteLine("{0} ist ein Schaltjahr", intJahr);
            } else
            {
                c.WriteLine("{0} ist kein Schaltjahr", intJahr);
            }

            c.ReadKey();

        }
    }
}
