using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;
using FifaDatabase.Models;
using FifaDatabase.SqlRepos;
using FifaDatabase.Views.SearchViews;

namespace FifaDatabase.Views
{
    //CreatePlayer
    /// <summary>
    /// Interaction logic for PlayerCreate.xaml
    /// </summary>
    public partial class PlayerCreate : UserControl
    {

        const string connectionString = "Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True;";
        private SqlPlayerRepository repo;
        //private TransactionScope transaction;

        public PlayerCreate()
        {
            InitializeComponent();
            repo = new SqlPlayerRepository(connectionString);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int errorCount = 0;
            if(NameTextBox.Text == "" || NameTextBox.Text == null)
            {
                errorCount++;
                MessageBox.Show("You must give the player a name!");
            }
            if (AgeDatePicker.SelectedDate.ToString() == "" || AgeDatePicker.SelectedDate.ToString() == null)
            {
                errorCount++;
                MessageBox.Show("You must give the player birthdate!");
            }
            if(PositionBox.SelectedItem == "" || PositionBox.SelectedItem == null)
            {
                errorCount++;
                MessageBox.Show("You must give the player a position!");
            }
            if(errorCount == 0)
            {
                try
                {
                    PlayerModel player = repo.CreatePlayer(NameTextBox.Text, AgeDatePicker.SelectedDate.ToString(), PositionBox.SelectedItem.ToString(), Convert.ToInt32(HeightSlider.Value), Convert.ToInt32(WeightSlider.Value));
                    MessageBox.Show($"{player.Name} succesfully created");
                    Border Display = FindDisplayBorder();
                    Display.Child = new PlayerSearch();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
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
    }
}
