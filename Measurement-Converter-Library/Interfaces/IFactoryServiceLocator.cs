using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Library.Interfaces
{
    public interface IFactoryServiceLocator
    {
        public T GetService<T>();
	}
}
