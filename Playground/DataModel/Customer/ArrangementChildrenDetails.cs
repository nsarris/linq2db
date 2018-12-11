using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "CRS13TX", Schema = "XCRS")]
	public partial class ArrangementChildrenDetails
	{
		[Column(Name = "PCR6FA", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long ParentArrangementId { get; set; }
		[Column(Name = "CR4OSA", DataType = DataType.Char, CanBeNull = false, Length = 25)]
		public string Username { get; set; }
		[Column(Name = "PDLVL1CD", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string ProductLevel1 { get; set; }
		[Column(Name = "PDLVL2CD", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string ProductLevel2 { get; set; }
		[Column(Name = "PDLVL3CD", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string ProductLevel3 { get; set; }
		[Column(Name = "GRPIPID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int GroupsIpId { get; set; }
		[Column(Name = "PDTYCLTY", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ProductClassType { get; set; }
		[Column(Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "CR6FA", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long ArrangementId { get; set; }
		[Column(Name = "ARIPCLTY", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string RelationshipClassType { get; set; }
		[Column(Name = "CR1C6A", DataType = DataType.Int16, CanBeNull = false, Precision = 3, Scale = 0)]
		public short RelationshipSequence { get; set; }
		[Column(Name = "CR9SA", DataType = DataType.Date, CanBeNull = false)]
		public DateTime EffectiveDate { get; set; }
		[Column(Name = "CR9TA", DataType = DataType.Date, CanBeNull = false)]
		public DateTime EndDate { get; set; }
		[Column(Name = "CR43AA", DataType = DataType.Date, CanBeNull = false)]
		public DateTime ArrangementEffectiveDate { get; set; }
		[Column(Name = "CR3D1A", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string CharValue { get; set; }
		[Column(Name = "CR3ATA", DataType = DataType.Decimal, CanBeNull = false, Precision = 15, Scale = 2)]
		public decimal Amount1WithDecimal { get; set; }
		[Column(Name = "AMCU1CLT", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Amount1CurrencyClassType { get; set; }
		[Column(Name = "AMT1CLTY", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Amount1ClassType { get; set; }
		[Column(Name = "CR3AUA", DataType = DataType.Decimal, CanBeNull = false, Precision = 15, Scale = 2)]
		public decimal Amount2WithDecimal { get; set; }
		[Column(Name = "AMCU2CLT", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Amount2CurrencyClassType { get; set; }
		[Column(Name = "AMT2CLTY", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Amount2ClassType { get; set; }
		[Column(Name = "AMTDECEU", DataType = DataType.Decimal, CanBeNull = false, Precision = 15, Scale = 2)]
		public decimal AmountWithDecimalEuro { get; set; }
		[Column(Name = "HIDTOTOM", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string HideTotalForGroup { get; set; }
		[Column(Name = "CR2R9A", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string Status { get; set; }
		[Column(Name = "CR2Z3A", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string KartellaPdType { get; set; }
		[Column(Name = "CR6QA", DataType = DataType.Char, CanBeNull = false, Length = 35)]
		public string ExternalArrangementId { get; set; }
		[Column(Name = "CR8EA", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string ProductCommonName { get; set; }
		[Column(Name = "CR302A", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string HistoricalIndicator { get; set; }
		[Column(Name = "CRS2A", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string OrganizationalUnitName { get; set; }
		[Column(Name = "TYPCLTY", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string TypeClassType { get; set; }
		[Column(Name = "OPSYCLTY", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ExternalSystemClassType { get; set; }
		[Column(Name = "CSTMIPID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int CustomerIpId { get; set; }
		[Column(Name = "PDL1DESC", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string ProductLevel1Description { get; set; }
		[Column(Name = "PDL2DESC", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string ProductLevel2Description { get; set; }
		[Column(Name = "PDL3DESC", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string ProductLevel3Description { get; set; }
	}
}
