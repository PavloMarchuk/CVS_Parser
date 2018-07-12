using System;
using CsvParser;
namespace test
{
	class Program
	{
		static void Main(string[] args)
		{
			//
			//tmp file_path
			// tmp --header-first-row=true
			string file_path = @"c:\temp\file1.csv";
			CsvTable ct = new CsvTable(file_path, true);
			ct.ConsolePrint();

		}
	}
}
