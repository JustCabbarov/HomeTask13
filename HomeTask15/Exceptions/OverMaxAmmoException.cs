using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassTask._01._12.Exceptions
{
    public class OverMaxAmmoException : Exception
    {
        public OverMaxAmmoException()
        {
        }

        public OverMaxAmmoException(string? message) : base(message)
        {
        }
    }
}
