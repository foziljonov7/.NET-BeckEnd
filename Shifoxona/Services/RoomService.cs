using Shifoxona.Models;
using Shifoxona.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifoxona.Services
{
    public class RoomService : IRoom
    {
        private readonly PersonService person;
        private static List<Room> room = new List<Room>();
        public void CreateRoom(Room newRoom)
        {
            try
            {
                var r = new Room
                {
                    RoomId = newRoom.RoomId,
                    Department = newRoom.Department,
                    IsActive = newRoom.IsActive,
                    PersonId = newRoom.PersonId
                };

                room.Add(r);
                Console.WriteLine($"{r.RoomId} successfully saved");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Invalid operation {ex}");
            }
        }

        public void GetIsActive(int id)
        {
            var r = room.Find(r => r.RoomId == id);
            if(r.IsActive == true)
                Console.WriteLine($"{r.RoomId} bo'sh");
            else
                Console.WriteLine($"{r.RoomId} band");
        }

        public void GetRoom(int id)
        {
            var r = room.Find(r => r.RoomId == id);
            if(r != null)
            {
                Console.WriteLine(r.ToString());
                person.GetPerson(r.PersonId);
            }
            else
                Console.WriteLine($"{r.RoomId} mavjud emas");
        }

        public List<Room> GetRooms()
        {
            return room;
        }
    }
}
