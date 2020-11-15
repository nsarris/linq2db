using System.Collections.Generic;
using System.Linq;
using LinqToDB;

namespace Tests
{
	public interface IProviderDescriptorFactory
	{
		ProviderDescriptor FromContext(string context);
	}

	public class ProviderDescriptorFactory : IProviderDescriptorFactory
	{
		protected readonly static IEnumerable<string> providerFamilies = new []
		{
			ProviderName.Access,
			ProviderName.DB2,
			ProviderName.Firebird,
			ProviderName.Informix,
			ProviderName.MySql,
			ProviderName.Oracle,
			ProviderName.PostgreSQL,
			ProviderName.SapHana,
			ProviderName.SqlCe,
			ProviderName.SQLite,
			ProviderName.SqlServer,
			ProviderName.Sybase,
		};

		protected virtual IEnumerable<string> GetProviderFamilies() => providerFamilies;

		public ProviderDescriptor FromContext(string context)
			=> new ProviderDescriptor(
				context: context,
				family: context switch
				{
					TestProvName.SqlAzure => ProviderName.SqlServer,
					TestProvName.MariaDB => ProviderName.MySql,
					_ => GetProviderFamilies().FirstOrDefault(context.StartsWith) ??
									context
				},
				version: context.Replace(".LinqService", "") switch
				{
					var x when x.StartsWith(ProviderName.SqlServer)
						=> decimal.TryParse(x.Split('.').Last(), out var version) ? version : default(decimal?),
					var x when x.StartsWith(ProviderName.PostgreSQL)
						=> decimal.TryParse(string.Join(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator, x.Split('.').Skip(1)), out var version) ? version : default(decimal?),
					_ => default
				});
	}
}
