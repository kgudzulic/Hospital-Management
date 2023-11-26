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
using projekat.Controller;
using Controller;
using projekat.Model;
using Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace projekat.View.Dialogs
{
    /// <summary>
    /// Interaction logic for AllergensList.xaml
    /// </summary>
    public partial class AllergensList : Window
    {
        private uint _id;
        private AllergenController _allergenController;

        public ObservableCollection<Allergen> Data { get; set; }

        public AllergensList(uint id)
        {
            _id = id;
            InitializeComponent();
            var app = Application.Current as App;
            _allergenController = app.AllergenController;

            Data = new ObservableCollection<Allergen>(_allergenController.GetAll().ToList());

            for (int i = 0; i < Data.Count(); i++)
            {
                Allergen alg = _allergenController.GetAllergen(Data[i].Id);
                Data[i].Id = alg.Id;
                Data[i].Name = alg.Name;
                DataGridXAML.Items.Add(Data[i]);
            }
            Allergen ap = DataGridXAML.SelectedItem as Allergen;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            addBtn.IsEnabled = true;
            editBtn.IsEnabled = false;
            removeBtn.IsEnabled = false;
        }

        private void DataGridXAML_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            addBtn.IsEnabled = true;
            editBtn.IsEnabled = true;
            removeBtn.IsEnabled = true;
        }

        private void appoint_Click(object sender, RoutedEventArgs e)
        {
            new AppointmView(_id)
            {
                Owner = Application.Current.MainWindow
            }
            .ShowDialog();
        }

        private void profile_Click(object sender, RoutedEventArgs e)
        {
            new DoctorHomepage(_id)
            {
                Owner = Application.Current.MainWindow
            };
            this.Close();
        }

        private void patinfo_Click(object sender, RoutedEventArgs e)
        {
            new PatientsView(_id)
            {
                Owner = Application.Current.MainWindow
            }
            .ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _id = 555;
            new DoctorLogin()
            {
                Owner = Application.Current.MainWindow
            }
            .ShowDialog();
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            DataContext = this;

            Allergen al = DataGridXAML.SelectedItem as Allergen;
            _allergenController.DeleteAllergen(al.Id);

            for (int i = 0; i < Data.Count(); i++)
            {
                if (Data[i].Id == al.Id)
                {
                    DataGridXAML.Items.Remove(Data[i]);
                }
            }
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            Allergen al = DataGridXAML.SelectedItem as Allergen;
            Allergen temp = _allergenController.GetAllergen(al.Id);
            new EditAllergen(_id, al.Id)
            {
                Owner = Application.Current.MainWindow
            }
            .ShowDialog();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            new AddAllergen(_id)
            {
                Owner = Application.Current.MainWindow
            }
            .ShowDialog();
        }

        private void req_Click(object sender, RoutedEventArgs e)
        {
            new ReqTimeOff(_id)
            {

            }.ShowDialog();
        }

        private void appmed_Click(object sender, RoutedEventArgs e)
        {
            new UMeds(_id)
            {

            }.ShowDialog();
        }
    }
}
