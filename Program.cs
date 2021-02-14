using System;

namespace dom
{


    class Dodaj
    {
        int a;
        int b;
        Dodaj(int a,int b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            return string.Format(a+b);
        }

    }


	class Odejmij
	{
		int a;
		int b;
		Odejmij(int a, int b)
		{
			this.a = a;
			this.b = b;
		}

		public override string ToString()
		{
			return string.Format(a - b);
		}

	}

	class pomnoz
	{
		int a;
		int b;
		pomnoz(int a, int b)
		{
			this.a = a;
			this.b = b;
		}

		public override string ToString()
		{
			return string.Format(a*b);
		}

	}


    class MainClass
    {
        public static void Main(string[] args)
        {
            Dodaj d1 = new Dodaj(4, 1);
            Console.WriteLine(d1);



        }
    }
}
