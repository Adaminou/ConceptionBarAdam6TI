using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptionBarAdam6TI
{
     class Portion
    {
		private Liquide _contenu;

		public Liquide Contenu
		{
			get { return _contenu; }
		}
		private double _quantite;

		public double Quantite
		{
			get { return _quantite; }
		}

		public Portion(Liquide contenu, double quantite)
		{
			_contenu = contenu;
			_quantite = quantite;
		}
	}
}
