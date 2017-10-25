using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Forward_Calculator {
	
	///control that allows user to enter dividend predictions along with frequency
	public partial class DividendTable : UserControl {
		public DividendTable() {
			InitializeComponent();
			Init();
		}
		
		
		///starting function that sets all the colours
		void Init() {
			this.BackColor = Colours.background;
//			for(int i = 0; i < this.Controls.Count; i++) {
//				this.Controls[i].BackColor = Colours.foreground;
//				this.Controls[i].ForeColor = Colours.primaryText;
//			}
		}
		
		void TextChanged(object sender, EventArgs e) {
			DividendPrediction[] _dividends = new DividendPrediction[txtb_Amount.Lines.Length];
			try {
				for(int i = 0; i < _dividends.Length; i++)
					_dividends[i] = new DividendPrediction(Convert.ToSingle(txtb_Prediction.Lines[i]) , Convert.ToSingle(txtb_Amount.Lines[i]));
				//MainForm.Instance.dividends = _dividends;
			}
			catch(Exception exc) {
				//MessageBox.Show(exc.Message);
			};
		}
	}
}
