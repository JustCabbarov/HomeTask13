using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HeleperLibrary;


namespace HomeTask14
{
    public class Book
    {
        private string _code;
        public string Name { get; set; }
        public string OuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code 
        {
            get=>_code;
            set=>_code = value;
           
            
        }

        public Book(string bookNmae, int number)
        {
            _code=Helper.CreateBookCode(bookNmae, number);
        }
    }
}
