using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization
{
	[Table(Name = "HVPF", Schema = "KFILPIR")]
	public partial class BranchAddress
	{
		[Column(IsPrimaryKey = true, Name = "HVLNM", DataType = DataType.Char, CanBeNull = false, Length = 2)]
		public string LanguageCode { get; set; }
		[Column(Name = "HVBRNM", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string BranchMnemonic { get; set; }
		[Column(IsPrimaryKey = true, Name = "HVBBN", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string BranchNumber { get; set; }
		[Column(Name = "HVBNM", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string BranchName { get; set; }
		[Column(Name = "HVBAD1", DataType = DataType.Char, CanBeNull = false, Length = 35)]
		public string BranchAddressLine1 { get; set; }
		[Column(Name = "HVBAD2", DataType = DataType.Char, CanBeNull = false, Length = 35)]
		public string BranchAddressLine2 { get; set; }
		[Column(Name = "HVBAD3", DataType = DataType.Char, CanBeNull = false, Length = 35)]
		public string BranchAddressLine3 { get; set; }
		[Column(Name = "HVBAD4", DataType = DataType.Char, CanBeNull = false, Length = 35)]
		public string BranchAddressLine4 { get; set; }
		[Column(Name = "HVBAD5", DataType = DataType.Char, CanBeNull = false, Length = 35)]
		public string BranchAddressLine5 { get; set; }
		[Column(Name = "HVPHN", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string TelephoneNumber { get; set; }
		[Column(Name = "HVTLX", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string TelexNumber { get; set; }
		[Column(Name = "HVC08", DataType = DataType.Char, CanBeNull = false, Length = 8)]
		public string TelexAnswerback { get; set; }
		[Column(Name = "HVFAX", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string FaxNumber { get; set; }
	}
}
