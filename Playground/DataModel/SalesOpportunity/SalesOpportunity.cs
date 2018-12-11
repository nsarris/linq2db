using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.SalesOpportunity
{
	[Table(Name = "SALOPPPF", Schema = "XCRS")]
	public partial class SalesOpportunity
	{
		[Column(IsPrimaryKey = true, Name = "IDSALEOP", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Id { get; set; }
		[Column(Name = "SALOPPIP", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "PDLEVID", DataType = DataType.Int32, CanBeNull = false, Precision = 7, Scale = 0)]
		public int ProductLevel { get; set; }
		[Column(Name = "PDIDCODE", DataType = DataType.Char, CanBeNull = false, Length = 11)]
		public string ProductId { get; set; }
		[Column(Name = "OPPORAMT", DataType = DataType.Int64, CanBeNull = false, Precision = 15, Scale = 0)]
		public long Amount { get; set; }
		[Column(Name = "SALISACT", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsActive { get; set; }
		[Column(Name = "SALISDEL", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsDeleted { get; set; }
		[Column(Name = "USCRECRA", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string Creator { get; set; }
		[Column(Name = "DTCREATE", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateCreated { get; set; }
		[Column(Name = "TIMECRE", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeCreated { get; set; }
		[Column(Name = "USLMODCRA", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string UserLastModified { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
