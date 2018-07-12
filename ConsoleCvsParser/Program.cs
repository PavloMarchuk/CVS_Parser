using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCvsParser
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = @"c:\temp\file1.csv";

			if (!File.Exists(path))
			{
				string[] createText =
				{
					"Year, Make, Brand, Description, Price",
					"1997,Ford,E350,\"ac, abs, moon\",3000.00",
					"1999,Chevy,\"Venture \"\"Extended Edition\"\"\",,4900.00",
					"1996,Jeep,Grand Cherokee,\"MUST SELL!",
					"air, moon roof, loaded\",4799.00"
				};
				File.WriteAllLines(path, createText);
			}
			
			string readText = File.ReadAllText(path);
			Print(Parser(readText));
		}

		static List<List<string>> Parser(string csv)
		{
			List<List<string>> res = new List<List<string>>();
			List<string> row = new List<string>();

			int indexSatart = 0;
			int indexEnd = 0;
			int indexRowEnd = 0;


			//int TMP = csv.IndexOf("\n");
			//Console.WriteLine(TMP);
			//TMP = csv.IndexOf("\n", TMP + 1);
			//Console.WriteLine(TMP);
			//Console.WriteLine(csv[TMP+1]);

			while (indexSatart < csv.Length)
			{
				bool lastColl = false;
				indexRowEnd = csv.IndexOf("\n", indexSatart) == -1 ?
					csv.Length : csv.IndexOf("\n", indexSatart);

				if (!(csv[0] == '\"'))
				{
					indexEnd = Math.Min(csv.IndexOf(",", indexSatart), indexRowEnd);
					if (indexEnd == -1)
					{
						indexEnd = indexRowEnd;
						lastColl = true;
					}
					row.Add(csv.Substring(indexSatart, indexEnd - indexSatart));
					indexSatart = indexEnd + 1;
				}

				if (lastColl)
				{
					res.Add(row);
					row = new List<string>();
				}
			}




			return res;
		}

		static void Print(List<List<string>> strL)
		{
			foreach (List<string> row in strL)
			{
				foreach (string str in row)
				{
					Console.Write($"[{row:20}] ");
				}
				Console.WriteLine();
			}
		}
	}
}
