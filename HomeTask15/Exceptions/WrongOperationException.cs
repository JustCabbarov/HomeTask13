using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassTask._01._12.Exceptions
{
    public class WrongOperationException : Exception
    {
        public WrongOperationException()
        {
        }

        public WrongOperationException(string? message) : base(message)
        {
        }
    }
}
