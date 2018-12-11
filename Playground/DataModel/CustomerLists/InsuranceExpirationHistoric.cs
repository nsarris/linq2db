using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
	[Table(Name = "LHXINHPF", Schema = "XCRS")]
	public partial class InsuranceExpirationHistoric
	{
		[Column(IsPrimaryKey = true, Name = "CR1C5BA", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Id { get; set; }
		[Column(Name = "CR1C3UA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ListId { get; set; }
		[Column(Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "CR1AOJA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId2 { get; set; }
		[Column(Name = "CR6QA", DataType = DataType.Char, CanBeNull = false, Length = 35)]
		public string ExtSystemId { get; set; }
		[Column(Name = "CR9SA", DataType = DataType.Date, CanBeNull = false)]
		public DateTime EffectviveDate { get; set; }
		[Column(Name = "CR9TA", DataType = DataType.Date, CanBeNull = false)]
		public DateTime EndDate { get; set; }
		[Column(Name = "CR1C5TA", DataType = DataType.Char, CanBeNull = false, Length = 30)]
		public string BranchId { get; set; }
		[Column(Name = "CR8EA", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string ProductCommonName { get; set; }
		[Column(Name = "CR1CY6A", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string PaymentInstallmentMethod { get; set; }
		[Column(Name = "CR1C5UA", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string PaymentMethod { get; set; }
		[Column(Name = "CR1CY7A", DataType = DataType.Decimal, CanBeNull = false, Precision = 13, Scale = 2)]
		public decimal DueAmount { get; set; }
		[Column(Name = "CR1C5WA", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string Package { get; set; }
		[Column(Name = "CR1CY8A", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string InsuredAsset { get; set; }
		[Column(Name = "CR1CY9A", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string InsuredCapital { get; set; }
		[Column(Name = "CR1CYAA", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string NextInstallmentDate { get; set; }
		[Column(Name = "CR1C5VA", DataType = DataType.Decimal, CanBeNull = false, Precision = 13, Scale = 2)]
		public decimal Amount { get; set; }
		[Column(Name = "CR1C5XA", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string Company { get; set; }
		[Column(Name = "CR1C5YA", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string IsDeceasedIndividual { get; set; }
		[Column(Name = "CR1C5ZA", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string IsUnderageInvididual { get; set; }
		[Column(Name = "CR1C60A", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string ExpiredLegitimacyEndDate { get; set; }
		[Column(Name = "CR1C3XA", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string AssignedUser { get; set; }
		[Column(Name = "CR1C3YA", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string AssignedBranch { get; set; }
		[Column(Name = "CR1C3ZA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string SourceLastModified { get; set; }
		[Column(Name = "CR1C40A", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string UserNextAction { get; set; }
		[Column(Name = "CR1C41A", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string BranchNextAction { get; set; }
		[Column(Name = "CR1C42A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string SourceNextAction { get; set; }
		[Column(Name = "CR1C46A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Status1TypeId { get; set; }
		[Column(Name = "CR1C47A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Status1ClassType { get; set; }
		[Column(Name = "CR1C48A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Status2TypeId { get; set; }
		[Column(Name = "CR1C49A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Status2ClassType { get; set; }
		[Column(Name = "CR1C45A", DataType = DataType.Char, CanBeNull = false, Length = 200)]
		public string Comments { get; set; }
		[Column(Name = "CR9UA", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string HistoricalStatus { get; set; }
		[Column(Name = "ACTNUSR", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string UserOfAction { get; set; }
		[Column(Name = "ACTNBRN", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string BranchOfAction { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
		[Column(IsPrimaryKey = true, Name = "DTECRTED", DataType = DataType.Date, CanBeNull = false)]
		public DateTime DateCreated { get; set; }
		[Column(IsPrimaryKey = true, Name = "TMECRTED", DataType = DataType.Time, CanBeNull = false)]
		public DateTime TimeCreated { get; set; }
		[Column(IsPrimaryKey = true, Name = "USCRECRA", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string UserCreator { get; set; }
	}
}
