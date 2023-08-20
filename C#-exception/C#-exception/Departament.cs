using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_task_sinif1
{
    internal class Departament
    {
        public string Name { get; set; }
        
        public int EmployeesLimit { get; set; }


        public Departament( string name, int employeeLimit)
        {
            Name = name;
            EmployeesLimit = employeeLimit;
        }

        Employee[] employees = new Employee[0];
        public void AddEmpolyee(Employee employee)
        {
            if (EmployeesLimit < employees.Length)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;
            }
            else
            {
                throw new CapacityLimitExpection("limit ashildi");
            }
            

        }




    }
}
