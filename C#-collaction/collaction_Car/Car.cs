using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace collaction_Car
{
    internal class Car
    {
        private int _id = 1000;
        public static int Id { get; set; }
        public string Name { get; set; }
        public int Speed { get ; set; }
        public string CarCode { get; set; }


        public Car( string name, int speed, String carCode) 
        {
            _id++;
            
            Name = name;
            Speed = speed;

            CarCode=name.Substring(0, 2).ToUpper()+Id;
            
        }


        

    }
}
