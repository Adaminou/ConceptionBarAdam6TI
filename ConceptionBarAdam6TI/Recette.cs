﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptionBarAdam6TI
{
     class Recette
    {
		private Portion[] _ingredients;

		public Portion[] Ingredients
		{
			get { return _ingredients; }
		}
		public Recette(Portion[] ingredients)
		{
			_ingredients = ingredients;
		}
	}
}
