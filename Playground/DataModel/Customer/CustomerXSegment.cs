using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "SEGPEL", Schema = "XCRS")]
	public partial class CustomerXSegment
	{
		[Column(Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "CATEGSEG", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string Category { get; set; }
		[Column(Name = "CATDESEG", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string CategoryDescription { get; set; }
		[Column(Name = "VALUESEG", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string SegmentId { get; set; }
		[Column(Name = "VALDESEG", DataType = DataType.Char, CanBeNull = false, Length = 150)]
		public string SegmentDescription { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
