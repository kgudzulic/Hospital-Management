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
using System.Text.RegularExpressions;

namespace projekat.View.Dialogs
{
    /// <summary>
    /// Interaction logic for AddAllergen.xaml
    /// </summary>
    public partial class AddAllergen : Window
    {
        private AllergenController _allergenController;

        public ObservableCollection<Allergen> Doc { get; set; }

        public uint _idD;

        public AddAllergen(uint idDoc)
        {
            _idD = idDoc;
            InitializeComponent();
            var app = Application.Current as App;
            _allergenController = app.AllergenController;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var app = Application.Current as App;
            _allergenController = app.AllergenController;
            var Alg = new ObservableCollection<Allergen>(_allergenController.GetAll());
            int i = Alg.Count() + 1;

            if (tb2.Text.Length == 0)
            {
                errormessage.Text = "All fields must be filled.";
                tb2.Focus();
            }
            else if (!Regex.IsMatch(tb2.Text, @"^[A-Z][a-z]*$"))
            {
                errormessage.Text = "Enter a valid allergen name.";
                tb2.Select(0, tb2.Text.Length);
                tb2.Focus();
            }
            else
            {
                Allergen allergen = new Allergen((uint)i, tb2.Text);
                _allergenController.CreateNewAllergen(allergen);

                AllergensList ae2 = new AllergensList(_idD);
                ae2.Show();
                this.Close();
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var app = Application.Current as App;
            _allergenController = app.AllergenController;
            var Alg = new ObservableCollection<Allergen>(_allergenController.GetAll());
            int i = Alg.Count() + 1;

            tb1.Text = i.ToString();
        }
    }
}
