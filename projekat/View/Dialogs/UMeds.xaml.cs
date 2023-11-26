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
using Controller;
using projekat.Controller;
using projekat.Model;
using System.Collections.ObjectModel;

namespace projekat.View.Dialogs
{
    /// <summary>
    /// Interaction logic for UMeds.xaml
    /// </summary>
    public partial class UMeds : Window
    {
        private uint _id_logged_in;
        
        private MedicineController _medicineController;

        public ObservableCollection<Medicine> Data { get; set; }

        public UMeds(uint _id)
        {
            _id_logged_in = _id;
            InitializeComponent();
            var app = Application.Current as App;
            _medicineController = app.MedicineController;

            Data = new ObservableCollection<Medicine>(_medicineController.GetAll().ToList());

            for (int i = 0; i < Data.Count(); i++)
            {
                Medicine med = _medicineController.GetMedicine(Data[i].Id);
                Data[i].Id = med.Id;
                Data[i].Name = med.Name;

                if (Data[i].IsApproved == false)
                {
                    DataGridXAML.Items.Add(Data[i]);
                }
            }
            Medicine m = DataGridXAML.SelectedItem as Medicine;
        }

        private void DataGridXAML_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (DataGrid)sender;
            var pac = (Medicine)item.SelectedItem;
            tbl1.Text = pac.Ingredients;
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Medicine medItem = DataGridXAML.SelectedItem as Medicine;
            uint medId = medItem.Id;

            Medicine m = _medicineController.GetMedicine(medId);
            Medicine medicine = new Medicine(m.Id, m.Name, m.Ingredients, m.AllergenId, true);
            _medicineController.UpdateMedicine(medicine);

            UMeds um2 = new UMeds(_id_logged_in);
            um2.Show();
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            new AppointmView(_id_logged_in)
            {

            }.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            new DoctorHomepage(_id_logged_in)
            {
                Owner = Application.Current.MainWindow
            };
            this.Close();
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
            new AnamnesisView(_id_logged_in)
            {

            }.ShowDialog();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
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
