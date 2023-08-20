using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_static
{
      internal static  class human
      {
        
        public static int Pow( this int num1,int num)
        {

            int hasil = 1;
            for(int i = 0; i <num; i++)
            {

                hasil *= num1;
                
            }return hasil;
        }


      }
}
