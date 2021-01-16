using System;

namespace Metotlar
{
	class Program
	{
		static void Main(string[] args)
		{
			Urun urun1 = new Urun();
			urun1.Adi = "Elma";
			urun1.Fiyati = 15;
			urun1.Aciklama = "Amasya elmasi";

			Urun urun2 = new Urun();
			urun2.Adi = "Karpuz";
			urun2.Fiyati = 80;
			urun2.Aciklama = "Diyarbakir Karpuzu";

			Urun[] urunler = new Urun[] {urun1,urun2 };

			//type-safe
			foreach (Urun urun in urunler)
			{
				Console.WriteLine(urun.Adi);
				Console.WriteLine(urun.Fiyati);
				Console.WriteLine(urun.Aciklama);
				Console.WriteLine("--------------------");
			}

			Console.WriteLine("--------METOTLAR--------");

			SepetManager sepetManager = new SepetManager();
			sepetManager.Ekle(urun1);
			sepetManager.Ekle(urun2);


			sepetManager.Ekle2("Armut", "Yesil Armut", 12, 8);
			sepetManager.Ekle2("Elma", "Yesil Elma", 12, 8) ;
			sepetManager.Ekle2("Karpuz", "Kirmizi Armut", 12, 6) ;
		}
	}
}



