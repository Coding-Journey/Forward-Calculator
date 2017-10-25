using System;
using System.Xml;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Forward_Calculator {

	///handles all the file interactions
	public class FileHandling {
		
		public FileHandling() {
		}
		
		//////////////////////////////////////////////////////////
		// deals with saving a new stock

		
		///saves the newly found stock
		public static void SaveStockInformation(StockInformation _stockInformation) {
			//creates a new xml writing object
			using(XmlWriter _writer = XmlWriter.Create(_stockInformation.name + ".xml")) {
			      	_writer.WriteStartDocument();
			      	_writer.WriteStartElement("Contains_Stock_Information");
			      	//writes stock info
			      	_writer.WriteElementString("Stock_Info", string.Format("{0}|{1}|{2}|{3}", _stockInformation.name, _stockInformation.price, _stockInformation.dividend, ConvertArrayToString(_stockInformation.dates)));
			      	_writer.WriteEndElement();
			      	_writer.WriteEndDocument();
			      }
		}
		
		///returns string array as a string
		public static string ConvertArrayToString(string[] _dates) {
			string _dateString = ""; //creating a string to store dates
			
			for(int i = 0; i < _dates.Length; i++) { //loops through all the dates adding them to the string
				_dateString += _dates[i];
				if(i != _dates.Length - 1) _dateString += ",";
			}
			
			return _dateString;
		}
		
		//////////////////////////////////////////////////////////
		//deals with loading stocks
		
		public static StockInformation[] Loadstocks(string _folderName) {
			//gets all the filenames within the stock directory
			string[] _fileNames = Directory.GetFiles(_folderName, "*.xml").Select(Path.GetFileNameWithoutExtension).ToArray();
			StockInformation[] _stockInfo = new StockInformation[_fileNames.Length]; //creating an array to store info
			
			//loops through all filenames and gets the stock info
			for(int i = 0; i < _fileNames.Length; i++) {
				//creates xml reader object to get stock info
				XmlTextReader _reader = new XmlTextReader(_fileNames[i] + ".xml");
				string _working = "";
				
				//only saves information when there is information present
				while(_reader.Read()) {
					switch(_reader.NodeType) {
							case XmlNodeType.Text: {
								_working = _reader.Value;
								break;
							}
					}
				}
				_stockInfo[i] = ConvertStringToStockInformation(_working);
				
			}
			return _stockInfo;			
		}
		
		///reads a single stock
		public static StockInformation LoadStock(string _fileName) {
			//xml reader object to get stock info
			XmlTextReader _reader = new XmlTextReader(_fileName);
			string _working = "";
			
			//only saves information when there is information present
			while(_reader.Read()) {
				switch(_reader.NodeType) {
						case XmlNodeType.Text: {
							_working = _reader.Value;
							break;
						}
				}
			}
			return ConvertStringToStockInformation(_working);	
		}
		
		///converts string read from file into stock info object
		private static StockInformation ConvertStringToStockInformation(string _working) {
			//splits string into parts
			string[] _workingArray = _working.Split('|');
			return new StockInformation (
				_workingArray[0],
				(float)Convert.ToDecimal(_workingArray[1]),
				(float)Convert.ToDecimal(_workingArray[2]),
				_workingArray[3].Split(',') 
			);				
		}
		
		//////////////////////////////////////////////////////////
		/// deals with loading bonds
		
		public static InterestRegion[] LoadRegions() {
			//reading all text in the file and splitting into regions
			string[] _dirtyBonds = File.ReadAllText("InterestRegions.txt").Split('|');
			//array to store regions being read from file
			InterestRegion[] _regions = new InterestRegion[_dirtyBonds.Length];
			
			//loops through saving every region
			for(int i = 0; i < _regions.Length; i++) {
				_regions[i] = new InterestRegion();
				string[] _parts = _dirtyBonds[i].Split(':');
				_regions[i].name = _parts[0]; //setting name of region
				_regions[i].bonds = new Bond[_parts.Length -1]; //setting lengt of array
				//loop going through and saving each bond
				for(int j = 1; j < _parts.Length; j++) {
					string[] _working = _parts[j].Split(','); //current bond
					_regions[i].bonds[j-1] = new Bond(Convert.ToInt32(_working[1]), (float)Convert.ToDecimal(_working[0]));
				}
			}
			return _regions;			
		}
		
		public static void SaveImage(Image _img, string _fileName, ImageFormat _format) {
			File.Delete(_fileName);
			_img.Save(_fileName, _format);
		}
	
	}
}
