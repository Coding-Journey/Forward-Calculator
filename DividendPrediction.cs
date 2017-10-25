using System;

namespace Forward_Calculator {

	///object to store dividend predictions
	public class DividendPrediction {
		
		public float dividend;
		public float amount;
		
		public DividendPrediction(float _dividend, float _amount) {
			dividend = _dividend;
			amount = _amount;
		}
		
		public static DividendPrediction[] ConvertStringArray(string[] _predictions, string[] _amounts, int _length) {
			for(int i = 0; i < _length; i++) {
				if(_predictions[i] == "") _predictions[i] = "0";
				if(_amounts[i] == "") _amounts[i] = "0";
			}
			DividendPrediction[] _predicts = new DividendPrediction[_length];
			for(int i = 0; i < _length; i++) {
				try {
					_predicts[i] = new DividendPrediction(
						(float)Convert.ToDecimal(_predictions[i]),
						(float)Convert.ToDecimal(_amounts[i])
					);
				}
				catch { return null;}
			}
			return _predicts;
		}
	}
}
