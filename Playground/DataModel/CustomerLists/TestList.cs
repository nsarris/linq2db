using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
	[Table(Name = "LHXTSTPF", Schema = "XCRS")]
	public partial class TestList
	{
		[Column(Name = "CR1C5BA", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Id { get; set; }
		[Column(Name = "CR1C3UA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ListId { get; set; }
		[Column(Name = "SUBLSTID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long SublistId { get; set; }
		[Column(Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
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
		[Column(Name = "CR1C45A", DataType = DataType.Char, CanBeNull = false, Length = 200)]
		public string StatusComments { get; set; }
		[Column(Name = "MRKCMNT", DataType = DataType.Char, CanBeNull = false, Length = 1000)]
		public string MarketingComments { get; set; }
		[Column(Name = "ANSID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long AnswerId { get; set; }
		[Column(Name = "EXTPID", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ExternalSystemTypeId { get; set; }
		[Column(Name = "EXCLSTP", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ExternalSystemClassType { get; set; }
		[Column(Name = "EXTKEY", DataType = DataType.Char, CanBeNull = false, Length = 150)]
		public string ExternalSystemKey { get; set; }
		[Column(Name = "EXTCLRS", DataType = DataType.Char, CanBeNull = false, Length = 1000)]
		public string ExternalCallStatus { get; set; }
		[Column(Name = "CR9UA", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string HistoricStatus { get; set; }
		[Column(Name = "ATMCNT", DataType = DataType.Int32, CanBeNull = false, Precision = 5, Scale = 0)]
		public int NumberOfAttempts { get; set; }
		[Column(Name = "LSTMDUSR", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string LastModifiedUserId { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
