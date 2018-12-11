using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "ICELOANPFF ", Schema = "XCRS")]
	public partial class CustomerLoan
	{
		[Column(Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "REFDT", DataType = DataType.Date, CanBeNull = false)]
		public DateTime ReferenceDate { get; set; }
		[Column(Name = "ARUNQID", DataType = DataType.Char, CanBeNull = false, Length = 40)]
		public string ArrangementUniqueId { get; set; }
		[Column(Name = "SSIDCD", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string SourceSystemCode { get; set; }
		[Column(Name = "DLQDAYS", DataType = DataType.Int16, CanBeNull = false, Precision = 4, Scale = 0)]
		public short DeliquencyDays { get; set; }
		[Column(Name = "MTRBCKCD", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string MaterialBucketCode { get; set; }
		[Column(Name = "MTRBCKNM", DataType = DataType.Char, CanBeNull = false, Length = 150)]
		public string MaterialBucketName { get; set; }
		[Column(Name = "INRPAUFLG", DataType = DataType.Int32, CanBeNull = false, Precision = 9, Scale = 0)]
		public int HasInterestPaused { get; set; }
		[Column(Name = "MNGOUNM", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string ManagementOrgUnitDescription { get; set; }
		[Column(Name = "MNGOUNBR", DataType = DataType.Int32, CanBeNull = false, Precision = 9, Scale = 0)]
		public int ManagementOrgUnitCode { get; set; }
		[Column(Name = "CR1DLHA", DataType = DataType.Decimal, CanBeNull = false, Precision = 21, Scale = 6)]
		public decimal TangibleCollateralAmount { get; set; }
		[Column(Name = "TEMPMEFLG", DataType = DataType.Int32, CanBeNull = false, Precision = 9, Scale = 0)]
		public int TempmeFlag { get; set; }
		[Column(Name = "KYAFLG", DataType = DataType.Int32, CanBeNull = false, Precision = 9, Scale = 0)]
		public int KyaFlag { get; set; }
		[Column(Name = "FNPECD", DataType = DataType.Char, CanBeNull = false, Length = 5)]
		public string EbaDescriptionMonthly { get; set; }
		[Column(Name = "FNPEQCD", DataType = DataType.Char, CanBeNull = false, Length = 5)]
		public string EbaDescriptionQuarter { get; set; }
		[Column(Name = "RTMACTFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 4, Scale = 0)]
		public short IsUnderRestructure { get; set; }
		[Column(Name = "EXLEURAMT", DataType = DataType.Decimal, CanBeNull = false, Precision = 21, Scale = 6)]
		public decimal OffBalanceSheetInterest { get; set; }
		[Column(Name = "ORISYSPDCD", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string OriginalSystemProductCode { get; set; }
		[Column(Name = "ORISYSNMGR", DataType = DataType.Char, CanBeNull = false, Length = 150)]
		public string OriginalSystemProductDescription { get; set; }
		[Column(Name = "ARSYMB", DataType = DataType.Char, CanBeNull = false, Length = 40)]
		public string ContractNumber { get; set; }
		[Column(Name = "SYS_SYMB", DataType = DataType.Char, CanBeNull = false, Length = 6)]
		public string ContractSystem { get; set; }
		[Column(Name = "KAT_SYMB", DataType = DataType.Char, CanBeNull = false, Length = 6)]
		public string ContractBranch { get; set; }
		[Column(Name = "BSNLNFLG", DataType = DataType.Int32, CanBeNull = false, Precision = 9, Scale = 0)]
		public int IsBusinessLoan { get; set; }
		[Column(Name = "CR9SA", DataType = DataType.Date, CanBeNull = false)]
		public DateTime EffectiveDate { get; set; }
		[Column(Name = "CR9TA", DataType = DataType.Date, CanBeNull = false)]
		public DateTime EndDate { get; set; }
		[Column(Name = "CR6WA", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long DependedProductId { get; set; }
		[Column(Name = "CR8EA", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string ProductCommonName { get; set; }
		[Column(Name = "CR1D4A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ArrangementIpRelationshipTypeId { get; set; }
		[Column(Name = "CR1D5A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ArrangementIpRelationshipClassType { get; set; }
		[Column(Name = "RELATIONTYPEID", DataType = DataType.VarChar, CanBeNull = false, Length = 3)]
		public string RelationTypeId { get; set; }
		[Column(Name = "RELATIONTYPE", DataType = DataType.VarChar, CanBeNull = false, Length = 6)]
		public string RelationType { get; set; }
		[Column(Name = "CR9RA", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string Description { get; set; }
		[Column(Name = "AMOUNTTYPE1", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string FirstAmountDescription { get; set; }
		[Column(Name = "AMOUNT1", DataType = DataType.Int64, CanBeNull = false, Precision = 15, Scale = 0)]
		public long FirstAmount { get; set; }
		[Column(Name = "REFDATE1", DataType = DataType.Date, CanBeNull = false)]
		public DateTime BalFirstEffectiveDate { get; set; }
		[Column(Name = "AMOUNTTYPE2", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string SecondAmountDescription { get; set; }
		[Column(Name = "AMOUNT2", DataType = DataType.Int64, CanBeNull = false, Precision = 15, Scale = 0)]
		public long SecondAmount { get; set; }
		[Column(Name = "REFDATE2", DataType = DataType.Date, CanBeNull = false)]
		public DateTime BalSecondEffectiveDate { get; set; }
	}
}
