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
					"1997,Ford,E350,\"ac, abs, moon\",3000.00",
					"1999,Chevy,\"Venture \"\"Extended Edition\"\"\",,4900.00",
					"1996,Jeep,Grand Cherokee,\"MUST SELL!",
					"air, moon roof, loaded\",4799.00"
				};
				File.WriteAllLines(path, createText);
			}

			string readText = File.ReadAllText(path);

			string result = Parser(readText);

			//Console.WriteLine(result);
		}

		static string Parser(string csv)
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
				indexRowEnd = csv.IndexOf("\n", indexSatart) == -1 ?
					csv.Length : csv.IndexOf("\n", indexSatart);

				if (!(csv[0] == '\"'))
				{
					indexEnd = csv.IndexOf(",", indexSatart);
					if (indexEnd == -1)
					{
						indexEnd = indexRowEnd;
					}
					row.Add(csv.Substring(indexSatart, indexEnd));
				}
			}




			return "";
		}
	}
}
