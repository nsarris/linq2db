using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.SearchCustomer
{
	[Table(Name = "ICESRCPF", Schema = "XCRS")]
	public partial class CustomerSearchResultItem
	{
		[Column(IsPrimaryKey = true, Name = "SEARCHID", DataType = DataType.Decimal, CanBeNull = false, Precision = 11, Scale = 0)]
		public long SearchUniqueId { get; set; }
		[Column(IsPrimaryKey = true, Name = "SERSEQ", DataType = DataType.Int32, CanBeNull = false, Precision = 7, Scale = 0)]
		public int SearchSequence { get; set; }
		[Column(Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "RSLDSC1", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string ResultDescription1 { get; set; }
		[Column(Name = "RSLSHW1", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string ShowResultDescription1 { get; set; }
		[Column(Name = "RSLDSC2", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string ResultDescription2 { get; set; }
		[Column(Name = "CR1C61A", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string ShowResultDescription2 { get; set; }
		[Column(Name = "RSLDSC3", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string ResultDescription3 { get; set; }
		[Column(Name = "RSLSHW3", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string ShowResultDescription3 { get; set; }
		[Column(Name = "RSLDSC4", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string ResultDescription4 { get; set; }
		[Column(Name = "RSLSHW4", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string ShowResultDescription4 { get; set; }
		[Column(Name = "RSLDSC5", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string ResultDescription5 { get; set; }
		[Column(Name = "RSLSHW5", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string ShowResultDescription5 { get; set; }
	}
}
