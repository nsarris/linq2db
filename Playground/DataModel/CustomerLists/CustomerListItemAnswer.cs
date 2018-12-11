using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
	[Table(Name = "ANSPRMPF", Schema = "XCRS")]
	public partial class CustomerListItemAnswer
	{
		[Column(IsPrimaryKey = true, Name = "ANSID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long AnswerId { get; set; }
		[Column(Name = "PRNANSID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long ParentAnswerId { get; set; }
		[Column(Name = "ANSLVL", DataType = DataType.Int16, CanBeNull = false, Precision = 2, Scale = 0)]
		public short Level { get; set; }
		[Column(Name = "ANSDESC", DataType = DataType.Char, CanBeNull = false, Length = 150)]
		public string Description { get; set; }
		[Column(Name = "EXTPID", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ExternalSystemTypeId { get; set; }
		[Column(Name = "EXCLSTP", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ExternalSystemClassType { get; set; }
		[Column(Name = "EXTKEY", DataType = DataType.Char, CanBeNull = false, Length = 150)]
		public string ExternalSystemKey { get; set; }
		[Column(Name = "CR1C46A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Status1TypeId { get; set; }
		[Column(Name = "CR1C47A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Status1ClassType { get; set; }
		[Column(Name = "CR1C48A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Status2TypeId { get; set; }
		[Column(Name = "CR1C49A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Status2ClassType { get; set; }
		[Column(Name = "CMPENBL", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short Enabled { get; set; }
		[Column(Name = "CMPEDTBL", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short UserSelectable { get; set; }
		[Column(Name = "ANSCLCSA", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short ClosesCSA { get; set; }
		[Column(Name = "LSTMDUSR", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string LastModifiedUserId { get; set; }
		[Column(Name = "ANSCMNT", DataType = DataType.Char, CanBeNull = false, Length = 500)]
		public string Comments { get; set; }
		[Column(Name = "ANSOTDT", DataType = DataType.Char, CanBeNull = false, Length = 1000)]
		public string Metadata { get; set; }
		[Column(Name = "ANSMNDC", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short HasMandatoryComments { get; set; }
		[Column(Name = "FFUFLG1", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short ForFutureUseFlag1 { get; set; }
		[Column(Name = "FFUFLG2", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short ForFutureUseFlag2 { get; set; }
		[Column(Name = "FFU1FLD", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string ForFutureUse1 { get; set; }
		[Column(Name = "FFU2FLD", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string ForFutureUse2 { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
