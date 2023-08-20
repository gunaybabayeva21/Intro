using exseption_sinif_hotel;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {

        Room rooms1 = new Room("abseron",500,300);
        Room rooms2 = new Room( "xezer", 200, 700);
        Room rooms3 = new Room( "abseron", 400, 200);

        Hotel hotel = new Hotel("bdu");
        hotel.AddRoom(rooms1);
        hotel.AddRoom(rooms2);
        hotel.AddRoom(rooms2);


        try 
        {
            hotel.MakeReservation(1);
            hotel.MakeReservation(2);
            hotel.MakeReservation(3);
            hotel.MakeReservation(4);


        }
        catch (NotAvailableExpection ex) 
        {
        
          Console.WriteLine(ex.Message);

        }
        catch(Exception ex) 
        {
            Console.WriteLine(ex.Message);

        }
    }
}