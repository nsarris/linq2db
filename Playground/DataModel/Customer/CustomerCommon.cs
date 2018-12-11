using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "CRS02P", Schema = "XCRS")]
	public partial class CustomerCommon
	{
		[Column(Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "CRCJA", DataType = DataType.Char, CanBeNull = false, Length = 60)]
		public string FullName { get; set; }
		[Column(Name = "CR6GA", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string Description { get; set; }
		[Column(Name = "CRCKA", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string CustomerTypeCode { get; set; }
		[Column(Name = "CRCLA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string CurrLcStatusTypeTypeId { get; set; }
		[Column(Name = "CRCMA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string CurrLcStatusTypeClassType { get; set; }
		[Column(Name = "CRCNA", DataType = DataType.Date, CanBeNull = false)]
		public DateTime CurrCstmrLcStatusEfctvDate { get; set; }
		[Column(Name = "CRCOA", DataType = DataType.Char, CanBeNull = false, Length = 2)]
		public string MailType { get; set; }
		[Column(Name = "CRCPA", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string EmplPostnName { get; set; }
		[Column(Name = "CRCQA", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string IpRecordStatus { get; set; }
		[Column(Name = "CRCRA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string CustomerCategoryTypeId { get; set; }
		[Column(Name = "CRCSA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string CustomerCategoryType { get; set; }
		[Column(Name = "CRCTA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int CustomerBranchId { get; set; }
		[Column(Name = "CRCUA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string CustomerBranchTypeId { get; set; }
		[Column(Name = "CRCVA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string CusetomerBranchClassType { get; set; }
		[Column(Name = "CRCWA", DataType = DataType.Int32, CanBeNull = false, Precision = 5, Scale = 0)]
		public int CstmrBranchEmplntPostnSeq { get; set; }
		[Column(Name = "CR6XA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int HoldMailIpId { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
