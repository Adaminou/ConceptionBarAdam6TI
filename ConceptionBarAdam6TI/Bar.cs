using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptionBarAdam6TI
{
     class Bar
    {
		private Bouteille[] _bouteilles;

		public Bouteille[] bouteilles
		{
			get { return _bouteilles; }
			set { _bouteilles = value; }
		}

		public Bar(Bouteille[] bouteilles)
		{
			_bouteilles = bouteilles;
		}
	}
}
