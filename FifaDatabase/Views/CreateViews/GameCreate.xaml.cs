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
            int errorCount = 0;
            if(HomeTeam.Text == "" || HomeTeam.Text== null)
            {
                errorCount++;
                MessageBox.Show("Home Team cannot be empty");
                return;
            }

            if (AwayTeam.Text == "" || AwayTeam.Text == null)
            {
                errorCount++;
                MessageBox.Show("Away Team cannot be empty");
                return;
            }

            if (Winner.Text == "" || Winner.Text == null)
            {
                errorCount++;
                MessageBox.Show("Winner cannot be empty");
                return;
            }

            if (StadiumID.Text == "" || StadiumID.Text == null)
            {
                errorCount++;
                MessageBox.Show("StadiumID cannot be empty");
                return;
            }

            if (TournamentYear.Text == "" || TournamentYear.Text == null)
            {
                errorCount++;
                MessageBox.Show("Enter a valid Tournament year between 1986-2010");
                return;
            }
            int year = 1986 - Convert.ToInt32(TournamentYear.Text);
            if (Convert.ToInt32(TournamentYear.Text) < 1986 || Convert.ToInt32(TournamentYear.Text) > 2010)
            {
                errorCount++;
                MessageBox.Show("Those years are not supported");
                return;
            }

            if (year % 4.0 != 0)
            {
                errorCount++;
                MessageBox.Show("That year is not a valid World Cup year, pick a valid year!");
                return;
            }
            if (Date.SelectedDate == null)
            {
                errorCount++;
                MessageBox.Show("Pick a game date!");
                return;
            }
            string[] yearValidator = Date.SelectedDate.ToString().Split('/', ' ');
            if (yearValidator[2] != TournamentYear.Text)
            {
                errorCount++;
                MessageBox.Show("Pick a game date that matches the tournament year!");
                return;
            }

            try
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

        private void HomeTeam_TextChanged(object sender, TextChangedEventArgs e)
        {
            FaintLetteringHome.Visibility = Visibility.Hidden;
        }

        private void TournamentYear_TextChanged(object sender, TextChangedEventArgs e)
        {
            FaintLetteringTourneyYear.Visibility = Visibility.Hidden;
        }

        private void AwayTeam_TextChanged(object sender, TextChangedEventArgs e)
        {
            FaintLetteringAway.Visibility = Visibility.Hidden;
        }

        private void Stage_TextChanged(object sender, TextChangedEventArgs e)
        {
            FaintLetteringStage.Visibility = Visibility.Hidden;
        }

        private void Winner_TextChanged(object sender, TextChangedEventArgs e)
        {
            FaintLetteringWinner.Visibility = Visibility.Hidden;
        }

        private void StadiumID_TextChanged(object sender, TextChangedEventArgs e)
        {
            FaintLetteringStadium.Visibility = Visibility.Hidden;
        }

        private void Attendance_TextChanged(object sender, TextChangedEventArgs e)
        {
            FaintLetteringAttendance.Visibility = Visibility.Hidden;
        }
    }
}
