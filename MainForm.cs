using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Forward_Calculator {
	public partial class MainForm : Form {
		
		public int days;
		public StockInformation stock {
			get { return _stock; }
			set { _stock = value;}
		}
		private StockInformation _stock; //stores stock information
			
		private InterestRegion[] regions; //stores interest region information
		
		public static MainForm Instance;
		
		public int divNumber;
		
		//number that stores where the stock lies in the list
		//get and set allows other classes to access
		private int _index;
		public int index {
			get { return _index;}
			set {
				_index = value;
				UpdateViewer();
				UpdateForward();
			}
		}
		
		//value for length of forward in days
		private int _timePeriod;
		public int timePeriod {
			get { return _timePeriod; }
			set { 
				_timePeriod = value;
				UpdateForward();}
		}
		
		//current region
		public InterestRegion interestRegion;
		
		//dividends
		private float[] _dividendPrediction;
		public float[] dividendPrediction {
			get {return _dividendPrediction; }
			set {
				_dividendPrediction = value;
				//UpdateForward();
			}
		}
				
		public MainForm() {
			InitializeComponent();
			Init();
		}
		
		
		void Init() {
			Instance = this;
			this.BackColor = Colours.background;
			interestRegion = FileHandling.LoadRegions()[0];
//			
//			online = connection_Viewer.TestConnection();
//			
//			//setting colours
//			this.BackColor = Colours.background;
//			txt_NewStockName.BackColor = Colours.foreground;
//			txt_NewStockName.ForeColor = Colours.primaryText;
//			btn_Save.BackColor = Colours.foreground;
//			btn_Save.ForeColor = Colours.primaryText;
//			
//			
//			
//			stocks = FileHandling.Loadstocks(Application.StartupPath);  //loading stocks
			regions = FileHandling.LoadRegions(); //loading regions
//			
//			//filling stock list
//			StockList _stockViewer = new StockList(stocks);
//			_stockViewer.Dock = DockStyle.Fill;
//			pnl_StockList.Controls.Clear();
//			pnl_StockList.Controls.Add(_stockViewer);
//			pnl_StockList.BackColor = Colours.background;
//			(pnl_StockList.Controls[0].Controls[0] as ImprovedListBox).Items.AddRange(StockList.GetNames(stocks));
//			
//			calculator_Forward.UpdateRegions(regions); //showing regions in box
		}
		
		
		private void UpdateViewer() {
//			online = connection_Viewer.TestConnection();
//			stock_Viewer.UpdateLabels(stocks[index]);
//			this.Refresh();
//			if(online) stock_Viewer.UpdateChart(HtmlHandling.GetChartAddress(stocks[index].name));
//			
		}
		
		private void UpdateForward() {
//			InterestRegion region = new InterestRegion();
//			foreach(InterestRegion _reg in regions)
//				if(_reg.name == regionName)
//					region = _reg;
//			float[] _prices = Calculation.GetForwardPrices(stocks[index], dividends, timePeriod, region);
//			for(int i = 0; i < _prices.Length; i++)
//				_prices[i] = (float)Math.Round(_prices[i], 2);
//			calculator_Forward.UpdateForward(_prices);
		}

		///click event for pictures, opening interfaces
		void OptionSelected(object sender, EventArgs e) {
			switch((sender as PictureBox).Name) {
					case "picb_SelectStock": {
						switch(MessageBox.Show("Open Existing Stock?","StockViewer", MessageBoxButtons.YesNoCancel)) {
								case DialogResult.Yes: {
									StockViewer _stockViewer = new StockViewer(false, "");
									break;	
								}
								case DialogResult.No: {
									StockViewer _stockViewer = new StockViewer(true, "");
									break;
								}
								case DialogResult.Cancel : break;
						}
						break;
					}
					case "picb_DividendForecast": {
						DividendForecaster _dividendForecaster = new DividendForecaster();
						break;
					}
					case "picb_CalculateForward": {
						if(dividendPrediction == null || stock == null) {
							MessageBox.Show("Choose a stock and enter dividends before calculating price");
							return;
						}
						ForwardCalculator _forwardCalculator = new ForwardCalculator();
						_forwardCalculator.Show();
						break;
					}
			}
		}
		
		public void UpdateStock() {
			picb_SelectStock.Image = new Bitmap(Image.FromFile("TEMPstock.png"));
		}
		
		public void UpdateStock(int i) {
			picb_SelectStock.Image = new Bitmap(100,100);
		}
		
		public void UpdateDividend() {
			picb_DividendForecast.Image = new Bitmap(Image.FromFile("TEMPdividend.png"));
		}
		
		public void UpdateDividend(Bitmap _img) {
			picb_DividendForecast.Image = new Bitmap(100,100);
			picb_DividendForecast.Image = new Bitmap(_img);
			this.Refresh();
		}
		
		void UpDn_DaysValueChanged(object sender, EventArgs e) {
			days = (int)upDn_Days.Value;
		}
	}
}
