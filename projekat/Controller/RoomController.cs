using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using projekat.Model;
using projekat.Service;

namespace projekat.Controller
{
    public class RoomController
    {
        private readonly RoomService _service;

        public RoomController(RoomService service)
        {
            _service = service;
        }
        public Room CreateNewRoom(Room room)
        {
            return _service.CreateNewRoom(room);
        }

        public Room FindRoom(uint id)
        {
            return _service.FindRoom(id);
        }

        public Room ChangeRoom(Room room)
        {
            return _service.ChangeRoom(room);
        }

        public IEnumerable<Room> GetAll()
        {
            return _service.GetAll();
        }
    }
}
