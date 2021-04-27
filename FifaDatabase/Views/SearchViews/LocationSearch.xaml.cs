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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FifaDatabase.Helper_Code;
using FifaDatabase.Helper_Code.Common;
using FifaDatabase.Models;

namespace FifaDatabase.Views.SearchViews
{
    /// <summary>
    /// Interaction logic for LocationSearch.xaml
    /// </summary>
    public partial class LocationSearch : UserControl
    {
        //List<LocationModel> locations = new List<LocationModel>();

        public LocationSearch()
        {
            InitializeComponent();
            Fill();
        }
        List<LocationModel> locations = new List<LocationModel>();
        private void Fill()
        {
            DALLocations db = new DALLocations();
            locations = db.GetAllLocations();
            dataGRid.ItemsSource = locations;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DALLocations db = new DALLocations();

            locations = db.GetLocations(this.NameSearchTextBox.Text);
            dataGRid.ItemsSource = locations;

        }
    }
}
