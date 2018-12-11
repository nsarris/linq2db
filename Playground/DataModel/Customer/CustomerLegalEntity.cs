using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "CRS04P", Schema = "XCRS")]
	public partial class CustomerLegalEntity
	{
		[Column(Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "CRE5A", DataType = DataType.Date, CanBeNull = false)]
		public DateTime LegEndDate { get; set; }
		[Column(Name = "CRE6A", DataType = DataType.Char, CanBeNull = false, Length = 2)]
		public string CurrentOrgLcStatusType { get; set; }
		[Column(Name = "CRE7A", DataType = DataType.Char, CanBeNull = false, Length = 2)]
		public string OrgEconIntentType { get; set; }
		[Column(Name = "CRE8A", DataType = DataType.Char, CanBeNull = false, Length = 2)]
		public string OrgRgstrnStatus { get; set; }
		[Column(Name = "CRE9A", DataType = DataType.Int16, CanBeNull = false, Precision = 4, Scale = 0)]
		public short FoundationYear { get; set; }
		[Column(Name = "CREAA", DataType = DataType.Date, CanBeNull = false)]
		public DateTime ActivityStartDate { get; set; }
		[Column(Name = "CREBA", DataType = DataType.Char, CanBeNull = false, Length = 120)]
		public string Eponymia { get; set; }
		[Column(Name = "CRECA", DataType = DataType.Char, CanBeNull = false, Length = 40)]
		public string DiakritikosTitlos { get; set; }
		[Column(Name = "CRDDA", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string Afm { get; set; }
		[Column(Name = "CRDLA", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string ShortName { get; set; }
		[Column(Name = "CREDA", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string OrgCommonName { get; set; }
		[Column(Name = "CREEA", DataType = DataType.Char, CanBeNull = false, Length = 120)]
		public string PhoneticEponymia { get; set; }
		[Column(Name = "CREFA", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string PhoneticCommonName { get; set; }
		[Column(Name = "CREGA", DataType = DataType.Char, CanBeNull = false, Length = 40)]
		public string PhoneticDiakritikosTitlos { get; set; }
		[Column(Name = "CRDWA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string NationalityTypeId { get; set; }
		[Column(Name = "CRDXA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string NationalityClassType { get; set; }
		[Column(Name = "CRWNA", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long IndsClassId { get; set; }
		[Column(Name = "CR8LA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string TypeTypeId { get; set; }
		[Column(Name = "CREIA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string TypeClassType { get; set; }
		[Column(Name = "CREJA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string LglStrctrTypeFlagTypeId { get; set; }
		[Column(Name = "CREKA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string LglStrctrTypeFlagClassType { get; set; }
		[Column(Name = "CR122A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ResidenceTypeId { get; set; }
		[Column(Name = "CR123A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ResidenceClassType { get; set; }
		[Column(Name = "CRDUA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string PreferredLanguageTypeId { get; set; }
		[Column(Name = "CRDVA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string PreferredLanguageClassType { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
