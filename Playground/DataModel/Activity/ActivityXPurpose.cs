using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Activity
{
	[Table(Name = "ACTPURRL", Schema = "XCRS")]
	public partial class ActivityXPurpose
	{
		[Column(IsPrimaryKey = true, Name = "AUTONMID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Id { get; set; }
		[Column(Name = "ACTIVID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long ActivityId { get; set; }
		[Column(Name = "ACTPURID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long PurposeId { get; set; }
		[Column(Name = "CONCATGID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long ContactCategoryId { get; set; }
		[Column(Name = "PRDLEVEL", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short ProductLevel { get; set; }
		[Column(Name = "PRDUCTID", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string ProductId { get; set; }
		[Column(Name = "TENTATIVE", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsTentative { get; set; }
		[Column(Name = "STATUSID", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short StatusId { get; set; }
		[Column(Name = "CANCELRSN", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short CancellationReason { get; set; }
		[Column(Name = "METADATA", DataType = DataType.Char, CanBeNull = false, Length = 1000)]
		public string Metadata { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
