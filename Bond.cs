using System;

namespace Forward_Calculator {
	
	///object that stores risk free rate bonds
	public class Bond {
		
		public int duration;
		public float interestRate;
		
		///constrctor for bond
		public Bond(int _duration, float _interestRate) {
			duration = _duration;
			interestRate = _interestRate;
		}
	}
}
