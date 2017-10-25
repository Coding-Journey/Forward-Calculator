using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Forward_Calculator {
	
	///forward calculator control
	public partial class Calculator : UserControl {
		public Calculator() {
			InitializeComponent();
			Init();
		}
		
		///starting function to set all the colours
		void Init() {

		}
		
		///shows the interest regions
		public void UpdateRegions(InterestRegion[] _regions) {
			Updn_InterestRegion.Items.Clear();
			foreach(InterestRegion _reg in _regions)
				Updn_InterestRegion.Items.Add(_reg.name);
		}
		
		///displays the forward prices
		public void UpdateForward(float[] _prices) {
			if(_prices != null)
				lbl_Bounds.Text = string.Format("Forward Price Calculated:\r\nLower Bound: {0}   Median: {1}   Upper Bound: {2}",
				                                _prices[0], _prices[1], _prices[2]);
		}
		
		void ValuesChanged(object sender, EventArgs e) {
			MainForm.Instance.timePeriod = Convert.ToInt32(txtb_TimePeriod.Text);
			//MainForm.Instance.regionName = Updn_InterestRegion.Text;
		}
	}
}
