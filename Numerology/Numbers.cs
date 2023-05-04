using System;

namespace Numerology {
	public static class Numbers {

		public const int DefaultStep = 1000;
		public const int DefaultZeroPadding = 2;

		private static string format(double data, int zeroPadding, string letter) {
			if (zeroPadding == 0)
				return string.Format("{0:0.}{1}", data, letter);
			return string.Format("{0:0." + "".PadRight(zeroPadding, '#') + "}{1}", data, letter);
		}


		public static string ToNumerology(this uint data, int step = DefaultStep, int zeroPadding = DefaultZeroPadding){
			return ((double)data).ToNumerology(step, zeroPadding);
		}

		public static string ToNumerology(this int data, int step = DefaultStep, int zeroPadding = DefaultZeroPadding){
			return ((double)data).ToNumerology(step, zeroPadding);
		}

		public static string ToNumerology(this long data, int step = DefaultStep, int zeroPadding = DefaultZeroPadding){
			return ((double)data).ToNumerology(step, zeroPadding);
		}

		public static string ToNumerology(this ulong data, int step = DefaultStep, int zeroPadding = DefaultZeroPadding){
			return ((double)data).ToNumerology(step, zeroPadding);
		}

		public static string ToNumerology(this double data, int step = DefaultStep, int zeroPadding = DefaultZeroPadding){

			if (step < 1000)
				step = 1000;
			int s = 0;
			double d = data;
			while (d >= step) {
				s += 1;
				d = d / 1000;
			}

			return format((double)data / k_count(s), zeroPadding, k_name(s));
		}

		private static string k_name(int step){
			switch (step) {
				case 0:
					return "";
				case 1:
					return "K";
				case 2:
					return "M";
				case 3:
					return "B";
				case 4:
					return "T";
				case 5:
					return "q";
				case 6:
					return "Q";
				case 7:
					return "s";
				case 8:
					return "S";
				case 9:
					return "O";
				case 10:
					return "N";
				case 11:
					return "d";
				case 12:
					return "U";
				case 13:
					return "D";
				case 14:
					return "!";
				case 15:
					return "@";
				case 16:
					return "#";
				case 17:
					return "$";
				case 18:
					return "%";
				case 19:
					return "^";
				case 20:
					return "&";
				case 21:
					return "*";
				default:
					return "lot";
			}
		}

		private static double k_count(int step){
			return (double)Math.Pow(1000, step);
		}


	
	}
}

