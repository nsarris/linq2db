using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "I_CMMPPL", Schema = "XCRS")]
	public partial class CustomerProposal
	{
		[Column(IsPrimaryKey = true, Name = "CSTID", DataType = DataType.Int32, CanBeNull = false, Precision = 9, Scale = 0)]
		public int IpId { get; set; }
		[Column(IsPrimaryKey = true, Name = "CMMPPL", DataType = DataType.VarChar, CanBeNull = false, Length = 50)]
		public string CommercialProposal { get; set; }
		[Column(Name = "CMMPPLSTS", DataType = DataType.VarChar, CanBeNull = false, Length = 50)]
		public string CommercialProposalStatus { get; set; }
		[Column(Name = "EFFDT", DataType = DataType.Date, CanBeNull = false)]
		public DateTime EffectiveDate { get; set; }
		[Column(Name = "MSRPRDDT", DataType = DataType.Date, CanBeNull = false)]
		public DateTime MeasurementPeriodDate { get; set; }
		[Column(Name = "UNQID", DataType = DataType.VarChar, CanBeNull = false, Length = 20)]
		public string CustomerUniqueId { get; set; }
		[Column(Name = "RNK", DataType = DataType.Int16, CanBeNull = false, Precision = 4, Scale = 0)]
		public short Rank { get; set; }
	}
}
