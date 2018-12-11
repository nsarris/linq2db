using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "CRS03P", Schema = "XCRS")]
	public partial class CustomerPhysicalEntity
	{
		[Column(Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "CRD4A", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string Gender { get; set; }
		[Column(Name = "CRD5A", DataType = DataType.Char, CanBeNull = false, Length = 2)]
		public string MaritalStatus { get; set; }
		[Column(Name = "CRD6A", DataType = DataType.Char, CanBeNull = false, Length = 2)]
		public string CurrentIndvLcStatusType { get; set; }
		[Column(Name = "CRD7A", DataType = DataType.Date, CanBeNull = false)]
		public DateTime DateOfBirth { get; set; }
		[Column(Name = "CRD8A", DataType = DataType.Date, CanBeNull = false)]
		public DateTime DateOfDeath { get; set; }
		[Column(Name = "CRD9A", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string FirstName { get; set; }
		[Column(Name = "CRDAA", DataType = DataType.Char, CanBeNull = false, Length = 35)]
		public string LastName { get; set; }
		[Column(Name = "CRDBA", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string FathersFirstName { get; set; }
		[Column(Name = "CRDCA", DataType = DataType.Char, CanBeNull = false, Length = 35)]
		public string FathersLastName { get; set; }
		[Column(Name = "CRDDA", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string Afm { get; set; }
		[Column(Name = "CRDEA", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string ADT { get; set; }
		[Column(Name = "CRDFA", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string Passport { get; set; }
		[Column(Name = "CRDIA", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string PhoneticFirstName { get; set; }
		[Column(Name = "CRDJA", DataType = DataType.Char, CanBeNull = false, Length = 35)]
		public string PhoneticLastName { get; set; }
		[Column(Name = "CRDKA", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string PhoneticFathersFirstName { get; set; }
		[Column(Name = "CRDLA", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string ShortName { get; set; }
		[Column(Name = "CRDNA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string CitizenshipTypeId { get; set; }
		[Column(Name = "CRDOA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string CitizenshipClassType { get; set; }
		[Column(Name = "CRDPA", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long CurrentOcptnIndvOcptnTypeId { get; set; }
		[Column(Name = "CR1MLA", DataType = DataType.Date, CanBeNull = false)]
		public DateTime CurrentOcptnInputDate { get; set; }
		[Column(Name = "CRDRA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string CurrentEmplmtTypeId { get; set; }
		[Column(Name = "CRDSA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string CurrentEmplmtClassType { get; set; }
		[Column(Name = "CR1MMA", DataType = DataType.Date, CanBeNull = false)]
		public DateTime CurrentEmplmtInputDate { get; set; }
		[Column(Name = "CRDUA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string PreferredLanguageTypeId { get; set; }
		[Column(Name = "CRDVA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string PreferredLanguageClassType { get; set; }
		[Column(Name = "CRDWA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string NationalityTypeId { get; set; }
		[Column(Name = "CRDXA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string NationalityClassType { get; set; }
		[Column(Name = "CR122A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ResidenceTypeId { get; set; }
		[Column(Name = "CR123A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ResidenceClassType { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
