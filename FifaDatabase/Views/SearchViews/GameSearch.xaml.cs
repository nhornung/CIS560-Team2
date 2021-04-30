using FifaDatabase.Helper_Code;
using FifaDatabase.Models;
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
    /// Interaction logic for GameSearch.xaml
    /// </summary>
    public partial class GameSearch : UserControl
    {
        const string connectionString = "Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True;";
        private SqlGameRepository repo;
        //private TransactionScope transaction;

        public GameSearch()
        {
            InitializeComponent();
            repo = new SqlGameRepository(connectionString);
            Fill();

        }

        private void Fill()
        {
            try
            {
                dataGrid.ItemsSource = repo.RetrieveGames();
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
            
            try
            {
                //SqlConnection conn = new SqlConnection("Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True;");
                //SqlCommand cmd = new SqlCommand($"SELECT * FROM WorldCupSchema.Players WHERE Height <= {HeightSlider.Value.ToString()} AND Weight <= {WeightSlider.Value.ToString()}" + command, conn);
                //conn.Open();
                //SqlDataReader reader = cmd.ExecuteReader();
                //dataGrid.ItemsSource = reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GameSearchModel game = (GameSearchModel)dataGrid.SelectedItem;
            Border display = FindDisplayBorder();
            display.DataContext = game;
            display.Child = new GameView();
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
    }
}
