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

namespace FifaDatabase.Views.CreateViews
{
    /// <summary>
    /// Interaction logic for GameCreate.xaml
    /// </summary>
    public partial class GameCreate : UserControl
    {
        const string connectionString = "Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True;";
        private SqlGameRepository repo;
        private SqlTeamRepository teamRepo;

        public GameCreate()
        {
            InitializeComponent();
            repo = new SqlGameRepository(connectionString);
            teamRepo = new SqlTeamRepository(connectionString);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try //int int gameid, int stadiumid, int tournamentid, int teama, int teamb, DateTime date, string tournamentstage, int attendance
            {
                DateTime date = (DateTime)Date.SelectedDate;
                TeamModel home = teamRepo.GetTeamByNation(HomeTeam.Text);
                TeamModel away = teamRepo.GetTeamByNation(AwayTeam.Text);
                TeamModel winner = teamRepo.GetTeamByNation(Winner.Text);
                int stadiumid = Convert.ToInt32(StadiumID.Text);

                GameModel game = repo.CreateRealGame(stadiumid, (Convert.ToInt32(TournamentYear.Text) - 1986),  home.TeamID, away.TeamID,
                    date, Stage.Text ,Convert.ToInt32(Attendance.Text), winner.TeamID);
                MessageBox.Show($"{game.GameID}: {game.GameDate}");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
