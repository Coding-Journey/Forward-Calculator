using System;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Drawing;
using System.Net;

namespace Forward_Calculator {
	
	///class that handles all interactions with the internet
	public class HtmlHandling {
		
		public HtmlHandling() {
		}
		
		///returns address given stock name, start date, end date and page number 
		public static string GetAddress(string _stockName, string _startDate, string _endDate, int _pageNumber) {
			//would be changed if getting info from another website
			return string.Format("https://uk.finance.yahoo.com/q/hp?s={0}&a={1}&b={2}&c={3}&d={4}&e={5}&f={6}&g={7}&z=66&y={8}",
			                                _stockName,  
			                                  _endDate.Split('/')[1],   _endDate.Split('/')[0],   _endDate.Split('/')[2],
			                                _startDate.Split('/')[1], _startDate.Split('/')[0], _startDate.Split('/')[2],
			                                "d",
			                                _pageNumber * 66);
		}
		
		///returns stock information of a specified stock
		public static StockInformation GetStockInformation(string _stockName) {
			TimeInterval[] _timeIntervals = GetTimeIntervals(_stockName); //gets all info
			
			//returns useful stock info
			return (
				GetValidInformation(_stockName, _timeIntervals)
			);
			
		}
		
		///returns stock information object, containing useful data
		private static StockInformation GetValidInformation(string _stockName, TimeInterval[] _timeIntervals) {
			return (
				new StockInformation (
					_stockName,
					_timeIntervals[_timeIntervals.Length - 1].close,
					GetLastDividend(_timeIntervals),
					GetDividendDates(_timeIntervals)
				)
			);
		}
		
		///returns last dividend payment
		private static float GetLastDividend(TimeInterval[] _timeIntervals) {
			//loops through all the days backwards from today
			for(int i = _timeIntervals.Length - 1; i >= 0; i--)
				if(_timeIntervals[i].dividend != 0) //returns the dividend if it's not 0
					return _timeIntervals[i].dividend;
			return 0;
		}
		
		///returns string[] of dividend dates
		private static string[] GetDividendDates(TimeInterval[] _timeIntervals) {
			List<string> _dates = new List<string>(); //list to store dates
			
			//loops through all dates forwards to get dividend dates
			for(int i = 0; i < _timeIntervals.Length; i++)
				if(_timeIntervals[i].dividend != 0)
					_dates.Add(_timeIntervals[i].date);
			return DateHandling.FixDates(_dates.ToArray());
		}
		
		///gets all stock information from a year ago to today
		private static TimeInterval[] GetTimeIntervals(string _stockName) {
			bool _unavailable = false; //bool to work out when to stop scraping information
			int _n = 0; // integar to count page numbers
			List<TimeInterval> _timeIntervals = new List<TimeInterval>(); //list to store everyday of stock information specified
			string _startDate = DateHandling.GetCurrentYahooDate(0);
			string _endDate   = DateHandling.GetStartDate();
			
			//this loop will only run while there is information to scrape
			while(!_unavailable) { 
				string _address = GetAddress(_stockName, _startDate, _endDate, _n); // address for next webpage
				TimeInterval[] _currentTimeIntervals = GetInformationOfPage(_address); // getting stock info of webpage				
				if(_currentTimeIntervals == null) _unavailable = true;
				else _timeIntervals.AddRange(_currentTimeIntervals);
				_n++;
			}
			_timeIntervals.Reverse();
			
			return _timeIntervals.ToArray();
		}
		
		
		///gets all the stock information from a specified webpage
		private static TimeInterval[] GetInformationOfPage(string _address) {
			List<TimeInterval> _timeIntervals = new List<TimeInterval>(); //list to store stock info from webpage
			HtmlDocument _doc = LoadDoc(_address); //grabbing all the information of the webpage
			
			//array containing all the rows in the table
			HtmlNodeCollection _rows = _doc.DocumentNode.SelectNodes("//*[@class='yfnc_tabledata1']");
			if(_rows == null) return null; //if rows are empty, no more information to scrape
			
			string _previousDate = ""; //string to make sure same date isn't entered twice and instead the original date is changed
			int _missingCells = 0; //integar to keep the row and timeInterval count alligned in the case of duplicate dates
			
			//loop going through each row and creating or ammending timeIntervals with the information
			for(int i = 0; i < _rows.Count; i++) {
				int _cell = (i * 7) - _missingCells; //integar that splits the row into itss seperate columns
				if(_cell >= _rows.Count) break; //if the last cell has been reached, stop scraping
				if(_rows[_cell].InnerText.Contains("adjusted")) break; //last cell could contain text, in this case stop scraping
				
				//checking if the date is a duplicate, could be something happened to stock on that day or dividend
				bool _sameDate = (_rows[_cell].InnerText == _previousDate); 
				bool _dividend = (_rows[_cell + 1].InnerText.Contains("Dividend"));
				
				//if the cell is a dividend, ammends the previous time interval to include dividend payment
				if(_dividend) _timeIntervals[_timeIntervals.Count - 1].dividend = ConvertDividendToFloat(_rows[_cell + 1].InnerText);
				
				//normal circumstances, adding a new time interval to the list
				if(!_sameDate && DateHandling.IsDate(_rows[_cell].InnerText)) {
					_timeIntervals.Add(
						new TimeInterval (
							_rows[_cell].InnerText,								//date
							ConvertStringToFloat(_rows[_cell + 1].InnerText),	//open
							ConvertStringToFloat(_rows[_cell + 2].InnerText),	//high
							ConvertStringToFloat(_rows[_cell + 3].InnerText),	//low
							ConvertStringToFloat(_rows[_cell + 4].InnerText),	//close
							ConvertStringToFloat(_rows[_cell + 5].InnerText),	//volume
							0													//dividend
						)
					);
					_previousDate = _rows[_cell].InnerText; //sets previous date to this date
				}
				if(_sameDate) _missingCells += 5; //makes up for missing cells due to dividend or other text
			}
			return _timeIntervals.ToArray();
		}
		
		///returns the contents of a webpage in HtmlDocument form
		private static HtmlDocument LoadDoc(string _address) {
			HtmlWeb _web = new HtmlWeb();
			return _web.Load(_address);
		}
		
		///converts dividend string into float
		private static float ConvertDividendToFloat(string _text) {
			return (float)(Convert.ToDecimal(_text.Split(' ')[0].Trim()));
		}
		
		//converts string to float
		private static float ConvertStringToFloat(string _string) {
			return (float)(Convert.ToDecimal(_string));
		}
		
		public static string GetChartAddress(string _stockName) {
			string _address = string.Format("http://finance.yahoo.com/q?s={0}",_stockName);
			string _dirtyAddress = LoadDoc(_address).DocumentNode.SelectSingleNode("//*[@id='yfi_summary_chart']/div/a/img").OuterHtml;
			string _cleanAddress = _dirtyAddress.Split('"')[1];
			_cleanAddress = _cleanAddress.Replace("300", "438");
			_cleanAddress = _cleanAddress.Replace("180", "326");
			return _cleanAddress;
		}
	}
}
