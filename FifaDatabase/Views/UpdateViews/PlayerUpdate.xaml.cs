using FifaDatabase.Models;
using FifaDatabase.SqlRepos;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data;
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

namespace FifaDatabase.Views
{
    /// <summary>
    /// Interaction logic for PlayerUpdate.xaml
    /// </summary>
    public partial class PlayerUpdate : UserControl
    {
        const string connectionString = "Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True;";
        private SqlPlayerRepository repo;
        //private TransactionScope transaction;

        public PlayerUpdate()
        {
            InitializeComponent();
            repo = new SqlPlayerRepository(connectionString);
            DataContextChanged += OnDataContextChanged;
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
            if (this.DataContext != null)
            {
                var player = (PlayerModel)this.DataContext;
                HeightSlider.Value = (double)player.Height;
                WeightSlider.Value = (double)player.Weight;
                try
                {
                    PositionEnum enm = (PositionEnum)Enum.Parse(typeof(PositionEnum), player.Position);
                    PositionBox.SelectedItem = enm;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Player has an invalid position");
                }
                
                
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = NameSearchTextBox.Text;
            string position = "";
            if (PositionBox.SelectedItem != null || PositionBox.SelectedItem.ToString() != "Any")
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
            PlayerModel player = (PlayerModel)this.DataContext;
            int playerID = (int)player.PlayerId;
            try
            {
                this.DataContext = repo.EditPlayer(name, position, date, height, weight, playerID);
                MessageBox.Show("Player Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void NameSearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FaintLetteringText.Visibility = Visibility.Hidden;
        }
    }
}
