using System;

namespace Forward_Calculator {
	
	///Object that holds information about a stock
	public class StockInformation {
		
		public string   name;		
		public float    price;
		public float    dividend;
		public string[] dates; 
		
		public StockInformation(string _name, float _price, float _dividend, string[] _dates) {
			name = _name;
			price = _price;
			dividend = _dividend;
			dates = _dates;		
		}
	}
}
