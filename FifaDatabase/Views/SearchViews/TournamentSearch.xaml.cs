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

namespace FifaDatabase.Views.SearchViews
{
    /// <summary>
    /// Interaction logic for TournamentSearch.xaml
    /// </summary>
    public partial class TournamentSearch : UserControl
    {
        const string connectionString = "Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True;";
        private SqlTournamentRepository repo;
        //private TransactionScope transaction;

        public TournamentSearch()
        {
            InitializeComponent();
            repo = new SqlTournamentRepository(connectionString);
            Fill();

        }

        private async void Fill()
        {
            try
            {
                TournamentDataGrid.ItemsSource = repo.RetrieveTournaments();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
