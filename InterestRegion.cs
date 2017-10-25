using System;

namespace Forward_Calculator {

	///object that holds region name and the bonds associated with it
	public class InterestRegion {
		
		public string name;
		public Bond[] bonds;
		
		public InterestRegion(string _name, Bond[] _bonds) {
		name = _name;
		bonds = _bonds;
		}
		
		public InterestRegion() {
			name = "";
			bonds = null;
		}
	}
}
