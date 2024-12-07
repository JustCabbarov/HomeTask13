using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassTask._01._12.Exceptions
{
    internal class InvalidCurrentAmmoException : Exception
    {
        public InvalidCurrentAmmoException()
        {
        }

        public InvalidCurrentAmmoException(string? message) : base(message)
        {
        }
    }
}
