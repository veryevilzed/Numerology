using System;
using Numerology;

namespace Test {
	class MainClass {
		public static void Show(double d) {
			Console.WriteLine("{0} = {1}",  d , d.GetNumerology());
		}

		public static void Main(string[] args) {
			Show(123);
			Show(12345);
			Show(12345678);
			Show(12345678E+3);
			Show(12345678E+6);
			Show(12345678E+9);
			Show(12345678E+12);
			Show(12345678E+15);
			Show(12345678E+18);
			Show(12345678E+21);
			Show(12345678E+24);
			Show(12345678E+27);
			Show(12345678E+30);


		}
	}
}
