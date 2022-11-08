using System;

namespace prjSchaltjahr
{

	// Formel Schaltjahr
	// ((jahr % 4 == 0) && (jahr % 100 != 0)) || (jahr % 400 == 0)

	public class SchaltjahrBerechnen
	{
		public static bool istSchaltjahr(int jahr)
		{
			return ((jahr % 4 == 0) && (jahr % 100 != 0)) || (jahr % 400 == 0);
		}       

	}
}
