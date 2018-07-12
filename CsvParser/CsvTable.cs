using CsvParser.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CsvParser
{
	public class CsvTable
	{
		#region Fields
		private List<CsvRow> _rows;
		private int _unixTime;
		#endregion
		#region Constuctors
		public CsvTable(string file_path, bool isHeaderFirstFow = false)
		{
			Parser(Loader(file_path), isHeaderFirstFow);
		}
		#endregion
		#region Properties
		public List<CsvRow> Rows { get => _rows; }

		public int UnixTime { get => _unixTime; }
		#endregion
		#region Private Methods
		private string Loader(string file_path)
		{
			return File.ReadAllText(file_path);
			//else { Console.WriteLine("file not found 404"); }
		}
		private void Parser(string str, bool isHeaderFirstFow)
		{

		}
		#endregion
		#region Public Methods
		public void ConsolePrint()
		{
			Console.WriteLine("ConsolePrint()");
		}
		#endregion

	}
}
