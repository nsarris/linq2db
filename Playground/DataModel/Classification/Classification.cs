using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel
{
	[Table(Name = "CRS55P", Schema = "XCRS")]
	public partial class Classification
	{
		[Column(IsPrimaryKey = true, Name = "CR9OA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string TypeId { get; set; }
		[Column(IsPrimaryKey = true, Name = "CR9QA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ClassType { get; set; }
		[Column(Name = "CR9RA", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string Descr { get; set; }
		[Column(Name = "CR9SA", DataType = DataType.Date, CanBeNull = false)]
		public DateTime EfctvDate { get; set; }
		[Column(Name = "CR9TA", DataType = DataType.Date, CanBeNull = false)]
		public DateTime EndDate { get; set; }
		[Column(Name = "CR9UA", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string isHistoric { get; set; }
		[Column(Name = "CR9VA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ReverseClassType { get; set; }
		[Column(Name = "CR9WA", DataType = DataType.Int16, CanBeNull = false, Precision = 4, Scale = 0)]
		public short TypePriority { get; set; }
		[Column(Name = "CR9XA", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string UserEditable { get; set; }
		[Column(Name = "CR9YA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string InitiatedFromΤTypeId { get; set; }
		[Column(Name = "CR9ZA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string InitiatedFromΤClassType { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
