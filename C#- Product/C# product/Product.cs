using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ders
{
    internal class Product
    {
        public byte Id;
        public string Bradname;
        public double Price;
        public double Cost;
        public double Income;
        public int Count;//cekdiyimiz xerc

        public Product( byte id, string Bradname, double Price, double Cost, int Count )
        {
            this.Id = id;
            this.Bradname = Bradname;
            this.Price = Price;
            this.Cost = Cost;
          
           
            if ( Count<0 )
            {
                Count = 0;
            }
            else if ( Count>0 )
            {
                Count = Count;
            }


        }

        public void Sale( int newCount)
        { 


            if ( newCount<=Count)
            {
                Income += (Price - Cost) * newCount;
                Count-=newCount;
            }
            else
            {
                Console.WriteLine("kifayet qeder meshul yoxdur");
            }

        }

    }
}
