using Shifoxona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifoxona.Repository
{
    public interface IRoom
    {
        List<Room> GetRooms();
        void GetRoom(int id);
        void CreateRoom(Room newRoom);
        void GetIsActive(int id);
    }
}
