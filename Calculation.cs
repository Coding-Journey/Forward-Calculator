using System;
using System.Linq;
using System.Collections.Generic;

namespace Forward_Calculator {

	///class that contains all calculation functions
	public class Calculation {
		public Calculation() {
		}
		
		///calculates forward price bounds given price, dividend predictions, time until maturity and interest region
		public static float[] GetForwardPrices(StockInformation _stock, float[] _dividends, int _timeUntilMaturity, InterestRegion _region) {
			float[] prices = new float[3];
			float riskFreeRate = GetIntrestRate(_region, _timeUntilMaturity);
			for(int i = 0; i < _dividends.Length; i++)
				prices[i] = GetForwardPrice(_stock, _dividends[i], _timeUntilMaturity, riskFreeRate);
			return prices;			
		}
		
		//calculates indivdual forward price
		private static float GetForwardPrice(StockInformation _stock, float dividend, int days, float riskFreeRate) {
			//initial 
			double _forward = _stock.price * Math.Exp(riskFreeRate/100 * days);
			int[]  _daysUntilPayments = new int[_stock.dates.Length]; //array to store days until dividend payment
			
			//loops through all dividends and gets the days until the payment
			for(int i = 0; i < _daysUntilPayments.Length; i++)
				_daysUntilPayments[i] = DateHandling.DaysUntil(_stock.dates[i]);
			
			//loops through checking if dividend will be paid within time, if so it takes payment off price
			for(int i = 0; i < _daysUntilPayments.Length; i++)
				if(_daysUntilPayments[i] < days) 
					_forward -= dividend * Math.Exp(riskFreeRate *(days - _daysUntilPayments[i]));
			
			return (float)_forward;
		}
		
		///interpolates to find an interest rate for the specified 
		private static float GetIntrestRate(InterestRegion region, int days) {
			if(region.bonds == null) return -1;
			Bond _lower = GetNearestBond(region.bonds, days, "down");
			Bond _upper = GetNearestBond(region.bonds, days, "up"  );
			return Interpolate(_lower.duration, _upper.duration, _lower.interestRate, _upper.interestRate, days);
		}
		
		///returns nearest bond to specified amount of days with bias assigned by either up or down rounding
		private static Bond GetNearestBond(Bond[] _bonds, int _days, string _roundingMethod) {
			if(_bonds == null) return null;
			//creating a list as they are easier to use in this instance
			List<Bond> _bondList = new List<Bond>();
			_bondList.AddRange(_bonds);
			
			bool _found = false; //to stop loop when bond has been found
			int _index = -1; //integar for the index of the bond
			int _count = _bonds.Length; //value to make sure it doesn't loop forever
			
			int added = _days;
			//loops through finding nearest bond
			while(!_found) {
				if(added > _bonds[_bonds.Length - 1].duration) break;
				_index = _bondList.FindIndex(f => f.duration == added);
				if(_index != -1) _found = true;
				else added++;
			}
			if(_found) {
				switch(_roundingMethod) {
						case "up"  : {
							return _bonds[_index];
						}
						case "down": {
							if(_index <= 0) _index = 1;
							return _bonds[_index-1];
						}
				}
			}
			return null;
		}
		
		///interpolates given lower bounds, upper bounds and time duration
		private static float Interpolate(int lower1, int upper1, float lower2, float upper2, int x) {
			//rearanged interpolation formula
			return ((((upper2 - lower2) * (x - lower1)) / (upper1 - lower1)) + lower2);
		}
		
		///returns the lower, median and upper bound, aswell as ignoring any outliers for the dividend predictions
		public static float[] GetBounds(DividendPrediction[] _dividends) {
			//variables to store important numbers
			float sumF    = 0; //total number of predictions
			float sumFX   = 0; //sum of frequency * dividend
			float sumFXSQ = 0; //sum of frequency squared * dividend
			
			//list to store all dividends sorted and in their respective frequencies
			List<float> _sortedDividends = new List<float>();
			
			if(_dividends == null) return null;
			//goes through all the predictions
			foreach(DividendPrediction _div in _dividends) {
				if(_div == null) return null;
				sumF    += _div.amount;
				sumFX   += _div.amount * _div.dividend;
				sumFXSQ	+= _div.amount * _div.dividend * _div.dividend;			
				
				//adding the dividend to the list, based on amount of people that predicted it
				for(int i = 0; i < _div.amount; i++)
					_sortedDividends.Add(_div.dividend);
			}
			
			//sorting the list into ascending order
			_sortedDividends = _sortedDividends.OrderByDescending(x => x).Reverse().ToList();
			
			//calculating sd
			float standardDeviation = GetStandardDeviation(sumFXSQ, sumF, sumFX);
			
			//calculating average value
			float mean = sumFX / sumF;
			
			//seeing if the values lie withing 1 sigma (1 standard deviation)
			//if it is an outlier, entry is deleted
			for(int i = 0; i < _sortedDividends.Count; i++)
				if (
					Math.Abs(mean - _sortedDividends[i]) > standardDeviation
				)
					_sortedDividends.Remove(_sortedDividends[i]);
			
			//creating array to store lower, median and upper bound
			float[] _bounds = new float[3];
			if(_sortedDividends.Count < 3) return null;
			_bounds[0] = _sortedDividends[(int)Math.Round((decimal)(((_sortedDividends.Count + 1) / 4) - 1))]; //lower bound, + and - of 1 is to convert from computer to real life numbers
			_bounds[1] = _sortedDividends[(int)Math.Round((decimal)((_sortedDividends.Count + 1) / 2) - 1)]; //median
			_bounds[2] = _sortedDividends[(int)Math.Round((decimal)(((_sortedDividends.Count + 1) / 4) * 3) -1)]; //upper bound
			
			return _bounds;
		}
		
		public static float[] GetAverageBounds(List<float[]> Bounds) {
			float[] _bounds = new float[3];
			int count = Bounds.Count;
			for(int i = 0; i < Bounds.Count; i++) {
				if(Bounds[i] == null) return null;
				_bounds[0] += Bounds[i][0];
				_bounds[1] += Bounds[i][1];
				_bounds[2] += Bounds[i][2];
				if(Bounds[i][0] == 0) count--;
			}
			_bounds[0] /= count;
			_bounds[1] /= count;
			_bounds[2] /= count;
			
			return _bounds;
		}
		
		///calculates standard deviation
		private static float GetStandardDeviation(float sumFXSQ, float sumF, float sumFX) {
			//calculating variance as sd = root(variance)
			float variance = (sumFXSQ / sumF) - ((sumFX / sumF) * (sumFX / sumF));
			return (float)Math.Sqrt(variance);
		}
	}
}
