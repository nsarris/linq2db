DROP TABLE "Doctor"
GO

DROP TABLE "Patient"
GO

DROP TABLE "Person"
GO

DROP TABLE "InheritanceParent"
GO

CREATE TABLE "InheritanceParent"
(
	"InheritanceParentId" INTEGER       PRIMARY KEY NOT NULL,
	"TypeDiscriminator"   INTEGER                       Default NULL,
	"Name"                VARCHAR(50)                   Default NULL
)
GO

DROP TABLE "InheritanceChild"
GO

CREATE TABLE "InheritanceChild"
(
	"InheritanceChildId"  INTEGER      PRIMARY KEY NOT NULL,
	"InheritanceParentId" INTEGER                  NOT NULL,
	"TypeDiscriminator"   INTEGER                      Default NULL,
	"Name"                VARCHAR(50)                  Default NULL
)
GO

CREATE TABLE "Person"
( 
	"PersonID"   INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY NOT NULL,
	"FirstName"  VARCHAR(50) NOT NULL,
	"LastName"   VARCHAR(50) NOT NULL,
	"MiddleName" VARCHAR(50),
	"Gender"     CHAR(1)     NOT NULL
)
GO

INSERT INTO "Person" ("FirstName", "LastName", "Gender") VALUES ('John',   'Pupkin',    'M')
GO
INSERT INTO "Person" ("FirstName", "LastName", "Gender") VALUES ('Tester', 'Testerson', 'M')
GO
INSERT INTO "Person" ("FirstName", "LastName", "Gender") VALUES ('Jane',   'Doe',       'F')
GO
INSERT INTO "Person" ("FirstName", "LastName", "Gender") VALUES ('Jürgen', 'König',     'M')
GO

-- Doctor Table Extension

CREATE TABLE "Doctor"
(
	"PersonID" INTEGER     PRIMARY KEY NOT NULL,
	"Taxonomy" VARCHAR(50) NOT NULL,

	FOREIGN KEY "FK_Doctor_Person" ("PersonID") REFERENCES "Person"
)
GO

INSERT INTO "Doctor" ("PersonID", "Taxonomy") VALUES (1, 'Psychiatry')
GO


-- FkTest
DROP TABLE MasterTable
GO

DROP TABLE SlaveTable
GO

CREATE TABLE MasterTable
(
	ID1 INTEGER NOT NULL,
	ID2 INTEGER NOT NULL,
	PRIMARY KEY (ID1,ID2)
)
GO

CREATE TABLE SlaveTable
(
	ID1    INTEGER NOT NULL,
	"ID 2222222222222222222222  22" INTEGER NOT NULL,
	"ID 2222222222222222"           INTEGER NOT NULL,
	FOREIGN KEY FK_SlaveTable_MasterTable ("ID 2222222222222222222222  22", ID1)
	REFERENCES MasterTable
)
GO

-- Patient Table Extension

CREATE TABLE "Patient"
(
	"PersonID"  INTEGER      PRIMARY KEY NOT NULL,
	"Diagnosis" VARCHAR(256) NOT NULL,

	FOREIGN KEY "FK_Patient_Person" ("PersonID") REFERENCES "Person"
)
GO

INSERT INTO "Patient" ("PersonID", "Diagnosis") VALUES (2, 'Hallucination with Paranoid Bugs'' Delirium of Persecution')
GO


DROP TABLE "Parent"
GO
DROP TABLE "Child"
GO
DROP TABLE "GrandChild"
GO

CREATE TABLE "Parent"      ("ParentID" int, "Value1" int)
GO
CREATE TABLE "Child"       ("ParentID" int, "ChildID" int)
GO
CREATE TABLE "GrandChild"  ("ParentID" int, "ChildID" int, "GrandChildID" int)
GO


DROP TABLE "LinqDataTypes"
GO

CREATE TABLE "LinqDataTypes"
(
	"ID"             int,
	"MoneyValue"     decimal(10,4),
	"DateTimeValue"  timestamp,
	"DateTimeValue2" timestamp   Default NULL,
	"BoolValue"      smallint,
	"GuidValue"      char(16) for bit DATA,
	"BinaryValue"    blob(5000)  Default NULL,
	"SmallIntValue"  smallint,
	"IntValue"       int         Default NULL,
	"BigIntValue"    bigint      Default NULL,
	"StringValue"    VARCHAR(50) Default NULL
)
GO

DROP TABLE "TestIdentity"
GO

CREATE TABLE "TestIdentity" (
	"ID"   INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY NOT NULL
)
GO


DROP TABLE AllTypes
GO

