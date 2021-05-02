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

namespace FifaDatabase.Views
{
    //CreatePlayer
    /// <summary>
    /// Interaction logic for PlayerCreate.xaml
    /// </summary>
    public partial class PlayerCreate : UserControl
    {

        const string connectionString = "Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True;";
        private SqlHotHandRepository repo;
        //private TransactionScope transaction;

        public PlayerCreate()
        {
            InitializeComponent();
            repo = new SqlHotHandRepository(connectionString);
            Fill();

        }

        private async void Fill()
        {
            try
            {
               // repo.CreatePlayer();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            // PlayerModel actual = repo.CreatePlayer("Johnny Bummers", new DateTime(2015, 12, 25), "FM", 177, 81);
            // MessageBox.Show(actual.Name.ToString() + actual.Height.ToString() + actual.PlayerId.ToString());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PlayerModel player = repo.CreatePlayer(NameTextBox.Text, AgeDatePicker.SelectedDate.ToString(), PositionBox.SelectedItem.ToString(), Convert.ToInt32(HeightSlider.Value), Convert.ToInt32(WeightSlider.Value));
                MessageBox.Show(player.Name);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
