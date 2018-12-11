using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization
{
	[Table(Name = "S_XSLLSGM", Schema = "XCRS")]
	public partial class SegmentCrossSellIndicator
	{
		[Column(Name = "PPNDT", DataType = DataType.Date, CanBeNull = false)]
		public DateTime Ppndt { get; set; }
		[Column(Name = "SEGCD", DataType = DataType.VarChar, CanBeNull = false, Length = 20)]
		public string SegmentId { get; set; }
		[Column(Name = "SEGSHRNM", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string SegmentMnemonic { get; set; }
		[Column(Name = "SEGNMGR", DataType = DataType.VarChar, CanBeNull = false, Length = 150)]
		public string SegmentDescription { get; set; }
		[Column(Name = "AVGXSLL", DataType = DataType.Decimal, CanBeNull = true, Precision = 8, Scale = 5)]
		public decimal AverageIndicator { get; set; }
		[Column(Name = "CNT", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int UsersCount { get; set; }
	}
}
