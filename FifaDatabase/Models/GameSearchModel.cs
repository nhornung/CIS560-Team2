using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Models
{
    public class GameSearchModel
    {
        public int GameID { get; set; }
        public string Venue { get; set; }
        public int TournamentYear { get; set; }
        public string Home { get; set; }
        public string Away { get; set; }
        public string GameDate { get; set; }
        public string TournamentStage { get; set; }
        public int Attendance { get; set; }
        public int TeamA { get; set; }
        public int TeamB { get; set; }
        public int Winner { get; set; }


        public GameSearchModel(int gameid, string venue, int tournamentyear, string home, string away, DateTime date, string tournamentstage, int attendance, int teama, int teamb, int winner)
        {
            GameID = gameid;
            Venue = venue;
            TournamentYear = tournamentyear;
            Home = home;
            Away = away;
            GameDate = date.ToShortDateString();
            TournamentStage = tournamentstage;
            Attendance = attendance;
            Winner = winner;
            TeamA = teama;
            TeamB = teamb;
        }
    }
}