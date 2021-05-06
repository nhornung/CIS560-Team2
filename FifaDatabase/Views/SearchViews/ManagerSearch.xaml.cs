using FifaDatabase.SqlRepos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace FifaDatabase.Views.SearchViews
{
    /// <summary>
    /// Interaction logic for ManagerSearch.xaml
    /// </summary>
    public partial class ManagerSearch : UserControl
    {
        const string connectionString = "Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True;";
        private SqlManagerRepository repo;
        //private TransactionScope transaction;

        public ManagerSearch()
        {
            InitializeComponent();
            repo = new SqlManagerRepository(connectionString);
            Fill();

        }

        private async void Fill()
        {
            try
            {
                PlayerDataGrid.ItemsSource = repo.RetrieveManagers();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            // PlayerModel actual = repo.CreatePlayer("Johnny Bummers", new DateTime(2015, 12, 25), "FM", 177, 81);
            // MessageBox.Show(actual.Name.ToString() + actual.Height.ToString() + actual.PlayerId.ToString());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = NameSearchTextBox.Text;
            PlayerDataGrid.ItemsSource = repo.GetManagerByName(name);
        }
    }
}

