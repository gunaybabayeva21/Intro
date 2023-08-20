using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_sinif
{
    internal class procuct
    {
        
        public string Name;
        public double Price;
        public int No;
       
        public procuct( string name,int no ,double price)
        {
            No= no;
            Name = name;
            Price = price;

            
        }   
    }
}
