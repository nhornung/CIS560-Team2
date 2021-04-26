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

namespace FifaDatabase.Views
{
    /// <summary>
    /// Interaction logic for Team.xaml
    /// </summary>
    public partial class TeamSearch : UserControl
    {
        List<FifaDatabase.Models.TeamModel> teams = new List<FifaDatabase.Models.TeamModel>();
        public TeamSearch()
        {
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {
            DataAccess db = new DataAccess();
            teams = db.GetAllTeams();
            TeamDataGrid.ItemsSource = teams;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataAccess db = new DataAccess();

            teams = db.GetTeams(this.TeamSearchTextBox.Text);
            TeamDataGrid.ItemsSource = teams;

        }
    }
}
