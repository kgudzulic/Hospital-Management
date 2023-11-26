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
using Model;
using projekat.Model;
using Controller;
using projekat.Controller;
using System.Collections.ObjectModel;

namespace projekat.View.Dialogs
{
    /// <summary>
    /// Interaction logic for AnamnesisView.xaml
    /// </summary>
    public partial class AnamnesisView : Window
    {
        private uint _id_logged_in;
        private AppointmentController _appointmentController;
        private RoomController _roomController;
        private DoctorController _doctorController;
        private PatientController _patientControler;
        public ObservableCollection<Patient> Pat { get; set; }
        public ObservableCollection<Appointment> Data { get; set; }
        public AnamnesisView(uint id)
        {
            _id_logged_in = id;
            InitializeComponent();
            var app = Application.Current as App;
            _patientControler = app.PatientController;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            new DoctorHomepage(_id_logged_in)
            {
                Owner = Application.Current.MainWindow
            };
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            new AppointmView(_id_logged_in)
            {

            }.ShowDialog();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            new ReqTimeOff(_id_logged_in)
            {

            }.ShowDialog();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            new PatientsView(_id_logged_in)
            {

            }.ShowDialog();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            new UMeds(_id_logged_in)
            {

            }.ShowDialog();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            new AnamnesisView(_id_logged_in)
            {

            }.ShowDialog();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            _id_logged_in = 555;
            new DoctorLogin()
            {
                Owner = Application.Current.MainWindow
            }.ShowDialog();
            this.Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var app = Application.Current as App;
            _patientControler = app.PatientController;
            var Pat = new ObservableCollection<Patient>(_patientControler.GetAll());
            Patients.ItemsSource = Pat;
            DataContext = this;
        }

        private void Patients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGridXAML.Items.Clear();
            var app = Application.Current as App;
            _appointmentController = app.AppointmentController;
            var Apt = new ObservableCollection<Appointment>(_appointmentController.GetAll());
            var item = (ListBox)sender;
            var pac = (Patient)item.SelectedItem;
            Patient p = _patientControler.ReadPatient(pac.Id);

            _appointmentController = app.AppointmentController;
            _roomController = app.RoomController;
            _doctorController = app.DoctorController;
            _patientControler = app.PatientController;

            Data = new ObservableCollection<Appointment>(_appointmentController.GetAll().ToList());


            for (int i = 0; i < Data.Count(); i++)
            {
                Room room = _roomController.FindRoom(Data[i].IdRoom);
                Doctor doctor = _doctorController.ReadDoctor(Data[i].IdDoctor);
                Data[i].RoomName = room.Name;
                Data[i].DoctorName = doctor.Name;
                Data[i].DoctorSurname = doctor.Surname;

                if (Data[i].IdPatient == pac.Id)
                {
                    DataGridXAML.Items.Add(Data[i]);
                }
            }
            Appointment ap = DataGridXAML.SelectedItem as Appointment;

            /*foreach(Appointment x in Apt)
            {
                if(x.IdPatient == p.Id && x.IdDoctor == _id_logged_in)
                {
                    Appointments.ItemsSource = Apt;
                    DataContext = this;
                }
            }*/
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            if (tbl1.Text == "")
            {
                MessageBox.Show("Field cannot be empty.");
            }
            else if (tbl1.Text.Length < 50)
            {
                MessageBox.Show("Anamnesis must be at least 50 characters long.");
            }
            else
            {
                MessageBox.Show("Anamnesis created succesfully!");
            }
        }
    }
}
