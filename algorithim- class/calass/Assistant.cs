using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calass_task
{
    internal class Assistant:Manager
    {
       public void GetFeedBAck(Employee employee )
       {
            if( employee.issuccessful )
            {
                Getpromation(employee);
            }

       }

    }
}
