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
    /// Interaction logic for Players.xaml
    /// </summary>
    public partial class PlayerSearch : UserControl
    {
        List<FifaDatabase.Models.PlayerModel> players = new List<FifaDatabase.Models.PlayerModel>();

        public PlayerSearch()
        {
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {
            DataAccess db = new DataAccess();
            players = db.GetAllPlayers();
            PlayerDataGrid.ItemsSource = players;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataAccess db = new DataAccess();

            players = db.GetPlayers(this.NameSearchTextBox.Text);
            PlayerDataGrid.ItemsSource = players;

        }
    }
}
