using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptionBarAdam6TI
{
     class Bouteille
    {
		private Liquide _contenu;

		public Liquide Contenu
		{
			get { return _contenu; }
			set { _contenu = value; }
		}

		private double _contenance;

		public double Contenance
		{
			get { return _contenance; }
			set { _contenance = value; }
		}
		public Bouteille(Liquide contenu)
		{
			_contenu = contenu;
		}
	}
}
