using System;

namespace Most
{
	public interface ITelewizor
	{

		int Kanal { get; set; }
		
		void ZmienKanal(int kanal);

		void SprawdzKanal();

		void Wlacz();

		void Wylacz();

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
			Console.WriteLine("Telewizor LG - włączam się.");
		}

		public void Wylacz()
		{
            Console.WriteLine("Telewizor LG - wyłączam się.");
		}

		public void ZmienKanal(int kanal)
		{
            Console.WriteLine("Telewizor LG - zmieniam kanał: " + kanal);
			this.Kanal = kanal;
		}
		public void SprawdzKanal()
		{
			Console.WriteLine("Sprawdź kanał - bieżący kanał: "+this.Kanal);
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
			Console.WriteLine("Telewizor Xiaomi - Telewizor Xiaomi włączony.");
		}

		public void Wylacz()
		{
            Console.WriteLine("Telewizor Xiaomi - Telewizor Xiaomi ");
		}

		public void ZmienKanal(int kanal)
		{
            Console.WriteLine("Telewizor Xiaomi - zmieniam kanał: " + kanal);
            this.Kanal= kanal;
		}
        public void SprawdzKanal()
        {
            
            Console.WriteLine("Sprawdź kanał - bieżący kanał: " + this.Kanal);
			
        }

    }



	public abstract class PilotAbstrakcyjny
	{

		private ITelewizor tv;
		

		public PilotAbstrakcyjny(ITelewizor tv)
		{
			this.tv = tv;
		}
		public void Wlacz()
        {
			tv.Wlacz();
        }
		public void Wylacz()
		{
			tv.Wylacz();
		}
		public void ZmienKanal(int kanal)
		{
			
			tv.ZmienKanal(kanal);
			
		}

	}



	public class PilotHarmony : PilotAbstrakcyjny
	{

		public PilotHarmony(ITelewizor tv) : base(tv) { }
		TvLg tv=new TvLg();

		public void DoWlacz()
		{
			Console.WriteLine("Pilot Harmony - włącz telewizor...");
			Wlacz();
		}
		public void DoZmienKanal(int kanal)
        {
            Console.WriteLine("Pilot Harmony - zmienia kanał...");
			ZmienKanal(kanal);
			

        }
		public void DoWylacz()
        {
            Console.WriteLine("Pilot Harmony - wyłącz telewizor...");
			Wylacz();
        }

		//
		//

	}

	public class PilotLG : PilotAbstrakcyjny
	{
		public PilotLG(ITelewizor tv) : base(tv) { }
		TvLg tv=new TvLg();

		public void DoWlacz()
		{
			Console.WriteLine("Pilot LG - włącz telewizor...");
			Wlacz();
		}
		public void DoZmienKanal(int kanal)
		{
			Console.WriteLine("Pilot LG - zmienia kanał...");
			ZmienKanal(kanal);

		}
		public void DoWylacz()
		{
			Console.WriteLine("Pilot LG - wyłącz telewizor...");
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
            
            			
			pilotHarmony.DoWlacz();
            tv.SprawdzKanal();
            pilotLG.DoZmienKanal(100);
            tv.SprawdzKanal();
            pilotHarmony.DoWylacz();
			
		}
	}
}


