using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
	[Table(Name = "ANSRLTPF", Schema = "XCRS")]
	public partial class CustomerSubListXAnswer
	{
		[Column(IsPrimaryKey = true, Name = "CR1C3UA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ListId { get; set; }
		[Column(IsPrimaryKey = true, Name = "SUBLSTID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long SublistId { get; set; }
		[Column(Name = "ANSID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long AnswerId { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
