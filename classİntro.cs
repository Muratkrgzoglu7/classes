using System;

namespace classİntro
{
	class Program
	{
		static void Main(string[] args)
		{
			Kurs kurs1 = new Kurs();
			kurs1.KursAdi = "C#";
			kurs1.EgitmenAdi = "Engin Demiroğ";
			kurs1.İzlenmeOranı = 68;

			Kurs kurs2 = new Kurs();
			kurs2.KursAdi = "C++";
			kurs2.EgitmenAdi = "Murat Karagöz";
			kurs2.İzlenmeOranı = 88;

			Kurs kurs3 = new Kurs();
			kurs3.KursAdi = "JAVA";
			kurs3.EgitmenAdi = "Semih Güven";
			kurs3.İzlenmeOranı = 48;

			Kurs kurs4 = new Kurs();
			kurs4.KursAdi = "Python";
			kurs4.EgitmenAdi = "Betül Demir";
			kurs4.İzlenmeOranı = 72;

			//Console.WriteLine(kurs3.EgitmenAdi + " " + kurs2.EgitmenAdi);

			Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3,kurs4   };
			foreach ( Kurs kurs in kurslar)
			{
				Console.WriteLine(kurs.KursAdi+" = "+kurs.EgitmenAdi);
			}
		}
		class Kurs
		{
			public string KursAdi { get; set; }
			public string EgitmenAdi { get; set; }
			public int İzlenmeOranı { get; set; }
		}
	}
}
