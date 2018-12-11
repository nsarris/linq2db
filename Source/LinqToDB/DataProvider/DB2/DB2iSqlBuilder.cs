using System;

namespace LinqToDB.DataProvider.DB2
{
	using SqlProvider;

	class DB2iSqlBuilder : DB2SqlBuilderBase
	{
		public DB2iSqlBuilder(ISqlOptimizer sqlOptimizer, SqlProviderFlags sqlProviderFlags, ValueToSqlConverter valueToSqlConverter)
			: base(sqlOptimizer, sqlProviderFlags, valueToSqlConverter)
		{
		}

		protected override ISqlBuilder CreateSqlBuilder()
		{
			return new DB2iSqlBuilder(SqlOptimizer, SqlProviderFlags, ValueToSqlConverter);
		}

		protected override DB2Version Version
		{
			get { return DB2Version.i; }
		}
	}
}
