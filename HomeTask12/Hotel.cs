using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12
{
    public class Hotel
    {
        public string Name { get; set; }
        private Room[] rooms = Array.Empty<Room>();
        public Hotel(string name)
        {
            Name = name;
        }
        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms, rooms.Length + 1);
            rooms[^1] = room;
        }

        public Room MAkeREservation(int? roomId)
        {
            
            foreach (Room room in rooms)
            {
                if (room.IsAvailable == false)
                {
                    throw new NotAvailableException("Otaq Rezerv Olunub");
                }
                if (room.Id == roomId)
                {
                    if (room.IsAvailable == true)
                    {
                        Console.WriteLine("Qeydiyyat Ugurla Basa Catdi");
                        room.IsAvailable = false;
                    }
                    return room;
                }
            }
            throw new NullReferenceException("Otaq Tapilmadi");

        }
    }
}
