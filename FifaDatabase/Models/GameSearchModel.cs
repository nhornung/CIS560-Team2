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


        public GameSearchModel(int gameid, string venue, int tournamentyear, string home, string away, string date, string tournamentstage, int attendance)
        {
            GameID = gameid;
            Venue = venue;
            TournamentYear = tournamentyear;
            Home = home;
            Away = away;
            GameDate = date;
            TournamentStage = tournamentstage;
            Attendance = attendance;
        }
    }
}