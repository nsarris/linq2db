using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
	[Table(Name = "KPIBRPF", Schema = "XCRS")]
	public partial class CustomerListBranchCounter
	{
		[Column(IsPrimaryKey = true, Name = "CR1C3UA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Listid { get; set; }
		[Column(IsPrimaryKey = true, Name = "SUBLSTID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long SublistId { get; set; }
		[Column(IsPrimaryKey = true, Name = "CR1C3YA", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string AssignedBranch { get; set; }
		[Column(Name = "CR1C6FA", DataType = DataType.Int64, CanBeNull = false, Precision = 15, Scale = 0)]
		public long BranchToDo { get; set; }
		[Column(Name = "CR1C6GA", DataType = DataType.Int64, CanBeNull = false, Precision = 15, Scale = 0)]
		public long BranchOutOf { get; set; }
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
