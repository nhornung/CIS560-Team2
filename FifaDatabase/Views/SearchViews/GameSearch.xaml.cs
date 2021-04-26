using FifaDatabase.Helper_Code;
using FifaDatabase.Models;
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

namespace FifaDatabase.Views.SearchViews
{
    /// <summary>
    /// Interaction logic for GameSearch.xaml
    /// </summary>
    public partial class GameSearch : UserControl
    {
        List<FifaDatabase.Models.GameModel> games = new List<FifaDatabase.Models.GameModel>();
        public GameSearch()
        {
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {
            DALGames db = new DALGames();
            games = db.GetAllGames();
            PlayerDataGrid.ItemsSource = games;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataAccess db = new DataAccess();

            games = db.GetPlayers(this.NameSearchTextBox.Text);
            PlayerDataGrid.ItemsSource = games;

        }
    }
}
