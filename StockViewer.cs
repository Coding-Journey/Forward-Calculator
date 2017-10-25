using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace Forward_Calculator {
	public partial class StockViewer : Form {
		private string filename;
		private static bool newStock;
		
		public StockViewer(bool _newStock, string _fileName) {
			newStock = _newStock;
			filename = _fileName;
			InitializeComponent();
			Init();
		}
		
		private void Init() {
			this.BackColor = Colours.background;
			lbl_StockName.BackColor = Colours.stock;
			lbl_Price.BackColor = Colours.stock;
			lbl_Dividend.BackColor = Colours.stock;
			openF_stock.InitialDirectory = Application.StartupPath;
			lbl_StockName.Text = filename;
			filename += ".xml";
			
			if(!newStock && filename == ".xml") {
				openF_stock.ShowDialog();
				this.Show();
			}
			else if(newStock) {
				MessageBox.Show("Enter Stock Ticker Name");
				InputBox _inputBox = new InputBox();
				_inputBox.Show();
				this.Dispose();
			}
			else if(!newStock) {
				UpdateStock(filename);
				this.Show();
			}
			
		}
		
		private void OpenF_stockFileOk(object sender, System.ComponentModel.CancelEventArgs e) {
			UpdateStock(openF_stock.FileName);
		}
		
		private void Picb_RefreshClick(object sender, EventArgs e) {
			try {
				FileHandling.SaveStockInformation (
					HtmlHandling.GetStockInformation(lbl_StockName.Text)
				);
			}
			catch{MessageBox.Show("Enter a valid stock name or check internet connection");}
			StockViewer _stockViewer = new StockViewer(false, lbl_StockName.Text);
			this.Dispose();

			
		}
		
		private void UpdateStock(string _file) {
			StockInformation _stock = FileHandling.LoadStock(_file);
			lbl_StockName.Text = _stock.name;
			lbl_Price.Text     = Convert.ToString(_stock.price);
			lbl_Dividend.Text  = Convert.ToString(_stock.dividend);
			picb_Chart.Load(HtmlHandling.GetChartAddress(_stock.name));
			MainForm.Instance.stock = _stock;
		}
		
		void StockViewerFormClosing(object sender, FormClosingEventArgs e) {
			ScreenCapture sc = new ScreenCapture();
			Bitmap bmpImage = new Bitmap(sc.CaptureWindow(this.Handle));
			Bitmap newImage = new Bitmap(Colours.rectangle.Width, Colours.rectangle.Height);
			Graphics g = Graphics.FromImage(newImage);
			g.DrawImage(bmpImage, -Colours.rectangle.X, -Colours.rectangle.Y);
			g.Dispose();
			MainForm.Instance.UpdateStock(1);
			FileHandling.SaveImage(newImage,Application.StartupPath + "\\TEMPstock.png", ImageFormat.Png);			
			MainForm.Instance.UpdateStock();
			this.Dispose();
		}
	}
}
