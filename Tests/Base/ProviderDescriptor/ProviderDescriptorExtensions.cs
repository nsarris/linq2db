using LinqToDB;
using LinqToDB.Tools;

namespace Tests
{
	public static class ProviderDescriptorExtensions
	{
		public static bool HasProviderName(this ProviderDescriptor provider, string providerName) => provider.ProviderName == providerName;
		public static bool HasFullName(this ProviderDescriptor provider, string name) => provider.Context == name;

		public static bool MinVer(this ProviderDescriptor provider, decimal version) => provider.Version >= version;
		public static bool MaxVer(this ProviderDescriptor provider, decimal version) => provider.Version <= version;
		public static bool BetweenVer(this ProviderDescriptor provider, decimal minVersion, decimal maxVersion)
			=> provider.Version >= minVersion && provider.Version <= maxVersion;


		public static bool IsAccess(this ProviderDescriptor provider) => provider.Family == ProviderName.Access;
		public static bool IsDB2(this ProviderDescriptor provider) => provider.Family == ProviderName.DB2;
		public static bool IsFirebird(this ProviderDescriptor provider) => provider.Family == ProviderName.Firebird;
		public static bool IsInformix(this ProviderDescriptor provider) => provider.Family == ProviderName.Informix;
		public static bool IsMySql(this ProviderDescriptor provider) => provider.Family == ProviderName.MySql;
		public static bool IsOracle(this ProviderDescriptor provider) => provider.Family == ProviderName.Oracle;
		public static bool IsPostgreSql(this ProviderDescriptor provider) => provider.Family == ProviderName.PostgreSQL;
		public static bool IsSapHana(this ProviderDescriptor provider) => provider.Family == ProviderName.SapHana;
		public static bool IsSqlCe(this ProviderDescriptor provider) => provider.Family == ProviderName.SqlCe;
		public static bool IsSQLite(this ProviderDescriptor provider) => provider.Family == ProviderName.SQLite;
		public static bool IsSqlServer(this ProviderDescriptor provider) => provider.Family == ProviderName.SqlServer;
		public static bool IsSybase(this ProviderDescriptor provider) => provider.Family == ProviderName.Sybase;

		public static bool IsMySQLData(this ProviderDescriptor provider)
			=> provider.ProviderName.In(
				ProviderName.MySql, 
				TestProvName.MySql55, 
				TestProvName.MariaDB);

		public static bool IsSQLiteClassic(this ProviderDescriptor provider) 
			=> provider.ProviderName.StartsWith(ProviderName.SQLiteClassic);

		public static bool IsOracledManageed(this ProviderDescriptor provider) 
			=> provider.ProviderName.StartsWith(ProviderName.Oracle) 
			&& provider.ProviderName.Contains("Managed");
	}
}
