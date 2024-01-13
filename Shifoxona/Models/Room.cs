using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifoxona.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string Department { get; set; }
        public bool IsActive { get; set; }
        public int PersonId { get; set; }

        public override string ToString()
        {
            return $"{RoomId}, {Department}, {IsActive}";
        }
    }
}
