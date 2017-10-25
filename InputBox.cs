using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forward_Calculator {
	public partial class InputBox : Form {
		public InputBox() {
			InitializeComponent();
			Init();
		}
		
		void Init() {
			this.BackColor = Colours.background;
		}
		
		void KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				try {
					FileHandling.SaveStockInformation (
						HtmlHandling.GetStockInformation(txt_StockName.Text)
					);
					StockViewer _stockViewer = new StockViewer(false, "");
					this.Dispose();
				}
				catch{MessageBox.Show("Enter a valid stock name or check internet connection");}
				
			}
		}
	}
}
