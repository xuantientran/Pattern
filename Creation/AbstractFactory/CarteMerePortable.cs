﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation.AbstractFactory
{
	public class CarteMerePortable : CarteMere
	{
		protected String modele;
		protected String chipset;

		public CarteMerePortable(String modele, String chipset)
				: base(modele, chipset)
		{
			this.modele = modele;
			this.chipset = chipset;
		}

		public override void afficheDetail()
		{
			Console.WriteLine("Carte mere pour portable cree : " + modele +
					" , chipset integre :" + chipset);
		}
	}
}
