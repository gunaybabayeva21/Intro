using class_ders;

internal class Program
{
    private static void Main(string[] args)
    {
       Product product = new Product(2,"addidas",78,250,20);
        product.Sale(5);
        Console.WriteLine(product.Income);
        product.Sale(21);
        Console.WriteLine("kifayet qeder meshul yoxdur");

    }






}