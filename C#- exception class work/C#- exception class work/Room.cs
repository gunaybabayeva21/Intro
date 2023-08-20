using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exseption_sinif_hotel
{
    internal class Room
    {

        private static int _id;
        public   int Id { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool Isavailable { get; set; } = true;
            
        public Room( string name, int price, int Personcapacity )
        {
            _id++;
            Id= _id;
         Name = name;
         Price = price; 
         PersonCapacity = Personcapacity;

        }

        public string ShowInfo()
        {
            return $" id:{Id} name:{Name} price:{Price}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }

    }
}
