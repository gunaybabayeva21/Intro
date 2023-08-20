using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace calass_task
{
    internal class Manager
    {
      protected Employee Getpromation(Employee employee)//Employee tipinden
      {

            employee.salary += 100;
            return employee;

      }

    }
}
