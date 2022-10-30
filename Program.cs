using System;

namespace Most
{
	public interface ITelewizor
	{

		int Kanal { get; set; }
		
		void ZmienKanal(int kanal);

	}



	public class TvLg : ITelewizor
	{

		public TvLg()
		{
			this.Kanal = 1;
		}

		public int Kanal { get; set; }

		public void Wlacz()
		{
			Console.WriteLine("włączam się.");
		}

		public void Wylacz()
		{
            Console.WriteLine("wyłączam się.");
		}

		public void ZmienKanal(int kanal)
		{
            Console.WriteLine("zmieniam kanał: "+kanal);
		}

	}



	public class TvXiaomi : ITelewizor
	{

		public TvXiaomi()
		{
			this.Kanal = 1;
		}
		public int Kanal { get; set; }

		public void Wlacz()
		{
			Console.WriteLine("Telewizor Xiaomi włączony.");
		}

		public void Wylacz()
		{
            Console.WriteLine("Telewizor Xiaomi ");
		}

		public void ZmienKanal(int kanal)
		{
			Kanal= kanal;
			//
		}

	}



	public abstract class PilotAbstrakcyjny
	{

		private ITelewizor tv;

		public PilotAbstrakcyjny(ITelewizor tv)
		{
			//
			//
		}
		public void Wlacz()
        {
			//
        }
		public void Wylacz()
		{
			//
		}
		public void ZmienKanal(int kanal)
		{
			//
			//
		}

	}



	public class PilotHarmony : PilotAbstrakcyjny
	{

		public PilotHarmony(ITelewizor tv) : base(tv) { }

		public void DoWlacz()
		{
			Console.WriteLine("włącz telewizor...");
			Wlacz();
		}
		public void DoZmienKanal(int kanal)
        {
            Console.WriteLine("zmienia kanał...");
			ZmienKanal(kanal);
        }
		public void DoWylacz()
        {
            Console.WriteLine("wyłącz telewizor...");
			Wylacz();
        }

		//
		//

	}

	public class PilotLG : PilotAbstrakcyjny
	{
		public PilotLG(ITelewizor tv) : base(tv) { }

		public void DoWlacz()
		{
			Console.WriteLine("włącz telewizor...");
			Wlacz();
		}
		public void DoZmienKanal(int kanal)
		{
			Console.WriteLine("zmienia kanał...");
			ZmienKanal(kanal);
		}
		public void DoWylacz()
		{
			Console.WriteLine("wyłącz telewizor...");
			Wylacz();
		}

	}



	class MainClass
	{
		public static void Main(string[] args)
		{

			ITelewizor tv = new TvLg();
			PilotHarmony pilotHarmony = new PilotHarmony(tv);
			PilotLG pilotLG = new PilotLG(tv);
			TvLg lg=new TvLg();
            //
            //

            Console.Write("Pilot Harmony - ");
			pilotHarmony.DoWlacz();

            Console.Write("Telewizor LG - ");
			lg.Wlacz();

            Console.WriteLine("Sprawdź kanał - bieżący kanał: "+ tv.Kanal);

            Console.Write("Pilot LG - ");
			pilotLG.DoZmienKanal(100);

            Console.Write("Telewizor LG - ");
			lg.ZmienKanal(100);

			Console.WriteLine("Sprawdź kanał - bieżący kanał: " + tv.Kanal);


			Console.WriteLine("Kanał: " + tv.Kanal);
			pilotLG.DoZmienKanal(100);
			Console.WriteLine("Kanał: " + tv.Kanal);
			pilotHarmony.DoWylacz();

		}
	}
}