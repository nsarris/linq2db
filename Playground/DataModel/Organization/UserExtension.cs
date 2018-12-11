using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization
{
	[Table(Name = "USRKLTPF", Schema = "XCRS")]
	public partial class UserExtension
	{
		[Column(Name = "USER_AA", DataType = DataType.Decimal, CanBeNull = false, Precision = 20, Scale = 0)]
		public decimal UserId { get; set; }
		[Column(Name = "USER_ID", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string SystemUserId { get; set; }
		[Column(Name = "USRLNAME", DataType = DataType.Char, CanBeNull = false, Length = 64)]
		public string LastName { get; set; }
		[Column(Name = "USRFNAME", DataType = DataType.Char, CanBeNull = false, Length = 64)]
		public string FirstName { get; set; }
		[Column(Name = "USRLNMKL", DataType = DataType.Char, CanBeNull = false, Length = 64)]
		public string LastNameKlitiki { get; set; }
		[Column(Name = "USRSNMKL", DataType = DataType.Char, CanBeNull = false, Length = 64)]
		public string FirstNameKlitiki { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
