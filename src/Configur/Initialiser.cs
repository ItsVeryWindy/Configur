using System;

namespace Configur
{
	public static class ConfigurInitialiser
	{
		class ConfigurBuilder : IConfigurBuilder
		{
			
		}

		public static IConfigurBuilder Initialise (ConfigurSettings settings)
		{
			return new ConfigurBuilder();
		}
	}
}

