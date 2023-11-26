using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekat.Model;
using Model;
using projekat.Exception;

namespace projekat.Repository
{
    public class RoomRepository
    {
        private const string NOT_FOUND_ERROR = "Account with {0}:{1} can not be found!";
        private readonly string _path;
        private readonly string _delimeter;
        private readonly string _dateTimeFormat;
        private uint _roomMaxId;
        private static string _projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
        .Split(new string[] { "bin" }, StringSplitOptions.None)[0];

        private FileStream temp;

        public RoomRepository(string path, string delimeter, string dateTimeFormat)
        {
            _path = path;
            _delimeter = delimeter;
            _dateTimeFormat = dateTimeFormat;
            _roomMaxId = GetMaxId(GetAll());

        }

        private uint GetMaxId(IEnumerable<Room> rooms)
        {
            return rooms.Count() == 0 ? 0 : rooms.Max(room => room.Id);
        }

        public Room GetRoom(uint id)
        {
            try
            {

                return GetAll().SingleOrDefault(room => room.Id == id);

            }
            catch (ArgumentException)
            {

                throw new NotFoundException(string.Format(NOT_FOUND_ERROR, "id", id));

            }
        }

        public Room UpdateRoom(Room room)
        {
            string temp_file = _projectPath + "\\Resources\\tempROO.txt";
            string _file = _projectPath + "\\Resources\\room.txt";

            using (var sr = new StreamReader(_file))
            using (var sw = new StreamWriter(temp_file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string lineToWrite = ConvertRoomToCSVFormat(room);
                    Room tempApp = ConvertCSVFormatToRoom(line);
                    if (room.Id != tempApp.Id)
                    {
                        sw.WriteLine(line);
                    }
                    else
                    {
                        sw.WriteLine(lineToWrite);
                    }
                }
            }
            File.Delete(_file);
            File.Move(temp_file, _file);

            return room;
        }

        public void CheckInAppointments(ref uint counter, uint id)
        {
            string appointment_file = _projectPath + "\\Resources\\appointment.txt";
            AppointmentRepository _appointmentRepo = new AppointmentRepository(appointment_file, ";", "dd/MM/yyyy HH:mm:ss tt");

            IEnumerable<Appointment> appointments = _appointmentRepo.GetAll();

            foreach (Appointment appointment in appointments)
            {
                if (appointment.IdRoom == id)
                {
                    counter++;
                }
            }

        }

        public Room AddRoom(Room room)
        {
            room.Id = ++_roomMaxId;
            AppendLineToFile(_path, ConvertRoomToCSVFormat(room));
            return room;
        }

        public IEnumerable<Room> GetAll()
        {
            return File.ReadAllLines(_path)
                    .Select(ConvertCSVFormatToRoom)
                    .ToList();
        }

        private Room ConvertCSVFormatToRoom(string roomCSVFormat)
        {
            Room room = new Room();
            string[] tokens = roomCSVFormat.Split(_delimeter.ToCharArray());

            uint Id = uint.Parse(tokens[0]);
            string Name = tokens[1];
            Enum.TryParse(tokens[2], out RoomType type);
            uint SquareFootage = uint.Parse(tokens[3]);
            Boolean Availability = Boolean.Parse(tokens[4]);
            return new Room(
                Id,
                Name,
                type,
                SquareFootage,
                Availability
            );
        }
        private string ConvertRoomToCSVFormat(Room room)
        {
            return string.Join(_delimeter,
                room.Id,
                room.Name,
                room.Type,
                room.SquareFootage,
                room.Availability);
        }

        private void AppendLineToFile(string path, string line)
        {
            File.AppendAllText(path, line + Environment.NewLine);
        }
    }
}
