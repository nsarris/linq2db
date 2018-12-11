using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
	[Table(Name = "KPIACTPF", Schema = "XCRS")]
	public partial class ListAnswerCounter
	{
		[Column(Name = "CR1DT4A", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string EntityType { get; set; }
		[Column(Name = "CR1DT5A", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string EntityId { get; set; }
		[Column(Name = "CR1C3UA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ListId { get; set; }
		[Column(Name = "SUBLSTID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long SublistId { get; set; }
		[Column(Name = "CR1DT6A", DataType = DataType.Int64, CanBeNull = false, Precision = 15, Scale = 0)]
		public long Counter { get; set; }
		[Column(Name = "FFU1FLD", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string ForFutureUse1 { get; set; }
		[Column(Name = "FFU2FLD", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string ForFutureUse2 { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
