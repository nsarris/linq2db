using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "A_CSTATC", Schema = "XCRS")]
	public partial class TransactionalBehaviour
	{
		[Column(Name = "MSRPRDID", DataType = DataType.Int32, CanBeNull = false, Precision = 9, Scale = 0)]
		public int MeasurementPeriodId { get; set; }
		[Column(IsPrimaryKey = true, Name = "CSTID", DataType = DataType.Int32, CanBeNull = false, Precision = 9, Scale = 0)]
		public int DataWarehouseIpId { get; set; }
		[Column(Name = "PPNDT", DataType = DataType.Date, CanBeNull = false)]
		public DateTime DateUpdated { get; set; }
		[Column(Name = "CRSCSTID", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string IpId { get; set; }
		[Column(Name = "ACTSTSID", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int ActiveStatusId { get; set; }
		[Column(Name = "ACTSTSNM", DataType = DataType.VarChar, CanBeNull = true, Length = 150)]
		public string ActiveStatusDescription { get; set; }
		[Column(Name = "RLTTPID", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int RelationshipTypeId { get; set; }
		[Column(Name = "RLTTPNM", DataType = DataType.VarChar, CanBeNull = true, Length = 150)]
		public string RelationshipTypeDescription { get; set; }
		[Column(Name = "GRPSEGCD", DataType = DataType.VarChar, CanBeNull = true, Length = 20)]
		public string GroupSegmentCode { get; set; }
		[Column(Name = "GRPSEG", DataType = DataType.VarChar, CanBeNull = true, Length = 150)]
		public string GroupSegment { get; set; }
		[Column(Name = "SEGCD", DataType = DataType.VarChar, CanBeNull = true, Length = 20)]
		public string SegmentCode { get; set; }
		[Column(Name = "SEG", DataType = DataType.VarChar, CanBeNull = true, Length = 150)]
		public string VBMSegment { get; set; }
		[Column(Name = "NBRBP", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int NumberOfBasicProducts { get; set; }
		[Column(Name = "LNCSLS", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int LaunchSales { get; set; }
		[Column(Name = "XSL", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int CrossSales { get; set; }
		[Column(Name = "UPSLS", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int UpSales { get; set; }
		[Column(Name = "LNCSLSEFF", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int EffectiveLaunchedSales { get; set; }
		[Column(Name = "XSLEFF", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int EffectiveCrossSales { get; set; }
		[Column(Name = "UPSLSEFF", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int EffectiveUpSales { get; set; }
		[Column(Name = "VAR", DataType = DataType.Decimal, CanBeNull = true, Precision = 15, Scale = 2)]
		public decimal Variance { get; set; }
		[Column(Name = "DEPCBL", DataType = DataType.Decimal, CanBeNull = true, Precision = 15, Scale = 0)]
		public long DepositBalance { get; set; }
		[Column(Name = "LNCBL", DataType = DataType.Decimal, CanBeNull = true, Precision = 15, Scale = 0)]
		public long LoanBalance { get; set; }
		[Column(Name = "ATM", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int AtmUsage { get; set; }
		[Column(Name = "WINBNK", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int WinbankUsage { get; set; }
		[Column(Name = "BRN", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int BranchUsage { get; set; }
		[Column(Name = "TTLCMP", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int TotalCampaigns { get; set; }
		[Column(Name = "PTVANS", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int PositiveAnswers { get; set; }
		[Column(Name = "NTVANS", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int NegativeAnswers { get; set; }
		[Column(Name = "TTLANS", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int TotalAnswers { get; set; }
		[Column(Name = "GRSPFTSTR", DataType = DataType.Int32, CanBeNull = true, Precision = 9, Scale = 0)]
		public int GrossProfitStarsIndicator { get; set; }
		[Column(Name = "GRNSTS", DataType = DataType.VarChar, CanBeNull = true, Length = 50)]
		public string GreenStatus { get; set; }
		[Column(Name = "GRNFLG", DataType = DataType.Int16, CanBeNull = true, Precision = 4, Scale = 0)]
		public short GreenFlag { get; set; }
		[Column(Name = "WMTRBCKCD", DataType = DataType.VarChar, CanBeNull = true, Length = 5)]
		public string WorstMaterialBucketCode { get; set; }
		[Column(Name = "TTLDPTBAL", DataType = DataType.Decimal, CanBeNull = true, Precision = 21, Scale = 6)]
		public decimal TotalDeptBalance { get; set; }
		[Column(Name = "LSTLOGINDT", DataType = DataType.Date, CanBeNull = true)]
		public DateTime LastLoginDate { get; set; }
		[Column(Name = "LSTATMTXDT", DataType = DataType.Date, CanBeNull = true)]
		public DateTime LastATMTransactionDate { get; set; }
		[Column(Name = "LSTATMTXCD", DataType = DataType.VarChar, CanBeNull = true, Length = 20)]
		public string LastATMTransactionCode { get; set; }
		[Column(Name = "LSTATMTXNM", DataType = DataType.VarChar, CanBeNull = true, Length = 150)]
		public string LastATMTransactionDescription { get; set; }
		[Column(Name = "LSTATMTXAM", DataType = DataType.Decimal, CanBeNull = true, Precision = 18, Scale = 2)]
		public decimal LastATMTransactionAmount { get; set; }
		[Column(Name = "LSTATMTXDC", DataType = DataType.Char, CanBeNull = true, Length = 1)]
		public string LastATMTransactionType { get; set; }
		[Column(Name = "LSTATMDVCD", DataType = DataType.Char, CanBeNull = true, Length = 10)]
		public string LastATMCode { get; set; }
		[Column(Name = "LSTATMDVNM", DataType = DataType.VarChar, CanBeNull = true, Length = 100)]
		public string LastATMName { get; set; }
		[Column(Name = "LSTCSHTXDT", DataType = DataType.Date, CanBeNull = true)]
		public DateTime LastCashierTransactionDate { get; set; }
		[Column(Name = "LSTCSHTXCD", DataType = DataType.VarChar, CanBeNull = true, Length = 20)]
		public string LastCashierTransactionCode { get; set; }
		[Column(Name = "LSTCSHTXNM", DataType = DataType.VarChar, CanBeNull = true, Length = 150)]
		public string LastCashierTransactionDescription { get; set; }
		[Column(Name = "LSTCSHTXAM", DataType = DataType.Decimal, CanBeNull = true, Precision = 18, Scale = 2)]
		public decimal LastCashierTransactionAmount { get; set; }
		[Column(Name = "LSTCSHTXDC", DataType = DataType.Char, CanBeNull = true, Length = 1)]
		public string LastCashierTransactionType { get; set; }
		[Column(Name = "LSTCSHOUCD", DataType = DataType.Char, CanBeNull = true, Length = 4)]
		public string LastBranchId { get; set; }
		[Column(Name = "LSTCSHOUNM", DataType = DataType.VarChar, CanBeNull = true, Length = 100)]
		public string LastBranchName { get; set; }
		[Column(Name = "LSTWINTXDT", DataType = DataType.Date, CanBeNull = true)]
		public DateTime LastWinbankTransactionDate { get; set; }
		[Column(Name = "LSTWINTXCD", DataType = DataType.VarChar, CanBeNull = true, Length = 20)]
		public string LastWinbankTransactionCode { get; set; }
		[Column(Name = "LSTWINTXNM", DataType = DataType.VarChar, CanBeNull = true, Length = 150)]
		public string LastWinbankTransactionDescription { get; set; }
		[Column(Name = "LSTWINTXAM", DataType = DataType.Decimal, CanBeNull = true, Precision = 18, Scale = 2)]
		public decimal LastWinbankTransactionAmount { get; set; }
		[Column(Name = "LSTWINTXDC", DataType = DataType.Char, CanBeNull = true, Length = 1)]
		public string LastWinbankTransactionType { get; set; }
		[Column(Name = "AVGBRNVSTS", DataType = DataType.Decimal, CanBeNull = true, Precision = 5, Scale = 2)]
		public decimal AverageBranchVisits { get; set; }
		[Column(Name = "AVGTXNCNT", DataType = DataType.Decimal, CanBeNull = true, Precision = 12, Scale = 2)]
		public decimal AverageTransactions { get; set; }
		[Column(Name = "AVGTXNAMT", DataType = DataType.Decimal, CanBeNull = true, Precision = 18, Scale = 2)]
		public decimal AverageTransactionsAmount { get; set; }
	}
}
