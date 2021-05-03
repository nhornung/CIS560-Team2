using FifaDatabase.Models;
using FifaDatabase.SqlRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Diagnostics;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace FifaDatabase.Views.SearchViews
{
    
    /// <summary>
    /// Interaction logic for Players.xaml
    /// </summary>
    public partial class PlayerSearch : UserControl
    {
        const string connectionString = "Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True;";
        private SqlPlayerRepository repo;
        //private TransactionScope transaction;

        public PlayerSearch()
        {
            InitializeComponent();
            repo = new SqlPlayerRepository(connectionString);
            PositionBox.SelectedItem = PositionEnum.Any;
            Fill();
            
        }

        private async void Fill()
        {
            try
            {
                PlayerDataGrid.ItemsSource = repo.RetrievePlayers();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            // PlayerModel actual = repo.CreatePlayer("Johnny Bummers", new DateTime(2015, 12, 25), "FM", 177, 81);
           // MessageBox.Show(actual.Name.ToString() + actual.Height.ToString() + actual.PlayerId.ToString());
               
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DynamicSearch();
        }

        private void DynamicSearch()
        {
            string name = NameSearchTextBox.Text;
            string position = "";
            if (PositionBox.SelectedItem != null && PositionBox.SelectedItem.ToString() != "Any")
            {
                position = PositionBox.SelectedItem.ToString();
            }
            string date = "1/1/2050";
            if (AgeDatePicker.SelectedDate != null)
            {
                date = AgeDatePicker.SelectedDate.ToString();
            }
            int height = (int)HeightSlider.Value;
            int weight = (int)WeightSlider.Value;
            try
            {
                PlayerDataGrid.ItemsSource = repo.GetPlayerByEveryTrait(name, position, date, height, weight);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void PlayerDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var item = PlayerDataGrid.SelectedItem;
                PlayerModel player = (PlayerModel)PlayerDataGrid.SelectedItem;
                Border display = FindDisplayBorder();
                display.DataContext = player;
                display.Child = new PlayerView();
            }
            catch(Exception ex)
            {
                MessageBox.Show("You encountered a bug, good job");
            }
        }

        private Border FindDisplayBorder()
        {
            // Start climbing the tree from this node
            DependencyObject parent = this;
            do
            {
                // Get this node's parent
                parent = LogicalTreeHelper.GetParent(parent);
            }
            // Invariant: there is a parent element, and it is not a ListSwitcher 
            while (!(parent is null || parent is MainWindow));
            MainWindow main = (MainWindow)parent;
            Border displayBorder = (Border)main.DisplayBorder;
            return displayBorder;
        }

        private void NameSearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FaintLetteringText.Visibility = Visibility.Hidden;
        }
    }
}


