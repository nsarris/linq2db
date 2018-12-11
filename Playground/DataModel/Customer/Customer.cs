using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "LSTCSTPF", Schema = "XCRS")]
	public partial class Customer
	{
		[Column(IsPrimaryKey = true, Name = "IPIDCRA", DataType = DataType.Int64, CanBeNull = false, Precision = 8, Scale = 0)]
		public int CrsId { get; set; }
		[Column(Name = "CSTIPTYP", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string CustomerIpType { get; set; }
		[Column(Name = "CSTTYPID", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string CustomerCategoryTypeId { get; set; }
		[Column(Name = "CSTCLTPE", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string CustomerCategoryType { get; set; }
		[Column(Name = "CSTFLNME", DataType = DataType.Char, CanBeNull = false, Length = 60)]
		public string DisplayName { get; set; }
		[Column(Name = "INDVLNME", DataType = DataType.Char, CanBeNull = false, Length = 35)]
		public string IndividualLastName { get; set; }
		[Column(Name = "INDVFNAME", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string IndividualFirstName { get; set; }
		[Column(Name = "INDVFTNM", DataType = DataType.Char, CanBeNull = false, Length = 30)]
		public string IndividualFathersName { get; set; }
		[Column(Name = "INDVDOB", DataType = DataType.Date, CanBeNull = false)]
		public DateTime IndividualDateOfBirth { get; set; }
		[Column(Name = "INVDOCID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long IndividualOccupationId { get; set; }
		[Column(Name = "ORGNAME", DataType = DataType.Char, CanBeNull = false, Length = 120)]
		public string OrganizationName { get; set; }
		[Column(Name = "ORGLGLTP", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string OrganizationLegalTypeId { get; set; }
		[Column(Name = "ORGLGLCL", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string OrganizationLegalClassType { get; set; }
		[Column(Name = "ORGLEGDT", DataType = DataType.Date, CanBeNull = false)]
		public DateTime OrganizationLegEndDate { get; set; }
		[Column(Name = "ORGINDS", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long OrganizationIndustryCode { get; set; }
		[Column(Name = "CSTTAXID", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string TaxId { get; set; }
		[Column(Name = "CSTIDTPE", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string CustomerMainIdType { get; set; }
		[Column(Name = "CSTIDCLS", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string CustomerMainIdClass { get; set; }
		[Column(Name = "CSTIDNMB", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string MainIdNumber { get; set; }
		[Column(Name = "CSTMLADR", DataType = DataType.Char, CanBeNull = false, Length = 200)]
		public string MailAddress { get; set; }
		[Column(Name = "CSTPHONE", DataType = DataType.Char, CanBeNull = false, Length = 30)]
		public string MainPhone { get; set; }
		[Column(Name = "CSTRESP", DataType = DataType.Char, CanBeNull = false, Length = 200)]
		public string CustomerResponsible { get; set; }
		[Column(Name = "CSTCRCTA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int ResponsibleBranchIpId { get; set; }
		[Column(Name = "CSTBRNID", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string ResponsibleBranchMnemonic { get; set; }
		[Column(Name = "CSTPOSTP", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ResponsibleBranchPosType { get; set; }
		[Column(Name = "CSTPOSCL", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ResponsibleBranchPosClass { get; set; }
		[Column(Name = "CSTEMPLSQ", DataType = DataType.Int32, CanBeNull = false, Precision = 5, Scale = 0)]
		public int ResponsibleBranchPosSeq { get; set; }
		[Column(Name = "CSTVBMSG", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string VbmSegmentId { get; set; }
		[Column(Name = "CSTVBMDS", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string VbmSegmentDescr { get; set; }
		[Column(Name = "EMAIL", DataType = DataType.Char, CanBeNull = false, Length = 60)]
		public string Email { get; set; }
		[Column(Name = "CSTAGEXP", DataType = DataType.Int16, CanBeNull = false, Precision = 3, Scale = 0)]
		public short AgeOrMonthsToLegitimacyExpiration { get; set; }
		[Column(Name = "CSTOCPND", DataType = DataType.Char, CanBeNull = false, Length = 12)]
		public string OccupationOrIndustryId { get; set; }
		[Column(Name = "VIPFLAG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsVip { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
