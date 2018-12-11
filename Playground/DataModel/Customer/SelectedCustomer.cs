using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "ICERSLPF", Schema = "XCRS")]
	public partial class SelectedCustomer
	{
		[Column(IsPrimaryKey = true, Name = "ACTNUSR", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string UserOfAction { get; set; }
		[Column(IsPrimaryKey = true, Name = "SELDATE", DataType = DataType.Date, CanBeNull = false)]
		public DateTime SelectionDate { get; set; }
		[Column(IsPrimaryKey = true, Name = "SELTIME", DataType = DataType.Time, CanBeNull = false)]
		public DateTime SelectionTime { get; set; }
		[Column(Name = "ACTNBRN", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string BranchOfAction { get; set; }
		[Column(IsPrimaryKey = true, Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
	}
}
