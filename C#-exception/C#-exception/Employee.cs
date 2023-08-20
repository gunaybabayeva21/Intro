using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_task_sinif1
{
    internal class Employee: IPerson
    {
        private int _id;    
        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            _id++;
            _id = Id;
           Name= name;
            Age = age;
            Salary = salary;

        
        }

        public string ShowInfo() 
        {
            return $" {Id} {Name} {Age} {Salary}";
        }

        public override string ToString() 
        { 
          return ShowInfo();
        }


    }
}
