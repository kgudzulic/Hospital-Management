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
    /// Interaction logic for DoctorsView.xaml
    /// </summary>
    public partial class DoctorsView : Window
    {
        private DoctorController _doctorController;

        public ObservableCollection<Doctor> Doc { get; set; }

        private uint _id_logged_in;

        public DoctorsView(uint id)
        {
            _id_logged_in = id;
            InitializeComponent();
            var app = Application.Current as App;
            _doctorController = app.DoctorController;
            //Doc = new ObservableCollection<Doctor>(_doctorController.GetAll().ToList());
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var app = Application.Current as App;
            _doctorController = app.DoctorController;
            var Doc = new ObservableCollection<Doctor>(_doctorController.GetAll());
            Doctors.ItemsSource = Doc;
            DataContext = this;
        }

        private void Doctors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (ListBox)sender;
            var doc = (Doctor)item.SelectedItem;
            var dat = doc.DateOfBirth;
            tb1.Text = doc.Username;
            tb2.Text = doc.Name;
            tb3.Text = doc.Surname;
            tb4.Text = doc.Adress;
            tb5.Text = doc.Email;
            tb6.Text = dat.ToString("dd/MM/yyyy");
            tb7.Text = doc.Specialization.ToString();
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
    }
}