CREATE TABLE AllTypes
(
	ID INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY NOT NULL,

	bigintDataType           bigint                Default NULL,
	intDataType              int                   Default NULL,
	smallintDataType         smallint              Default NULL,
	decimalDataType          decimal(30)           Default NULL,
	decfloatDataType         decfloat              Default NULL,
	realDataType             real                  Default NULL,
	doubleDataType           double                Default NULL,

	charDataType             char(1)               Default NULL,
	char20DataType           char(20)              Default NULL,
	varcharDataType          varchar(20)           Default NULL,
	clobDataType             clob                  Default NULL,
	dbclobDataType           dbclob(100)           CCSID 1200 Default NULL,

	binaryDataType           char(5) for bit data,
	varbinaryDataType        varchar(5) for bit data,
	blobDataType             blob                  Default NULL,
	graphicDataType          graphic(10)           CCSID 13488 Default NULL,

	dateDataType             date                  Default NULL,
	timeDataType             time                  Default NULL,
	timestampDataType        timestamp             Default NULL,

	xmlDataType              xml                   Default NULL
)
GO


INSERT INTO AllTypes (xmlDataType) VALUES (NULL)
GO

INSERT INTO AllTypes
(
	bigintDataType,
	intDataType,
	smallintDataType,
	decimalDataType,
	decfloatDataType,
	realDataType,
	doubleDataType,

	charDataType,
	varcharDataType,
	clobDataType,
	dbclobDataType,

	binaryDataType,
	varbinaryDataType,
	blobDataType,
	graphicDataType,

	dateDataType,
	timeDataType,
	timestampDataType,

	xmlDataType
)
VALUES
(
	1000000,
	7777777,
	100,
	9999999,
	8888888,
	20.31,
	16.2,

	'1',
	'234',
	'55645',
	'6687',

	'123',
	'1234',
	Cast('234' as blob),
	'23',

	Cast('2012-12-12' as date),
	Cast('12:12:12' as time),
	Cast('2012-12-12 12:12:12.012' as timestamp),

	'<root><element strattr="strvalue" intattr="12345"/></root>'
)
GO

CREATE OR REPLACE VIEW PersonView
AS
SELECT * FROM "Person"
GO

CREATE OR REPLACE Procedure Person_SelectByKey(in ID integer)
RESULT SETS 1
LANGUAGE SQL
BEGIN
	DECLARE C1 CURSOR FOR
		SELECT * FROM "Person" WHERE "PersonID" = ID;

	OPEN C1;
END
GO

DROP TABLE "TestMerge1"
GO
DROP TABLE "TestMerge2"
GO

CREATE TABLE "TestMerge1"
(
	"Id"       INTEGER            PRIMARY KEY NOT NULL,
	"Field1"   INTEGER                            Default NULL,
	"Field2"   INTEGER                            Default NULL,
	"Field3"   INTEGER                            Default NULL,
	"Field4"   INTEGER                            Default NULL,
	"Field5"   INTEGER                            Default NULL,

	"FieldInt64"      BIGINT                      Default NULL,
	"FieldBoolean"    SMALLINT                    Default NULL,
	"FieldString"     VARCHAR(20)                 Default NULL,
	"FieldNString"    NVARCHAR(20)                Default NULL,
	"FieldChar"       CHAR(1)                     Default NULL,
	"FieldNChar"      NCHAR(1)                    Default NULL,
	"FieldFloat"      REAL                        Default NULL,
	"FieldDouble"     DOUBLE                      Default NULL,
	"FieldDateTime"   TIMESTAMP(3)                Default NULL,
	"FieldBinary"     VARCHAR(20)  FOR BIT DATA       ,
	"FieldGuid"       CHAR(16)     FOR BIT DATA       ,
	"FieldDecimal"    DECIMAL(24, 10)             Default NULL,
	"FieldDate"       DATE                        Default NULL,
	"FieldTime"       TIME                        Default NULL,
	"FieldEnumString" VARCHAR(20)                 Default NULL,
	"FieldEnumNumber" INT                         Default NULL
)
GO
CREATE TABLE "TestMerge2"
(
	"Id"       INTEGER            PRIMARY KEY NOT NULL,
	"Field1"   INTEGER                            Default NULL,
	"Field2"   INTEGER                            Default NULL,
	"Field3"   INTEGER                            Default NULL,
	"Field4"   INTEGER                            Default NULL,
	"Field5"   INTEGER                            Default NULL,

	"FieldInt64"      BIGINT                      Default NULL,
	"FieldBoolean"    SMALLINT                    Default NULL,
	"FieldString"     VARCHAR(20)                 Default NULL,
	"FieldNString"    NVARCHAR(20)                Default NULL,
	"FieldChar"       CHAR(1)                     Default NULL,
	"FieldNChar"      NCHAR(1)                    Default NULL,
	"FieldFloat"      REAL                        Default NULL,
	"FieldDouble"     DOUBLE                      Default NULL,
	"FieldDateTime"   TIMESTAMP(3)                Default NULL,
	"FieldBinary"     VARCHAR(20)  FOR BIT DATA       ,
	"FieldGuid"       CHAR(16)     FOR BIT DATA       ,
	"FieldDecimal"    DECIMAL(24, 10)             Default NULL,
	"FieldDate"       DATE                        Default NULL,
	"FieldTime"       TIME                        Default NULL,
	"FieldEnumString" VARCHAR(20)                 Default NULL,
	"FieldEnumNumber" INT                         Default NULL
)
GO
