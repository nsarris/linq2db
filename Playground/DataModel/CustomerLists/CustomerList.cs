using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
    [Table(Name = "LHXPRMPF", Schema = "XCRS")]
    public partial class CustomerList
    {
        [Column(IsPrimaryKey = true, Name = "CR1C3UA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
        public string ListId { get; set; }
        [Column(Name = "SBLSTFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        public short HasSublists { get; set; }
        [Column(Name = "ANSWRFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        public short HasAnswers { get; set; }
        [Column(Name = "STSFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        public short HasStatuses { get; set; }
        [Column(Name = "CNTRFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        public short HasCounter { get; set; }
        [Column(Name = "CNTRTPE", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        public short CounterType { get; set; }
        [Column(Name = "DRILFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        public short Drillability { get; set; }
        [Column(Name = "CLDANFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        public short HasHotColdAnswers { get; set; }
        [Column(Name = "DFLTFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        public short IsDefaultSelected { get; set; }
        [Column(Name = "EXPDFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        public short Expandable { get; set; }
        [Column(Name = "HISTFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        public short HasHistory { get; set; }
        [Column(Name = "COLMFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        public short AllowColumnChoose { get; set; }
        [Column(Name = "SVLAYFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        public short AllowSaveLayout { get; set; }
        //[Column(Name = "HDNFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        //public short IsHiddenOnCustomerLists { get; set; }
        [Column(Name = "FFUFLG1", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        public short ExternalEditTypeId { get; set; }
        [Column(Name = "FFUFLG2", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        public short HasAutoRefresh { get; set; }
        [Column(Name = "FFUFLG3", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        public short AnswerSourceTypeId { get; set; }
        [Column(Name = "FFUFLG4", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        public short ShowsSublists { get; set; }
        [Column(Name = "FFUFLG5", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
        public short EnabledForCheckingCrsExistence { get; set; }
        [Column(Name = "LSTJSON", DataType = DataType.Char, CanBeNull = false, Length = 1000)]
        public string ListOtherAttributes { get; set; }
    }
}
