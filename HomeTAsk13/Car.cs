using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HomeTask13
{
    internal class Car
    {
        public static int Counter;
        private int ID {  get; set; }
        public string Brand {  set; get; }
        public string Model {  get; set; }
        public CarTypeEnum Type { set; get; }

        public Car()
        {
           ID=++Counter;
        }
        public override string ToString()
        {
            return  $"Id {ID}  ,  Brand {Brand}  ,  Model {Model}  ,  Type {Type}";
        }

    }
}
