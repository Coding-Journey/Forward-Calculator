using System;

namespace Forward_Calculator {
	
	///object used to temporarily store all the data for a day of a stock
	public class TimeInterval {
		
		public string date;
		public float dividend;
		public float close;
		
		//just getting the information because it's on the same page		
		public float open;
		public float high;
		public float low;
		public float volume;
		//not actually needed but could be useful later on
			
		///constructor to make a new TimeInterval object 
		public TimeInterval(string _date, float _open, float _high, float _low, float _close, float _volume, float _dividend) {
			date = _date;
			open = _open;
			high = _high;
			low = _low;
			close = _close;
			volume = _volume;
			dividend = _dividend;
		}
	}
}
