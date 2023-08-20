using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_task_sinif1
{
    internal class CapacityLimitExpection:Exception
    {

       public CapacityLimitExpection(string massage) : base(massage)
       {

       }

    }
}
