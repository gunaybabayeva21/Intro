using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exseption_sinif_hotel
{
    internal class NotAvailableExpection:Exception
    {

        public NotAvailableExpection(string massage) :base(massage)
        { 
        }
    }
}
