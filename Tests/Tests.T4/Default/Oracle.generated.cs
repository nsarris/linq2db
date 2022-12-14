﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------

#pragma warning disable 1573, 1591
#nullable enable

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Configuration;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace Default.Oracle
{
	public partial class TestDataDB : LinqToDB.Data.DataConnection
	{
		public ITable<AllType>             AllTypes            { get { return this.GetTable<AllType>(); } }
		public ITable<BINARYDATA>          Binarydatas         { get { return this.GetTable<BINARYDATA>(); } }
		public ITable<Child>               Children            { get { return this.GetTable<Child>(); } }
		public ITable<CollatedTable>       CollatedTables      { get { return this.GetTable<CollatedTable>(); } }
		public ITable<DataTypeTest>        DataTypeTests       { get { return this.GetTable<DataTypeTest>(); } }
		public ITable<DecimalOverflow>     DecimalOverflows    { get { return this.GetTable<DecimalOverflow>(); } }
		public ITable<Doctor>              Doctors             { get { return this.GetTable<Doctor>(); } }
		public ITable<GrandChild>          GrandChildren       { get { return this.GetTable<GrandChild>(); } }
		public ITable<InheritanceChild>    InheritanceChildren { get { return this.GetTable<InheritanceChild>(); } }
		public ITable<InheritanceParent>   InheritanceParents  { get { return this.GetTable<InheritanceParent>(); } }
		public ITable<LinqDataType>        LinqDataTypes       { get { return this.GetTable<LinqDataType>(); } }
		public ITable<LINQDATATYPESBC>     Linqdatatypesbcs    { get { return this.GetTable<LINQDATATYPESBC>(); } }
		public ITable<LongRawTable>        LongRawTables       { get { return this.GetTable<LongRawTable>(); } }
		public ITable<Parent>              Parents             { get { return this.GetTable<Parent>(); } }
		public ITable<Patient>             Patients            { get { return this.GetTable<Patient>(); } }
		public ITable<Person>              People              { get { return this.GetTable<Person>(); } }
		/// <summary>
		/// This is matview
		/// </summary>
		public ITable<SchemaTestMatView>   SchemaTestMatViews  { get { return this.GetTable<SchemaTestMatView>(); } }
		/// <summary>
		/// This is table
		/// </summary>
		public ITable<SchemaTestTable>     SchemaTestTables    { get { return this.GetTable<SchemaTestTable>(); } }
		public ITable<SchemaTestView>      SchemaTestViews     { get { return this.GetTable<SchemaTestView>(); } }
		public ITable<SEQUENCETEST>        Sequencetests       { get { return this.GetTable<SEQUENCETEST>(); } }
		public ITable<StgTradeInformation> StgTradeInformation { get { return this.GetTable<StgTradeInformation>(); } }
		public ITable<StringTest>          StringTests         { get { return this.GetTable<StringTest>(); } }
		public ITable<TEntity>             TEntities           { get { return this.GetTable<TEntity>(); } }
		public ITable<TestIdentity>        TestIdentities      { get { return this.GetTable<TestIdentity>(); } }
		public ITable<TestMerge1>          TestMerge1          { get { return this.GetTable<TestMerge1>(); } }
		public ITable<TestMerge2>          TestMerge2          { get { return this.GetTable<TestMerge2>(); } }
		public ITable<TTestUser>           TTestUsers          { get { return this.GetTable<TTestUser>(); } }
		public ITable<TTestUserContract>   TTestUserContracts  { get { return this.GetTable<TTestUserContract>(); } }

		public TestDataDB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestDataDB(LinqToDBConnectionOptions options)
			: base(options)
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestDataDB(LinqToDBConnectionOptions<TestDataDB> options)
			: base(options)
		{
			InitDataContext();
			InitMappingSchema();
		}

		partial void InitDataContext  ();
		partial void InitMappingSchema();

		#region Table Functions

		#region TestPACKAGE1TestTableFunction

		[Sql.TableFunction(Schema="MANAGED", Package="TEST_PACKAGE1", Name="TEST_TABLE_FUNCTION")]
		public ITable<TestTableFUNCTIONResult> TestPACKAGE1TestTableFunction(decimal? I)
		{
			return this.GetTable<TestTableFUNCTIONResult>(this, (MethodInfo)MethodBase.GetCurrentMethod()!,
				I);
		}

		public partial class TestTableFUNCTIONResult
		{
			public decimal? O { get; set; }
		}

		#endregion

		#region TestPACKAGE2TestTableFunction

		[Sql.TableFunction(Schema="MANAGED", Package="TEST_PACKAGE2", Name="TEST_TABLE_FUNCTION")]
		public ITable<TestTableFUNCTIONResult0> TestPACKAGE2TestTableFunction(decimal? I)
		{
			return this.GetTable<TestTableFUNCTIONResult0>(this, (MethodInfo)MethodBase.GetCurrentMethod()!,
				I);
		}

		public partial class TestTableFUNCTIONResult0
		{
			public decimal? O { get; set; }
		}

		#endregion

		#region TestTableFunction

		[Sql.TableFunction(Schema="MANAGED", Name="TEST_TABLE_FUNCTION")]
		public ITable<TestTableFUNCTIONResult1> TestTableFunction(decimal? I)
		{
			return this.GetTable<TestTableFUNCTIONResult1>(this, (MethodInfo)MethodBase.GetCurrentMethod()!,
				I);
		}

		public partial class TestTableFUNCTIONResult1
		{
			public decimal? O { get; set; }
		}

		#endregion

		#endregion
	}

	[Table(Schema="MANAGED", Name="AllTypes")]
	public partial class AllType
	{
		[Column(),                         PrimaryKey,  NotNull] public decimal         ID                     { get; set; } // NUMBER
		[Column("bigintDataType"),            Nullable         ] public decimal?        BigintDataType         { get; set; } // NUMBER (20,0)
		[Column("numericDataType"),           Nullable         ] public decimal?        NumericDataType        { get; set; } // NUMBER
		[Column("bitDataType"),               Nullable         ] public sbyte?          BitDataType            { get; set; } // NUMBER (1,0)
		[Column("smallintDataType"),          Nullable         ] public int?            SmallintDataType       { get; set; } // NUMBER (5,0)
		[Column("decimalDataType"),           Nullable         ] public decimal?        DecimalDataType        { get; set; } // NUMBER
		[Column("smallmoneyDataType"),        Nullable         ] public decimal?        SmallmoneyDataType     { get; set; } // NUMBER (10,4)
		[Column("intDataType"),               Nullable         ] public long?           IntDataType            { get; set; } // NUMBER (10,0)
		[Column("tinyintDataType"),           Nullable         ] public short?          TinyintDataType        { get; set; } // NUMBER (3,0)
		[Column("moneyDataType"),             Nullable         ] public decimal?        MoneyDataType          { get; set; } // NUMBER
		[Column("floatDataType"),             Nullable         ] public double?         FloatDataType          { get; set; } // BINARY_DOUBLE
		[Column("realDataType"),              Nullable         ] public float?          RealDataType           { get; set; } // BINARY_FLOAT
		[Column("datetimeDataType"),          Nullable         ] public DateTime?       DatetimeDataType       { get; set; } // DATE
		[Column("datetime2DataType"),         Nullable         ] public DateTime?       Datetime2DataType      { get; set; } // TIMESTAMP(6)
		[Column("datetimeoffsetDataType"),    Nullable         ] public DateTimeOffset? DatetimeoffsetDataType { get; set; } // TIMESTAMP(6) WITH TIME ZONE
		[Column("localZoneDataType"),         Nullable         ] public DateTimeOffset? LocalZoneDataType      { get; set; } // TIMESTAMP(6) WITH LOCAL TIME ZONE
		[Column("charDataType"),              Nullable         ] public char?           CharDataType           { get; set; } // CHAR(1)
		[Column("char20DataType"),            Nullable         ] public string?         Char20DataType         { get; set; } // CHAR(20)
		[Column("varcharDataType"),           Nullable         ] public string?         VarcharDataType        { get; set; } // VARCHAR2(20)
		[Column("textDataType"),              Nullable         ] public string?         TextDataType           { get; set; } // CLOB
		[Column("ncharDataType"),             Nullable         ] public string?         NcharDataType          { get; set; } // NCHAR(20)
		[Column("nvarcharDataType"),          Nullable         ] public string?         NvarcharDataType       { get; set; } // NVARCHAR2(20)
		[Column("ntextDataType"),             Nullable         ] public string?         NtextDataType          { get; set; } // NCLOB
		[Column("binaryDataType"),            Nullable         ] public byte[]?         BinaryDataType         { get; set; } // BLOB
		[Column("bfileDataType"),             Nullable         ] public byte[]?         BfileDataType          { get; set; } // BFILE
		[Column("guidDataType"),              Nullable         ] public byte[]?         GuidDataType           { get; set; } // RAW(16)
		[Column("longDataType"),              Nullable         ] public string?         LongDataType           { get; set; } // LONG
		[Column("xmlDataType"),               Nullable         ] public string?         XmlDataType            { get; set; } // XMLTYPE
	}

	[Table(Schema="MANAGED", Name="BINARYDATA")]
	public partial class BINARYDATA
	{
		[PrimaryKey, NotNull] public decimal  BINARYDATAID { get; set; } // NUMBER
		[Column,     NotNull] public DateTime STAMP        { get; set; } // TIMESTAMP(6)
		[Column,     NotNull] public byte[]   DATA         { get; set; } = null!; // BLOB
	}

	[Table(Schema="MANAGED", Name="Child")]
	public partial class Child
	{
		[Column, Nullable] public decimal? ParentID { get; set; } // NUMBER
		[Column, Nullable] public decimal? ChildID  { get; set; } // NUMBER
	}

	[Table(Schema="MANAGED", Name="CollatedTable")]
	public partial class CollatedTable
	{
		[Column, NotNull] public decimal Id              { get; set; } // NUMBER
		[Column, NotNull] public string  CaseSensitive   { get; set; } = null!; // VARCHAR2(20)
		[Column, NotNull] public string  CaseInsensitive { get; set; } = null!; // VARCHAR2(20)
	}

	[Table(Schema="MANAGED", Name="DataTypeTest")]
	public partial class DataTypeTest
	{
		[Column(),            PrimaryKey,  NotNull] public decimal   DataTypeID { get; set; } // NUMBER
		[Column("Binary_"),      Nullable         ] public byte[]?   Binary     { get; set; } // RAW(50)
		[Column("Boolean_"),     Nullable         ] public sbyte?    Boolean    { get; set; } // NUMBER (1,0)
		[Column("Byte_"),        Nullable         ] public short?    Byte       { get; set; } // NUMBER (3,0)
		[Column("Bytes_"),       Nullable         ] public byte[]?   Bytes      { get; set; } // BLOB
		[Column("Char_"),        Nullable         ] public char?     Char       { get; set; } // NCHAR(1)
		[Column("DateTime_"),    Nullable         ] public DateTime? DateTime   { get; set; } // DATE
		[Column("Decimal_"),     Nullable         ] public decimal?  Decimal    { get; set; } // NUMBER (19,5)
		[Column("Double_"),      Nullable         ] public decimal?  Double     { get; set; } // FLOAT(126)
		[Column("Guid_"),        Nullable         ] public byte[]?   Guid       { get; set; } // RAW(16)
		[Column("Int16_"),       Nullable         ] public int?      Int16      { get; set; } // NUMBER (5,0)
		[Column("Int32_"),       Nullable         ] public long?     Int32      { get; set; } // NUMBER (10,0)
		[Column("Int64_"),       Nullable         ] public decimal?  Int64      { get; set; } // NUMBER (20,0)
		[Column("Money_"),       Nullable         ] public decimal?  Money      { get; set; } // NUMBER
		[Column("SByte_"),       Nullable         ] public short?    SByte      { get; set; } // NUMBER (3,0)
		[Column("Single_"),      Nullable         ] public decimal?  Single     { get; set; } // FLOAT(126)
		[Column("Stream_"),      Nullable         ] public byte[]?   Stream     { get; set; } // BLOB
		[Column("String_"),      Nullable         ] public string?   String     { get; set; } // NVARCHAR2(50)
		[Column("UInt16_"),      Nullable         ] public int?      UInt16     { get; set; } // NUMBER (5,0)
		[Column("UInt32_"),      Nullable         ] public long?     UInt32     { get; set; } // NUMBER (10,0)
		[Column("UInt64_"),      Nullable         ] public decimal?  UInt64     { get; set; } // NUMBER (20,0)
		[Column("Xml_"),         Nullable         ] public string?   Xml        { get; set; } // XMLTYPE
	}

	[Table(Schema="MANAGED", Name="DecimalOverflow")]
	public partial class DecimalOverflow
	{
		[Column, Nullable] public decimal? Decimal1 { get; set; } // NUMBER (38,20)
		[Column, Nullable] public decimal? Decimal2 { get; set; } // NUMBER (31,2)
		[Column, Nullable] public decimal? Decimal3 { get; set; } // NUMBER (38,36)
		[Column, Nullable] public decimal? Decimal4 { get; set; } // NUMBER (29,0)
		[Column, Nullable] public decimal? Decimal5 { get; set; } // NUMBER (38,38)
	}

	[Table(Schema="MANAGED", Name="Doctor")]
	public partial class Doctor
	{
		[PrimaryKey, NotNull] public decimal PersonID { get; set; } // NUMBER
		[Column,     NotNull] public string  Taxonomy { get; set; } = null!; // NVARCHAR2(50)

		#region Associations

		/// <summary>
		/// Fk_Doctor_Person (MANAGED.Person)
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false)]
		public Person Person { get; set; } = null!;

		#endregion
	}

	[Table(Schema="MANAGED", Name="GrandChild")]
	public partial class GrandChild
	{
		[Column, Nullable] public decimal? ParentID     { get; set; } // NUMBER
		[Column, Nullable] public decimal? ChildID      { get; set; } // NUMBER
		[Column, Nullable] public decimal? GrandChildID { get; set; } // NUMBER
	}

	[Table(Schema="MANAGED", Name="InheritanceChild")]
	public partial class InheritanceChild
	{
		[PrimaryKey, NotNull    ] public decimal  InheritanceChildId  { get; set; } // NUMBER
		[Column,     NotNull    ] public decimal  InheritanceParentId { get; set; } // NUMBER
		[Column,        Nullable] public decimal? TypeDiscriminator   { get; set; } // NUMBER
		[Column,        Nullable] public string?  Name                { get; set; } // NVARCHAR2(50)
	}

	[Table(Schema="MANAGED", Name="InheritanceParent")]
	public partial class InheritanceParent
	{
		[PrimaryKey, NotNull    ] public decimal  InheritanceParentId { get; set; } // NUMBER
		[Column,        Nullable] public decimal? TypeDiscriminator   { get; set; } // NUMBER
		[Column,        Nullable] public string?  Name                { get; set; } // NVARCHAR2(50)
	}

	[Table(Schema="MANAGED", Name="LinqDataTypes")]
	public partial class LinqDataType
	{
		[Column, Nullable] public decimal?  ID             { get; set; } // NUMBER
		[Column, Nullable] public decimal?  MoneyValue     { get; set; } // NUMBER (10,4)
		[Column, Nullable] public DateTime? DateTimeValue  { get; set; } // TIMESTAMP(6)
		[Column, Nullable] public DateTime? DateTimeValue2 { get; set; } // TIMESTAMP(6)
		[Column, Nullable] public decimal?  BoolValue      { get; set; } // NUMBER
		[Column, Nullable] public byte[]?   GuidValue      { get; set; } // RAW(16)
		[Column, Nullable] public byte[]?   BinaryValue    { get; set; } // BLOB
		[Column, Nullable] public decimal?  SmallIntValue  { get; set; } // NUMBER
		[Column, Nullable] public decimal?  IntValue       { get; set; } // NUMBER
		[Column, Nullable] public decimal?  BigIntValue    { get; set; } // NUMBER (20,0)
		[Column, Nullable] public string?   StringValue    { get; set; } // VARCHAR2(50)
	}

	[Table(Schema="MANAGED", Name="LINQDATATYPESBC")]
	public partial class LINQDATATYPESBC
	{
		[Column, Nullable] public decimal?  ID             { get; set; } // NUMBER
		[Column, Nullable] public decimal?  MONEYVALUE     { get; set; } // NUMBER (10,4)
		[Column, Nullable] public DateTime? DATETIMEVALUE  { get; set; } // TIMESTAMP(6)
		[Column, Nullable] public DateTime? DATETIMEVALUE2 { get; set; } // TIMESTAMP(6)
		[Column, Nullable] public decimal?  BOOLVALUE      { get; set; } // NUMBER
		[Column, Nullable] public byte[]?   GUIDVALUE      { get; set; } // RAW(16)
		[Column, Nullable] public decimal?  SMALLINTVALUE  { get; set; } // NUMBER
		[Column, Nullable] public decimal?  INTVALUE       { get; set; } // NUMBER
		[Column, Nullable] public decimal?  BIGINTVALUE    { get; set; } // NUMBER (20,0)
		[Column, Nullable] public string?   STRINGVALUE    { get; set; } // VARCHAR2(50)
	}

	[Table(Schema="MANAGED", Name="LongRawTable")]
	public partial class LongRawTable
	{
		[Column(),                  PrimaryKey,  NotNull] public decimal ID              { get; set; } // NUMBER
		[Column("longRawDataType"),    Nullable         ] public byte[]? LongRawDataType { get; set; } // LONG RAW
	}

	[Table(Schema="MANAGED", Name="Parent")]
	public partial class Parent
	{
		[Column, Nullable] public decimal? ParentID { get; set; } // NUMBER
		[Column, Nullable] public decimal? Value1   { get; set; } // NUMBER
	}

	[Table(Schema="MANAGED", Name="Patient")]
	public partial class Patient
	{
		[PrimaryKey, NotNull] public decimal PersonID  { get; set; } // NUMBER
		[Column,     NotNull] public string  Diagnosis { get; set; } = null!; // NVARCHAR2(256)

		#region Associations

		/// <summary>
		/// Fk_Patient_Person (MANAGED.Person)
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false)]
		public Person Person { get; set; } = null!;

		#endregion
	}

	[Table(Schema="MANAGED", Name="Person")]
	public partial class Person
	{
		[PrimaryKey, NotNull    ] public decimal PersonID   { get; set; } // NUMBER
		[Column,     NotNull    ] public string  FirstName  { get; set; } = null!; // VARCHAR2(50)
		[Column,     NotNull    ] public string  LastName   { get; set; } = null!; // VARCHAR2(50)
		[Column,        Nullable] public string? MiddleName { get; set; } // VARCHAR2(50)
		[Column,     NotNull    ] public char    Gender     { get; set; } // CHAR(1)

		#region Associations

		/// <summary>
		/// Fk_Doctor_Person_BackReference (MANAGED.Doctor)
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true)]
		public Doctor? FkDoctor { get; set; }

		/// <summary>
		/// Fk_Patient_Person_BackReference (MANAGED.Patient)
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true)]
		public Patient? FkPatient { get; set; }

		#endregion
	}

	/// <summary>
	/// This is matview
	/// </summary>
	[Table(Schema="MANAGED", Name="SchemaTestMatView", IsView=true)]
	public partial class SchemaTestMatView
	{
		/// <summary>
		/// This is matview column
		/// </summary>
		[PrimaryKey, NotNull] public decimal Id { get; set; } // NUMBER
	}

	/// <summary>
	/// This is table
	/// </summary>
	[Table(Schema="MANAGED", Name="SchemaTestTable")]
	public partial class SchemaTestTable
	{
		/// <summary>
		/// This is column
		/// </summary>
		[PrimaryKey, NotNull] public decimal Id { get; set; } // NUMBER
	}

	[Table(Schema="MANAGED", Name="SchemaTestView", IsView=true)]
	public partial class SchemaTestView
	{
		/// <summary>
		/// This is view column
		/// </summary>
		[Column, NotNull] public decimal Id { get; set; } // NUMBER
	}

	[Table(Schema="MANAGED", Name="SEQUENCETEST")]
	public partial class SEQUENCETEST
	{
		[PrimaryKey, NotNull] public decimal ID    { get; set; } // NUMBER
		[Column,     NotNull] public string  VALUE { get; set; } = null!; // VARCHAR2(50)
	}

	[Table(Schema="MANAGED", Name="STG_TRADE_INFORMATION")]
	public partial class StgTradeInformation
	{
		[Column("STG_TRADE_ID"),          NotNull    ] public decimal   StgTradeId          { get; set; } // NUMBER
		[Column("STG_TRADE_VERSION"),     NotNull    ] public decimal   StgTradeVersion     { get; set; } // NUMBER
		[Column("INFORMATION_TYPE_ID"),   NotNull    ] public decimal   InformationTypeId   { get; set; } // NUMBER
		[Column("INFORMATION_TYPE_NAME"),    Nullable] public string?   InformationTypeName { get; set; } // VARCHAR2(50)
		[Column(),                           Nullable] public string?   VALUE               { get; set; } // VARCHAR2(4000)
		[Column("VALUE_AS_INTEGER"),         Nullable] public decimal?  ValueAsInteger      { get; set; } // NUMBER
		[Column("VALUE_AS_DATE"),            Nullable] public DateTime? ValueAsDate         { get; set; } // DATE
	}

	[Table(Schema="MANAGED", Name="StringTest")]
	public partial class StringTest
	{
		[Column,    Nullable] public string? StringValue1 { get; set; } // VARCHAR2(50)
		[Column,    Nullable] public string? StringValue2 { get; set; } // CHAR(50)
		[Column, NotNull    ] public string  KeyValue     { get; set; } = null!; // VARCHAR2(50)
	}

	[Table(Schema="MANAGED", Name="t_entity")]
	public partial class TEntity
	{
		[Column("entity_id"), PrimaryKey,  NotNull] public decimal   EntityId { get; set; } // NUMBER
		[Column("time"),         Nullable         ] public DateTime? Time     { get; set; } // DATE
		[Column("duration"),     Nullable         ] public TimeSpan? Duration { get; set; } // INTERVAL DAY(3) TO SECOND(2)
	}

	[Table(Schema="MANAGED", Name="TestIdentity")]
	public partial class TestIdentity
	{
		[PrimaryKey, NotNull] public decimal ID { get; set; } // NUMBER
	}

	[Table(Schema="MANAGED", Name="TestMerge1")]
	public partial class TestMerge1
	{
		[PrimaryKey, NotNull    ] public decimal         Id              { get; set; } // NUMBER
		[Column,        Nullable] public decimal?        Field1          { get; set; } // NUMBER
		[Column,        Nullable] public decimal?        Field2          { get; set; } // NUMBER
		[Column,        Nullable] public decimal?        Field3          { get; set; } // NUMBER
		[Column,        Nullable] public decimal?        Field4          { get; set; } // NUMBER
		[Column,        Nullable] public decimal?        Field5          { get; set; } // NUMBER
		[Column,        Nullable] public decimal?        FieldInt64      { get; set; } // NUMBER (20,0)
		[Column,        Nullable] public sbyte?          FieldBoolean    { get; set; } // NUMBER (1,0)
		[Column,        Nullable] public string?         FieldString     { get; set; } // VARCHAR2(20)
		[Column,        Nullable] public string?         FieldNString    { get; set; } // NVARCHAR2(20)
		[Column,        Nullable] public char?           FieldChar       { get; set; } // CHAR(1)
		[Column,        Nullable] public char?           FieldNChar      { get; set; } // NCHAR(1)
		[Column,        Nullable] public float?          FieldFloat      { get; set; } // BINARY_FLOAT
		[Column,        Nullable] public double?         FieldDouble     { get; set; } // BINARY_DOUBLE
		[Column,        Nullable] public DateTime?       FieldDateTime   { get; set; } // DATE
		[Column,        Nullable] public DateTimeOffset? FieldDateTime2  { get; set; } // TIMESTAMP(7) WITH TIME ZONE
		[Column,        Nullable] public byte[]?         FieldBinary     { get; set; } // BLOB
		[Column,        Nullable] public byte[]?         FieldGuid       { get; set; } // RAW(16)
		[Column,        Nullable] public decimal?        FieldDecimal    { get; set; } // NUMBER (24,10)
		[Column,        Nullable] public string?         FieldEnumString { get; set; } // VARCHAR2(20)
		[Column,        Nullable] public decimal?        FieldEnumNumber { get; set; } // NUMBER
	}

	[Table(Schema="MANAGED", Name="TestMerge2")]
	public partial class TestMerge2
	{
		[PrimaryKey, NotNull    ] public decimal         Id              { get; set; } // NUMBER
		[Column,        Nullable] public decimal?        Field1          { get; set; } // NUMBER
		[Column,        Nullable] public decimal?        Field2          { get; set; } // NUMBER
		[Column,        Nullable] public decimal?        Field3          { get; set; } // NUMBER
		[Column,        Nullable] public decimal?        Field4          { get; set; } // NUMBER
		[Column,        Nullable] public decimal?        Field5          { get; set; } // NUMBER
		[Column,        Nullable] public decimal?        FieldInt64      { get; set; } // NUMBER (20,0)
		[Column,        Nullable] public sbyte?          FieldBoolean    { get; set; } // NUMBER (1,0)
		[Column,        Nullable] public string?         FieldString     { get; set; } // VARCHAR2(20)
		[Column,        Nullable] public string?         FieldNString    { get; set; } // NVARCHAR2(20)
		[Column,        Nullable] public char?           FieldChar       { get; set; } // CHAR(1)
		[Column,        Nullable] public char?           FieldNChar      { get; set; } // NCHAR(1)
		[Column,        Nullable] public float?          FieldFloat      { get; set; } // BINARY_FLOAT
		[Column,        Nullable] public double?         FieldDouble     { get; set; } // BINARY_DOUBLE
		[Column,        Nullable] public DateTime?       FieldDateTime   { get; set; } // DATE
		[Column,        Nullable] public DateTimeOffset? FieldDateTime2  { get; set; } // TIMESTAMP(7) WITH TIME ZONE
		[Column,        Nullable] public byte[]?         FieldBinary     { get; set; } // BLOB
		[Column,        Nullable] public byte[]?         FieldGuid       { get; set; } // RAW(16)
		[Column,        Nullable] public decimal?        FieldDecimal    { get; set; } // NUMBER (24,10)
		[Column,        Nullable] public string?         FieldEnumString { get; set; } // VARCHAR2(20)
		[Column,        Nullable] public decimal?        FieldEnumNumber { get; set; } // NUMBER
	}

	[Table(Schema="MANAGED", Name="t_test_user")]
	public partial class TTestUser
	{
		[Column("user_id"), PrimaryKey, NotNull] public decimal UserId { get; set; } // NUMBER
		[Column("name"),                NotNull] public string  Name   { get; set; } = null!; // VARCHAR2(255)

		#region Associations

		/// <summary>
		/// SYS_C007123_BackReference (MANAGED.t_test_user_contract)
		/// </summary>
		[Association(ThisKey="UserId", OtherKey="UserId", CanBeNull=true)]
		public IEnumerable<TTestUserContract> Syscs { get; set; } = null!;

		#endregion
	}

	[Table(Schema="MANAGED", Name="t_test_user_contract")]
	public partial class TTestUserContract
	{
		[Column("user_contract_id"), PrimaryKey, NotNull] public decimal UserContractId { get; set; } // NUMBER
		[Column("user_id"),                      NotNull] public decimal UserId         { get; set; } // NUMBER
		[Column("contract_no"),                  NotNull] public decimal ContractNo     { get; set; } // NUMBER
		[Column("name"),                         NotNull] public string  Name           { get; set; } = null!; // VARCHAR2(255)

		#region Associations

		/// <summary>
		/// SYS_C007123 (MANAGED.t_test_user)
		/// </summary>
		[Association(ThisKey="UserId", OtherKey="UserId", CanBeNull=false)]
		public TTestUser User { get; set; } = null!;

		#endregion
	}

	public static partial class TestDataDBStoredProcedures
	{
		#region TestPACKAGE1TestProcedure

		public static int TestPACKAGE1TestProcedure(this TestDataDB dataConnection, decimal? I, out decimal? O)
		{
			var parameters = new []
			{
				new DataParameter("I", I, LinqToDB.DataType.Decimal)
				{
					Size = 22
				},
				new DataParameter("O", null, LinqToDB.DataType.Decimal)
				{
					Direction = ParameterDirection.Output,
					Size      = 22
				}
			};

			var ret = dataConnection.ExecuteProc("MANAGED.TEST_PACKAGE1.TEST_PROCEDURE", parameters);

			O = Converter.ChangeTypeTo<decimal?>(parameters[1].Value);

			return ret;
		}

		#endregion

		#region TestPACKAGE2TestProcedure

		public static int TestPACKAGE2TestProcedure(this TestDataDB dataConnection, decimal? I, out decimal? O)
		{
			var parameters = new []
			{
				new DataParameter("I", I, LinqToDB.DataType.Decimal)
				{
					Size = 22
				},
				new DataParameter("O", null, LinqToDB.DataType.Decimal)
				{
					Direction = ParameterDirection.Output,
					Size      = 22
				}
			};

			var ret = dataConnection.ExecuteProc("MANAGED.TEST_PACKAGE2.TEST_PROCEDURE", parameters);

			O = Converter.ChangeTypeTo<decimal?>(parameters[1].Value);

			return ret;
		}

		#endregion

		#region ADDISSUE792RECORD

		public static int ADDISSUE792RECORD(this TestDataDB dataConnection)
		{
			return dataConnection.ExecuteProc("MANAGED.ADDISSUE792RECORD");
		}

		#endregion

		#region OUTREFENUMTEST

		public static int OUTREFENUMTEST(this TestDataDB dataConnection, string? PSTR, out string? POUTPUTSTR, ref string? PINPUTOUTPUTSTR)
		{
			var parameters = new []
			{
				new DataParameter("PSTR",            PSTR,            LinqToDB.DataType.NVarChar),
				new DataParameter("POUTPUTSTR", null,      LinqToDB.DataType.NVarChar)
				{
					Direction = ParameterDirection.Output
				},
				new DataParameter("PINPUTOUTPUTSTR", PINPUTOUTPUTSTR, LinqToDB.DataType.NVarChar)
				{
					Direction = ParameterDirection.InputOutput
				}
			};

			var ret = dataConnection.ExecuteProc("MANAGED.OUTREFENUMTEST", parameters);

			POUTPUTSTR      = Converter.ChangeTypeTo<string?>(parameters[1].Value);
			PINPUTOUTPUTSTR = Converter.ChangeTypeTo<string?>(parameters[2].Value);

			return ret;
		}

		#endregion

		#region OUTREFTEST

		public static int OUTREFTEST(this TestDataDB dataConnection, decimal? PID, out decimal? POUTPUTID, ref decimal? PINPUTOUTPUTID, string? PSTR, out string? POUTPUTSTR, ref string? PINPUTOUTPUTSTR)
		{
			var parameters = new []
			{
				new DataParameter("PID",             PID,             LinqToDB.DataType.Decimal)
				{
					Size = 22
				},
				new DataParameter("POUTPUTID", null,       LinqToDB.DataType.Decimal)
				{
					Direction = ParameterDirection.Output,
					Size      = 22
				},
				new DataParameter("PINPUTOUTPUTID",  PINPUTOUTPUTID,  LinqToDB.DataType.Decimal)
				{
					Direction = ParameterDirection.InputOutput,
					Size      = 22
				},
				new DataParameter("PSTR",            PSTR,            LinqToDB.DataType.NVarChar),
				new DataParameter("POUTPUTSTR", null,      LinqToDB.DataType.NVarChar)
				{
					Direction = ParameterDirection.Output
				},
				new DataParameter("PINPUTOUTPUTSTR", PINPUTOUTPUTSTR, LinqToDB.DataType.NVarChar)
				{
					Direction = ParameterDirection.InputOutput
				}
			};

			var ret = dataConnection.ExecuteProc("MANAGED.OUTREFTEST", parameters);

			POUTPUTID       = Converter.ChangeTypeTo<decimal?>(parameters[1].Value);
			PINPUTOUTPUTID  = Converter.ChangeTypeTo<decimal?>(parameters[2].Value);
			POUTPUTSTR      = Converter.ChangeTypeTo<string?> (parameters[4].Value);
			PINPUTOUTPUTSTR = Converter.ChangeTypeTo<string?> (parameters[5].Value);

			return ret;
		}

		#endregion

		#region PersonDelete

		public static int PersonDelete(this TestDataDB dataConnection, decimal? PPERSONID)
		{
			var parameters = new []
			{
				new DataParameter("PPERSONID", PPERSONID, LinqToDB.DataType.Decimal)
				{
					Size = 22
				}
			};

			return dataConnection.ExecuteProc("MANAGED.PERSON_DELETE", parameters);
		}

		#endregion

		#region PersonUpdate

		public static int PersonUpdate(this TestDataDB dataConnection, decimal? PPERSONID, string? PFIRSTNAME, string? PLASTNAME, string? PMIDDLENAME, string? PGENDER)
		{
			var parameters = new []
			{
				new DataParameter("PPERSONID",   PPERSONID,   LinqToDB.DataType.Decimal)
				{
					Size = 22
				},
				new DataParameter("PFIRSTNAME",  PFIRSTNAME,  LinqToDB.DataType.NVarChar),
				new DataParameter("PLASTNAME",   PLASTNAME,   LinqToDB.DataType.NVarChar),
				new DataParameter("PMIDDLENAME", PMIDDLENAME, LinqToDB.DataType.NVarChar),
				new DataParameter("PGENDER",     PGENDER,     LinqToDB.DataType.Char)
			};

			return dataConnection.ExecuteProc("MANAGED.PERSON_UPDATE", parameters);
		}

		#endregion

		#region RESULTSETTEST

		public static IEnumerable<RESULTSETTESTResult> RESULTSETTEST(this TestDataDB dataConnection, out object? MR, out object? SR)
		{
			var parameters = new []
			{
				new DataParameter("MR", null, LinqToDB.DataType.Cursor)
				{
					Direction = ParameterDirection.Output
				},
				new DataParameter("SR", null, LinqToDB.DataType.Cursor)
				{
					Direction = ParameterDirection.Output
				}
			};

			var ret = dataConnection.QueryProc<RESULTSETTESTResult>("MANAGED.RESULTSETTEST", parameters).ToList();

			MR = Converter.ChangeTypeTo<object?>(parameters[0].Value);
			SR = Converter.ChangeTypeTo<object?>(parameters[1].Value);

			return ret;
		}

		public partial class RESULTSETTESTResult
		{
			public decimal? MASTERID { get; set; }
		}

		#endregion

		#region TestProcedure

		public static int TestProcedure(this TestDataDB dataConnection, decimal? I, out decimal? O)
		{
			var parameters = new []
			{
				new DataParameter("I", I, LinqToDB.DataType.Decimal)
				{
					Size = 22
				},
				new DataParameter("O", null, LinqToDB.DataType.Decimal)
				{
					Direction = ParameterDirection.Output,
					Size      = 22
				}
			};

			var ret = dataConnection.ExecuteProc("MANAGED.TEST_PROCEDURE", parameters);

			O = Converter.ChangeTypeTo<decimal?>(parameters[1].Value);

			return ret;
		}

		#endregion
	}

	public static partial class SqlFunctions
	{
		#region TestPACKAGE1TestFunction

		[Sql.Function(Name="MANAGED.TEST_PACKAGE1.TEST_FUNCTION", ServerSideOnly=true)]
		public static decimal? TestPACKAGE1TestFunction(decimal? I)
		{
			throw new InvalidOperationException();
		}

		#endregion

		#region TestPACKAGE2TestFunction

		[Sql.Function(Name="MANAGED.TEST_PACKAGE2.TEST_FUNCTION", ServerSideOnly=true)]
		public static decimal? TestPACKAGE2TestFunction(decimal? I)
		{
			throw new InvalidOperationException();
		}

		#endregion

		#region PatientSelectall

		[Sql.Function(Name="MANAGED.PATIENT_SELECTALL", ServerSideOnly=true)]
		public static object? PatientSelectall()
		{
			throw new InvalidOperationException();
		}

		#endregion

		#region PatientSelectbyname

		[Sql.Function(Name="MANAGED.PATIENT_SELECTBYNAME", ServerSideOnly=true)]
		public static object? PatientSelectbyname(string? PFIRSTNAME, string? PLASTNAME)
		{
			throw new InvalidOperationException();
		}

		#endregion

		#region PersonInsert

		[Sql.Function(Name="MANAGED.PERSON_INSERT", ServerSideOnly=true)]
		public static object? PersonInsert(string? PFIRSTNAME, string? PLASTNAME, string? PMIDDLENAME, string? PGENDER)
		{
			throw new InvalidOperationException();
		}

		#endregion

		#region PersonSelectall

		[Sql.Function(Name="MANAGED.PERSON_SELECTALL", ServerSideOnly=true)]
		public static object? PersonSelectall()
		{
			throw new InvalidOperationException();
		}

		#endregion

		#region PersonSelectallbygender

		[Sql.Function(Name="MANAGED.PERSON_SELECTALLBYGENDER", ServerSideOnly=true)]
		public static object? PersonSelectallbygender(string? PGENDER)
		{
			throw new InvalidOperationException();
		}

		#endregion

		#region PersonSelectbykey

		[Sql.Function(Name="MANAGED.PERSON_SELECTBYKEY", ServerSideOnly=true)]
		public static object? PersonSelectbykey(decimal? PID)
		{
			throw new InvalidOperationException();
		}

		#endregion

		#region PersonSelectbyname

		[Sql.Function(Name="MANAGED.PERSON_SELECTBYNAME", ServerSideOnly=true)]
		public static object? PersonSelectbyname(string? PFIRSTNAME, string? PLASTNAME)
		{
			throw new InvalidOperationException();
		}

		#endregion

		#region PersonSelectlistbyname

		[Sql.Function(Name="MANAGED.PERSON_SELECTLISTBYNAME", ServerSideOnly=true)]
		public static object? PersonSelectlistbyname(string? PFIRSTNAME, string? PLASTNAME)
		{
			throw new InvalidOperationException();
		}

		#endregion

		#region ScalarDatareader

		[Sql.Function(Name="MANAGED.SCALAR_DATAREADER", ServerSideOnly=true)]
		public static object? ScalarDatareader()
		{
			throw new InvalidOperationException();
		}

		#endregion

		#region ScalarReturnparameter

		[Sql.Function(Name="MANAGED.SCALAR_RETURNPARAMETER", ServerSideOnly=true)]
		public static int? ScalarReturnparameter()
		{
			throw new InvalidOperationException();
		}

		#endregion

		#region TestFunction

		[Sql.Function(Name="MANAGED.TEST_FUNCTION", ServerSideOnly=true)]
		public static decimal? TestFunction(decimal? I)
		{
			throw new InvalidOperationException();
		}

		#endregion
	}

	public static partial class TableExtensions
	{
		public static AllType? Find(this ITable<AllType> table, decimal ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static BINARYDATA? Find(this ITable<BINARYDATA> table, decimal BINARYDATAID)
		{
			return table.FirstOrDefault(t =>
				t.BINARYDATAID == BINARYDATAID);
		}

		public static DataTypeTest? Find(this ITable<DataTypeTest> table, decimal DataTypeID)
		{
			return table.FirstOrDefault(t =>
				t.DataTypeID == DataTypeID);
		}

		public static Doctor? Find(this ITable<Doctor> table, decimal PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static InheritanceChild? Find(this ITable<InheritanceChild> table, decimal InheritanceChildId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceChildId == InheritanceChildId);
		}

		public static InheritanceParent? Find(this ITable<InheritanceParent> table, decimal InheritanceParentId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceParentId == InheritanceParentId);
		}

		public static LongRawTable? Find(this ITable<LongRawTable> table, decimal ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static Patient? Find(this ITable<Patient> table, decimal PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static Person? Find(this ITable<Person> table, decimal PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static SchemaTestMatView? Find(this ITable<SchemaTestMatView> table, decimal Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static SchemaTestTable? Find(this ITable<SchemaTestTable> table, decimal Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static SEQUENCETEST? Find(this ITable<SEQUENCETEST> table, decimal ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TEntity? Find(this ITable<TEntity> table, decimal EntityId)
		{
			return table.FirstOrDefault(t =>
				t.EntityId == EntityId);
		}

		public static TestIdentity? Find(this ITable<TestIdentity> table, decimal ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TestMerge1? Find(this ITable<TestMerge1> table, decimal Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static TestMerge2? Find(this ITable<TestMerge2> table, decimal Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static TTestUser? Find(this ITable<TTestUser> table, decimal UserId)
		{
			return table.FirstOrDefault(t =>
				t.UserId == UserId);
		}

		public static TTestUserContract? Find(this ITable<TTestUserContract> table, decimal UserContractId)
		{
			return table.FirstOrDefault(t =>
				t.UserContractId == UserContractId);
		}
	}
}
