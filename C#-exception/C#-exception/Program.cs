using exception_task_sinif1;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee =new Employee("Gunay", 15, 300);
        Employee employee1 = new Employee("fidan", 13, 400);
        Console.WriteLine(employee.ShowInfo());

        Departament departament = new Departament("menzil", 2);
        try
        {
            departament.AddEmpolyee(employee);
            departament.AddEmpolyee(employee1);
        }
        catch (CapacityLimitExpection) 
        {
            Console.WriteLine("yerimiz yoxdur");

        }





      
    }
}