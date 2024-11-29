using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12
{
    public class Room
    {
        public static int counter;
         public int Id { get;  }
        public string Name { get; set; }    
        public int Price { get; set; }  
        public int  PersonCapacity { get; set; }
        public bool IsAvailable = true;
        public override string ToString()
        {
            return $"Id {Id}, Name {Name}, Price {Price}, PersonCapacity {PersonCapacity}";
        }
        public Room(string name,int price ,int personcapasity)
        {
            Id=++counter;
            Name = name ;
            Price = price ;
            PersonCapacity = personcapasity ;
        }
    }
}
