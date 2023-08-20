using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_method
{
    internal class Student
    {
        public int _id;
        public int Id { get; set; } 
        public string Fullname { get; set; }
        public int Age { get; set; }


        public Student(string fullname,int age) 
        
        {         
            _id++;
            Fullname = fullname;
            Age = age;
        
        }
    }
}
