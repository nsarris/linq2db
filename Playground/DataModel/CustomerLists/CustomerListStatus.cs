using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
	[Table(Name = "LHXPARPF", Schema = "XCRS")]
	public partial class CustomerListStatus
	{
		[Column(IsPrimaryKey = true, Name = "CR1C3UA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ListId { get; set; }
		[Column(Name = "CR1C46A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Status1TypeId { get; set; }
		[Column(IsPrimaryKey = true, Name = "CR1C47A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Status1ClassType { get; set; }
		[Column(Name = "FFU1FLD", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string ForFutureUse1 { get; set; }
		[Column(Name = "FFU2FLD", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string ForFutureUse2 { get; set; }
		[Column(Name = "FFU3FLD", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string ForFutureUse3 { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
