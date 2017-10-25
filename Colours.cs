using System;
using System.Drawing;

namespace Forward_Calculator {
	
	///class that stores all the colours so they can be changed easily if needed
	public class Colours {
		
		public static Color background = Color.White;		
		public static Color stock      = Color.FromArgb(92,157,237); 
		public static Color dividend   = Color.FromArgb(252,206,84);
		public static Color calculator = Color.FromArgb(66,203,111);
		public static Rectangle rectangle = new Rectangle(8,30,430,390);
		public Colours() {
		}
	}
}
