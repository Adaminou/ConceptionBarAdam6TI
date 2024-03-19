using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptionBarAdam6TI
{
	 class Cave
    {
		private NbBouteille[] _bouteilles;

		public NbBouteille[] Bouteilles
		{
			get { return _bouteilles; }
			set { _bouteilles = value; }
		}
		public Cave(NbBouteille[] bouteilles)
		{
			_bouteilles = bouteilles;
		}
	}
}
