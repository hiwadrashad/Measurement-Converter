using Measurement_Converter_Library.Factory;
using Measurement_Converter_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Library.ServiceLocator
{
    public class FactoryServiceLocator : IFactoryServiceLocator
    {
		// references to concrete implementations
		private IDictionary<object, object> services;
		

		public FactoryServiceLocator()
		{
			services = new Dictionary<object, object>();
			// fill the map
			this.services.Add(typeof(IFactoryConsoleParameter), new Measurement_Converter_Library.Repository.ConsoleLoggingRepository());

		}

		public T GetService<T>()
		{
			try
			{
				return (T)services[typeof(T)];
			}
			catch (KeyNotFoundException)
			{
				throw new ApplicationException("The requested service is not registered");
			}
		}
	}
}
