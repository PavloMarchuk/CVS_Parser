using System;
using System.Collections.Generic;
using System.Text;

namespace CsvParser.Models
{
	public class CsvRow
	{
		public CsvRow(bool isHeader=false)
		{
			IsHeader = isHeader;
		}
		private List<CsvCell> _cells;

		public List<CsvCell> Cells { get => _cells;  }
		public bool IsHeader { get; private set; }
	}
}
