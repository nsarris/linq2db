using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization
{
	[Table(Name = "ICEUSRPF", Schema = "XCRS")]
	public partial class User
	{
		[Column(Name = "USER_AA", DataType = DataType.Decimal, CanBeNull = false, Precision = 20, Scale = 0)]
		public decimal IceUserId { get; set; }
		[Column(Name = "USER_ID", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string SystemUserId { get; set; }
		[Column(Name = "IDMUSR", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string IdmUserId { get; set; }
		[Column(Name = "EMPLNMB", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string IdmEmployeeNumber { get; set; }
		[Column(Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "HRBRNID", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string HrBranchMnemonic { get; set; }
		[Column(Name = "CRBRNID", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string CurrentBranchMnemonic { get; set; }
		[Column(Name = "BSNUNIT", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string BusinessUnit { get; set; }
		[Column(Name = "IDMTPID", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string IdmUserType { get; set; }
		[Column(Name = "IDMCLTP", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string IdmUserClass { get; set; }
		[Column(Name = "USRNAME", DataType = DataType.Char, CanBeNull = false, Length = 200)]
		public string DisplayName { get; set; }
		[Column(Name = "USRPHONE", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string TelephoneNumber { get; set; }
		[Column(Name = "USRINTPH", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string InternalPhone { get; set; }
		[Column(Name = "HREMPNMB", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string HrManagerEmployeeNumber { get; set; }
		[Column(Name = "CREMPNMB", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string CurrentManagerEmployeeNumber { get; set; }
		[Column(Name = "SVEMPNMB", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string SupervisorEmployeeNumber { get; set; }
		[Column(Name = "CMPJOBCD", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string CompositeJobCode { get; set; }
		[Column(Name = "JOBDESCR", DataType = DataType.Char, CanBeNull = false, Length = 30)]
		public string IdmJobDescription { get; set; }
		[Column(Name = "HR_ROLE", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string HrRole { get; set; }
		[Column(Name = "HR_SET_RL", DataType = DataType.Char, CanBeNull = false, Length = 300)]
		public string HrSetOfRoles { get; set; }
		[Column(Name = "HREMPSTS", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string HrEmployeeStatus { get; set; }
		[Column(Name = "IDMUPDDT", DataType = DataType.Date, CanBeNull = false)]
		public DateTime IdmLastUpdateDate { get; set; }
		[Column(Name = "IDMUPDTM", DataType = DataType.Time, CanBeNull = false)]
		public DateTime IdmLastUpdateTime { get; set; }
		[Column(Name = "ENBLFLG", DataType = DataType.Int32, CanBeNull = false, Precision = 7, Scale = 0)]
		public int Enabled { get; set; }
		[Column(Name = "IDMSTSDC", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string IdmStatus { get; set; }
		[Column(Name = "EQUSRFL", DataType = DataType.Int32, CanBeNull = false, Precision = 7, Scale = 0)]
		public int IsEquUser { get; set; }
		[Column(Name = "EQBRNID", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string EquationBranchMnemonic { get; set; }
		[Column(Name = "ICEUSRFL", DataType = DataType.Int32, CanBeNull = false, Precision = 7, Scale = 0)]
		public int IsIceUser { get; set; }
		[Column(Name = "ICAUTH", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string IceAuthList { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
