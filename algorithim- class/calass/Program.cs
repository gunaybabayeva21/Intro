using calass_task;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee = new Employee(); 
        employee.name = "Test";
        employee.issuccessful = true;
        employee.salary = 200;


        Assistant assistant = new Assistant();
        assistant.GetFeedBAck(employee);
        Console.WriteLine(employee.salary);
        
    }
}