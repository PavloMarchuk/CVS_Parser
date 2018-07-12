using System;
using System.Collections.Generic;
using System.Text;

namespace CsvParser.Models
{
    class CsvRow
    {
		public List<CsvCell> Cells { get; set; }
		public bool IsHeader { get; set; }
	}
}
