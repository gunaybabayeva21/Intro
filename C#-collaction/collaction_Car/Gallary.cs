using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collaction_Car
{
    internal class Gallary
    {

        private int _id = 1000;
        static int Id { get; set; }
        
        public string Name { get; set; }
        List<Car> Cars {  get; set; }= new List<Car>();

        public Gallary(string name) 
        
        {
            Id=_id;
            _id++;
            Name = name;
        }

        public  void AddCar(Car car) 
        {
            Cars.Add(car);
         
        }

        public void ShowAllCars(Car car) 
        { 
            for(int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine($" {Name:Cras}  ");

            }
        
        }


        

        

    }

    
}
