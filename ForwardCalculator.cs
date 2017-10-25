using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Forward_Calculator {
	public partial class ForwardCalculator : Form {
		public ForwardCalculator() {
			InitializeComponent();
			Init();
		}
		
		private void Init() {
			lbl_StockName.BackColor = Colours.calculator;
			lbl_Price.BackColor = Colours.calculator;
			lbl_Date.BackColor = Colours.calculator;
			
			StockInformation _stock = MainForm.Instance.stock;
			float[] _dividends = MainForm.Instance.dividendPrediction;
			int _days = MainForm.Instance.days;
			
			lbl_StockName.Text = _stock.name;
			lbl_Price.Text = _stock.price.ToString();
			lbl_Days.Text = _days.ToString() + " days";
			lbl_Date.Text = DateTime.Now.ToShortDateString();
			lbl_Dividends.Text = MainForm.Instance.divNumber.ToString() + " dividends";
			
			float[] _prices = Calculation.GetForwardPrices(_stock, _dividends, _days, MainForm.Instance.interestRegion);
			lbl_Bounds.Text = string.Format("Upper: {0}\r\n\r\nMedian: {1}\r\n\r\nLower: {2}",_prices[0],_prices[1],_prices[2]);
		}
		
		void picbClick(object sender, EventArgs e) {
			switch(MessageBox.Show("Save Calculation as picture?", "Forward Calculator", MessageBoxButtons.YesNo)) {
					case DialogResult.Yes: {
						saveF_Forward.ShowDialog();
						break;
					}
					case DialogResult.No: {
						break;
					}
					
			}
		}
		
		void SaveF_ForwardFileOk(object sender, System.ComponentModel.CancelEventArgs e) {
			ScreenCapture sc = new ScreenCapture();
			Bitmap bmpImage = new Bitmap(sc.CaptureWindow(this.Handle));
			Bitmap newImage = new Bitmap(Colours.rectangle.Width, Colours.rectangle.Height);
			Graphics g = Graphics.FromImage(newImage);
			g.DrawImage(bmpImage, -Colours.rectangle.X, -Colours.rectangle.Y);
			g.Dispose();
			newImage.Save(saveF_Forward.FileName, ImageFormat.Png);
		}
		
		void ForwardCalculatorLoad(object sender, EventArgs e) {
			float[] _prices = Calculation.GetForwardPrices(MainForm.Instance.stock, MainForm.Instance.dividendPrediction, MainForm.Instance.timePeriod, MainForm.Instance.interestRegion);
		}
	}
}
