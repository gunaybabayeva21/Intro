using System.Windows.Markup;

internal class Program
{
   
    private static void Main(string[] args)
    {
        List<int> values = new List<int>();

        while (true) 
        {
            Console.WriteLine("enter number:  ");
            string  secim=(Console.ReadLine());
            Console.WriteLine("  ");
             
            switch(secim) 
            {
                case "y":
                case "Y":
                Console.WriteLine("ededdaxil edin");
                values.Add(Convert.ToInt32(Console.ReadLine()));
                    break;
                    default:
                    int sum = 0;
                    values.FindAll(x=>x%2==1).ForEach(x=>sum+=x);
                    Console.WriteLine(sum);
                    return;


            }
        }




    }
}