using FifaDatabase.Models;
using FifaDatabase.Models.Enums;
using FifaDatabase.SqlRepos;
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

namespace FifaDatabase.Views.CreateViews
{
    /// <summary>
    /// Interaction logic for PlayerGameStatCreateView.xaml
    /// </summary>
    public partial class PlayerGameStatCreateView : UserControl
    {
        const string connectionString = "Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True;";
        private SqlPlayerGameStatRepository repo;
        //private TransactionScope transaction;

        public PlayerGameStatCreateView()
        {
            InitializeComponent();
            repo = new SqlPlayerGameStatRepository(connectionString);
            DataContextChanged += OnDataContextChanged;
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.DataContext != null)
            {
                var playerModel = (PlayerModel)this.DataContext;
                var myEnum = StatsEnum.Goal;
                PositionBox.ItemsSource = myEnum.GetNiceNames();
                PositionBox.SelectedItem = myEnum.GetNiceName();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var playerModel = (PlayerModel)this.DataContext;
            string stat = PositionBox.SelectedItem.ToString();
            int playerID = (int)playerModel.PlayerId;
            int gameID = Convert.ToInt32(NameTextBox.Text);
            int gametime = (int)WeightSlider.Value;
            try
            {
                var gamestat = repo.CreatePlayerGameStat(playerID, gameID, stat, gametime);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
