using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exseption_sinif_hotel
{
    internal class Hotel
    {
        public string Name;
        Room[] rooms=new Room[0];
        


        public Hotel( string name) 
        { 
            Name = name;    
        }

        public void AddRoom( Room room)
        {
            Array.Resize(ref rooms, rooms.Length + 1);
            rooms[rooms.Length-1] = room;

        }


        public void MakeReservation(int? roomId)
        {
            if (roomId!=null)
            {
                foreach (Room room in rooms)
                {                   
                        if(room.Id == roomId)
                        {
                            if(room.Isavailable) 
                            {
                            
                                room.Isavailable = false;
                                Console.WriteLine("rezervasiya olundu");
                            }
                            else
                            {
                                throw new NotAvailableExpection("otaq doludur");
                            }
                        }
                         
                         else
                         {
                            throw new NullReferenceException();
                         }
                    
                }
            }
                
        }

    }
}
