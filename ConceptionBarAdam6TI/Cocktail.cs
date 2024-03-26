using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptionBarAdam6TI
{
     class Cocktail
    {
		private string _nom;

		public string Nom
		{
			get { return _nom; }
		}
		private double _contenance;

		public double Contenance
		{
			get { return _contenance; }
			set { _contenance = value; }
		}
		private int _recetteCocktail;

		public int RecetteCocktail
		{
			get { return _recetteCocktail; }
		}
		public Cocktail(string nom, double contenance, int recetteCocktail)
		{
			_nom = nom;
			_contenance = contenance;
			_recetteCocktail = recetteCocktail;
		}

	}
}
