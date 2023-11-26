using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekat.Model;
using projekat.Repository;

namespace projekat.Service
{
    public class RoomService
    {
        private readonly RoomRepository _repo;

        public RoomService(RoomRepository repo)
        {
            _repo = repo;
        }

        public Room FindRoom(uint id)
        {
            return _repo.GetRoom(id);
        }

        public Room ChangeRoom(Room room)
        {
            return _repo.UpdateRoom(room);
        }

        public Room CreateNewRoom(Room room)
        {
            return _repo.AddRoom(room);
        }

        public IEnumerable<Room> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
