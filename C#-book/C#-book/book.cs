using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace task_sinif
{
    
    internal class book:procuct
    {
        public string Janr;
        public book(string janr, string name,int no,double price ):base( name, no, price)
        {
            Janr = janr;

        }

       

    }
     


}
