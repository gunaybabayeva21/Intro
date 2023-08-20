internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine(Stringreverse("babayeba"));
        

    }



    static string Stringreverse(string newsurname)
    { 
        string surname = " ";
        for(int i= newsurname.Length - 1; i>=0;i--)
        {
            surname += newsurname[i];

          
        }
        return surname;
        
    }

}