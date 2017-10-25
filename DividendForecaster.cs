using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Forward_Calculator {
	public partial class DividendForecaster : Form {
		
		
		
		private bool same;
		private string[] dates;
		private List<float[]> predictions = new List<float[]>();
		
		public DividendForecaster() {
			InitializeComponent();
			Init();
		}
		
		private void Init() {
			lbl_DividendForecaster.BackColor = Colours.dividend;
			radiob_Same.BackColor = Colours.dividend;
			radiob_Different.BackColor = Colours.dividend;
			int _days = MainForm.Instance.days;
			try { dates = DateHandling.GetDatesWithinTime(MainForm.Instance.stock.dates, _days);}
			catch {
				MessageBox.Show("Cannot enter dividends until stock and timescale have been confirmed");
				this.Close();
				return;
			}
			MainForm.Instance.divNumber = dates.Length;
			this.Show();
			combob_Date.Items.AddRange(dates);
			foreach(string date in dates) predictions.Add(new float[3]);
		}
		
		void DividendForecasterFormClosing(object sender, FormClosingEventArgs e) {
			ScreenCapture sc = new ScreenCapture();
			Bitmap bmpImage = new Bitmap(sc.CaptureWindow(this.Handle));
			Bitmap newImage = new Bitmap(Colours.rectangle.Width, Colours.rectangle.Height);
			Graphics g = Graphics.FromImage(newImage);
			g.DrawImage(bmpImage, -Colours.rectangle.X, -Colours.rectangle.Y);
			g.Dispose();
			MainForm.Instance.UpdateDividend(newImage);
			FileHandling.SaveImage(newImage,Application.StartupPath + "\\TEMPdividend.png", ImageFormat.Png);
			this.Dispose();
				
			
		}
		
		void PicbDividendClick(object sender, EventArgs e) {
			System.Diagnostics.Process.Start("http://google.com");
		}
		
		void ButtonClicked(object sender, EventArgs e){
			if(radiob_Different.Checked) same = false;
			else if(radiob_Same.Checked) same = true;
			combob_Date.Enabled = !same;
		}
		
		void Txtb_TextChanged(object sender, EventArgs e) {
			int shortest = (txtb_Prediction.Lines.Length < txtb_Amount.Lines.Length)? txtb_Prediction.Lines.Length : txtb_Amount.Lines.Length;
			DividendPrediction[] _dividends =  DividendPrediction.ConvertStringArray(txtb_Prediction.Lines, txtb_Amount.Lines, shortest);
			if(_dividends == null) {
				MessageBox.Show("Not in correct format");
				return;
			}
			if(same) {
				MainForm.Instance.dividendPrediction = Calculation.GetBounds(_dividends);
			}
			else {
				if(combob_Date.SelectedIndex == -1) {
					MessageBox.Show("Select a date or same");
					return;
				}
				predictions[combob_Date.SelectedIndex] = Calculation.GetBounds(_dividends);
				MainForm.Instance.dividendPrediction = Calculation.GetAverageBounds(predictions);
			}
			if(MainForm.Instance.dividendPrediction != null) {
				float[] _bounds = MainForm.Instance.dividendPrediction;
				for(int i = 0; i < _bounds.Length; i++)
					_bounds[i] = (float)Math.Round(_bounds[i], 3);
				lbl_Upper.Text  = string.Format("Upper: {0}", _bounds[2]);
				lbl_Median.Text = string.Format("Median: {0}", _bounds[1]);
				lbl_Lower.Text  = string.Format("Lower: {0}", _bounds[0]);
			}
		}
	}
}
