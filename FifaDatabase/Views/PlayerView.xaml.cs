using FifaDatabase.Models;
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

namespace FifaDatabase.Views
{
    /// <summary>
    /// Interaction logic for PlayerView.xaml
    /// </summary>
    public partial class PlayerView : UserControl
    {
        const string connectionString = "Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True;";
        private SqlGameStatsRepository repo;
        //private TransactionScope transaction;

        public PlayerView()
        {
            InitializeComponent();
            repo = new SqlGameStatsRepository(connectionString);
            DataContextChanged += OnDataContextChanged;
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.DataContext != null)
            {
                var playerModel = (PlayerModel)this.DataContext;
                PlayerDataGrid_Copy.ItemsSource = repo.GetPlayerStatsByID((int)playerModel.PlayerId);
            }
        }
    }
}
