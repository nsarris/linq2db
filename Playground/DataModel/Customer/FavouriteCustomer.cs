using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "ICECSLPF", Schema = "XCRS")]
	public partial class FavouriteCustomer
	{
		[Column(IsPrimaryKey = true, Name = "CR1C3UA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ListId { get; set; }
		[Column(IsPrimaryKey = true, Name = "CR1C3XA", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string AssignedUser { get; set; }
		[Column(Name = "CR1C3YA", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string AssignedBranch { get; set; }
		[Column(IsPrimaryKey = true, Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "MRKCMNT", DataType = DataType.Char, CanBeNull = false, Length = 1000)]
		public string MarketingComments { get; set; }
		[Column(Name = "SELDATE", DataType = DataType.Date, CanBeNull = false)]
		public DateTime SelectionDate { get; set; }
		[Column(Name = "SELTIME", DataType = DataType.Time, CanBeNull = false)]
		public DateTime SelectionTime { get; set; }
	}
}
