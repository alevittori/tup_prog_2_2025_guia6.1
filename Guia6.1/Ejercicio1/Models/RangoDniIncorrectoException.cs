using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class RangoDniIncorrectoException:ApplicationException
    {
        public RangoDniIncorrectoException():base("Rango de DNI no valido") { }

        public RangoDniIncorrectoException(string message) : base(message) { }

        public RangoDniIncorrectoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
