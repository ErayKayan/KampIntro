using System;

namespace KampIntro
{
	class Program
	{
		private const string Value = "";

		static void Main(string[] args)
		{
			// type safety = tip guvenligi
			// Do not repeat yourself
			string kategoriEtiketi = "Kategoriler";
			int ogrenciSayisi = 32000;
			double faizOrani = 1.45;
			bool sistemeGirisYapmisMi = true;
			double dolarDun = 7.35;
			double dolarBugun = 7.35;

			if (dolarDun>dolarBugun)
			{
				Console.WriteLine("Azalis Butonu");

			}

			else if (dolarDun < dolarBugun)
			{
				Console.WriteLine("Artis Butonu");

			}

			else 
			{
				Console.WriteLine("Degismedi");

			}

			if (sistemeGirisYapmisMi == true)
			{
				Console.WriteLine("Kullanici ayarlari butonu");
			}

			else 
			{
				Console.WriteLine("Giris yap butonu");
			}

									
		}
	}
}
 