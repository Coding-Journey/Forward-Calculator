using System;
using System.Collections.Generic;

namespace Forward_Calculator {

	///handles various date conversion functions
	public class DateHandling {
		
		public DateHandling() {
		}
		
		///gets current date and alligns it to yahoo's calander (jan = 0)
		public static DateTime GetCurrentYahooDate() {
			DateTime _current = DateTime.Today;
			_current = _current.AddMonths(-1);
			return _current;
		}
		
		private static string ConvertToYahoo(DateTime _current) {
			if(_current.Month != 1) {
				_current.AddMonths(-1);
				return ConvertDateToString(_current);
			}
			else return string.Format("{0}/0/{1}",_current.Day, _current.Year - 1);
		}
		
		
		///returns a string version of the current yahoo date, given an int to specify a string is wanted
		public static string GetCurrentYahooDate(int i) {
			if(DateTime.Today.Month != 1) return ConvertDateToString(GetCurrentYahooDate()); 
			else return string.Format("{0}/0/{1}",DateTime.Today.Day, DateTime.Today.Year);
		}
		
		///returns date as a string
		private static string ConvertDateToString(DateTime _date) {
			return _date.ToShortDateString();
		}
		
		///returns whether the string is a date
		public static bool IsDate(string _date) {
			
			//tries to convert the string to a date
			try   { ConvertToDate(_date); }
			//if it fails, returns false
			catch { return false; }
			//if it succeeds returns true
			return true;
		}
		
		///converts a given string into a date time useable by c#
		private static DateTime ConvertToDate(string _date) {
			return
				Convert.ToDateTime(
					_date.Replace(' ','/')
				);
		}
		
		///returns the date a year before the current date as a string
		public static string GetStartDate() {
			DateTime _past = DateTime.Today;
			_past = _past.AddYears(-1);
			return ConvertToYahoo(_past);
		}
		
		///returns number of days until dividend payment
		public static int DaysUntil(string _date) {
			DateTime _today  = DateTime.Today;
			DateTime _future = ConvertToDate(_date);
			
			TimeSpan _diff = _future - _today;
			if(_diff.Days < 0) return (365+_diff.Days);
			return _diff.Days; 
		}
		///returns an array of future dates of dividends
		public static string[] FixDates(string[] _broken) {
			DateTime _now = DateTime.Today;
			int year = DateTime.Today.Year;
			for(int i = 0; i < _broken.Length; i++) {
				DateTime _current = ConvertToDate(_broken[i]);
				int dYear = 0;
				switch(DateTime.Compare(_current, _now)) {
				       	case 0: {
							dYear = 1;
				       		break;
				       	}
				       	case 1: {
							dYear = 1;
				       		break;
				       	}
				       	case 2: {
							dYear = 0;
				       		break;
				       	}
				}
				_current = new DateTime(year + dYear, _current.Month, _current.Day);
				_broken[i] = ConvertDateToString(_current);
				}
			return _broken;
		}
		
		public static string[] GetDatesWithinTime(string[] _dates, int _days) {
			List<string> _datesWithinTime = new List<string>();
			int[]  _daysUntilPayments = new int[_dates.Length]; //array to store days until dividend payment
			
			//loops through all dividends and gets the days until the payment
			for(int i = 0; i < _daysUntilPayments.Length; i++)
				_daysUntilPayments[i] = DateHandling.DaysUntil(_dates[i]);
			
			for(int i = 0; i < _daysUntilPayments.Length; i++)
				if(_daysUntilPayments[i] <= _days) _datesWithinTime.Add(_dates[i]);
			
			return _datesWithinTime.ToArray();
		}

		
	}
}
