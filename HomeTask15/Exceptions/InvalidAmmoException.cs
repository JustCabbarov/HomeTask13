using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassTask._01._12.Exceptions
{
    public class InvalidAmmoException : Exception
    {
        public InvalidAmmoException()
        {
        }

        public InvalidAmmoException(string? message) : base(message)
        {
        }
    }
}
