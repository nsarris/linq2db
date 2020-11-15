using System;

namespace Tests
{
	public class ProviderDescriptor
	{
		public ProviderDescriptor(string context, string family)
			: this(context, family, null)
		{
		}

		public ProviderDescriptor(string context, string family, decimal? version)
		{
			Family = family ?? throw new ArgumentNullException(nameof(family));
			Context = context ?? throw new ArgumentNullException(nameof(context));
			Version = version;

			IsLinqService = context.EndsWith("LinqService");
			ProviderName = IsLinqService ? context.Replace(".LinqService", "") : context;
		}

		/// <summary>
		/// Name including LinqService suffix.
		/// </summary>
		public string Context { get; }

		/// <summary>
		/// The actual provider name without the LinqService suffix.
		/// </summary>
		public string ProviderName { get; }

		/// <summary>
		/// The provider family.
		/// </summary>
		public string Family { get; }

		/// <summary>
		/// Returns true if the provider contains the LinqService suffix.
		/// </summary>
		public bool IsLinqService { get; }

		/// <summary>
		/// The providers numeric version or null if not applicable.
		/// </summary>
		public decimal? Version { get; }

		public void Deconstruct(out string providerName, out string family, out decimal? version, out bool isLinqService)
		{
			providerName = ProviderName;
			family = Family;
			version = Version;
			isLinqService = IsLinqService;
		}

		public void Deconstruct(out string providerName, out string family, out decimal? version)
		{
			providerName = ProviderName;
			family = Family;
			version = Version;
		}

		public void Deconstruct(out string providerName, out string family)
		{
			providerName = ProviderName;
			family = Family;
		}
	}
}
