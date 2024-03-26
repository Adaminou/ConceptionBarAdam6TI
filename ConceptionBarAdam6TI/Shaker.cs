using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConceptionBarAdam6TI
{
     class Shaker
    {
		private double _contenanceMax;

		public double contenanceMax
		{
			get { return _contenanceMax; }
		}
		private Portion[] _contenu;

		public Portion[] Contenu
		{
			get { return _contenu; }
			set { _contenu = value; }
		}

		private bool _propre;

		public bool Propre
		{
			get { return _propre; }
			set { _propre = value; }
		}
		public Shaker(double contenanceMax, Portion[] Contenu, bool propre)
		{
			_contenanceMax = contenanceMax;
			_contenu = Contenu;
			_propre = propre;
		}
		public bool AjouterPortion (Portion portion)
		{

		}

		public Cocktail MelangerContenu (Portion portion)
		{

		}

	}
}
