using collaction_Car;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {

        
        Car car1 = new Car("BMW", 234,"RT234");
        Car car2 = new Car("Toyota", 234,"FM456");
        Car car3 = new Car("Nissan", 234, "GH678");
        Car car4 = new Car("Hyundai", 234, "jk789");
        Car car5 = new Car("Mercedes", 234,"th789");
        Car car6 = new Car("Lada", 234,"SD123");

        Gallary galery = new Gallary("bmv");
        galery.AddCar(car2);

        galery.AddCar(car3);

        galery.AddCar(car4);
        galery.AddCar(car5);
        galery.AddCar(car6);
        


       
    }
}