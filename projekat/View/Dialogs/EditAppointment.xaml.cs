using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Controller;
using projekat.Controller;
using projekat.Model;
using Model;
using System.Collections.ObjectModel;

namespace projekat.View.Dialogs
{
    /// <summary>
    /// Interaction logic for EditAppointment.xaml
    /// </summary>
    public partial class EditAppointment : Window
    {
        private AppointmentController _appointmentController;
        private RoomController _roomController;
        private DoctorController _doctorController;
        private PatientController _patientControler;

        public uint _id;
        private uint _doctorId;
        private uint _patientId;
        private uint _roomId;
        //private uint _idDelete;

        public EditAppointment(uint idD, uint idA)
        {
            _id = idA;
            _doctorId = idD;
            InitializeComponent();
            var app = Application.Current as App;
            _appointmentController = app.AppointmentController;
            _roomController = app.RoomController;
            _doctorController = app.DoctorController;
            _patientControler = app.PatientController;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var app = Application.Current as App;
            _appointmentController = app.AppointmentController;
            Appointment appoint = _appointmentController.GetApointment(_id); 
            var roomsCB = new ObservableCollection<Room>(_roomController.GetAll());
            Rooms.ItemsSource = roomsCB;
            DataContext = this;

            _doctorId = appoint.IdDoctor;
            _roomId = appoint.IdRoom;
            _patientId = appoint.IdPatient;

            Room room = _roomController.FindRoom(_roomId);
            Doctor doctor = _doctorController.ReadDoctor(_doctorId);
            Patient patient = _patientControler.ReadPatient(_patientId);

            var DAT1 = appoint.StartAppointment;
            var DAT2 = appoint.EndAppointment;

            //Rooms.Text = room.Name;
            tb5.Text = patient.Name + " " + patient.Surname;
            tb4.Text = doctor.Name + " " + doctor.Surname;
            tb2.Text = DAT1.ToString();
            tb3.Text = DAT2.ToString();
            tb1.Text = appoint.Id.ToString();
        }

        private void Rooms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (ComboBox)sender;
            var rm = (Room)item.SelectedItem;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Appointment apt = _appointmentController.GetApointment(_id);
            Room roomItem = Rooms.SelectedItem as Room;
            uint roomId = roomItem.Id;

            _doctorId = apt.IdDoctor;
            _roomId = apt.IdRoom;
            _patientId = apt.IdPatient;

            Room rm = _roomController.FindRoom(roomId);
            Doctor dc = _doctorController.ReadDoctor(_doctorId);
            Patient pt = _patientControler.ReadPatient(_patientId);

            Appointment appointment = new Appointment(apt.Id, apt.StartAppointment, apt.EndAppointment, dc.Id, pt.Id, rm.Id);
            _appointmentController.UpdateApointment(appointment);

            AppointmView ae2 = new AppointmView(_doctorId);
            ae2.Show();
            this.Close();
        }
    }
}
