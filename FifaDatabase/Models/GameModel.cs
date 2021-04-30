using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Models
{
    public class GameModel
    {
        public int GameID { get; set; }
        public int StadiumID { get; set; }
        public int TournamentID { get; set; }
        public int TeamA { get; set; }
        public int TeamB { get; set; }
        public string GameDate { get; set; }
        public string TournamentStage { get; set; }
        public int Attendance { get; set; }


        public GameModel(int gameid, int stadiumid, int tournamentid, int teama, int teamb, DateTime date, string tournamentstage, int attendance)
        {
            GameID = gameid;
            StadiumID = stadiumid;
            TournamentID = tournamentid;
            TeamA = teama;
            TeamB = teamb;
            GameDate = date.ToShortDateString();
            TournamentStage = tournamentstage;
            Attendance = attendance;
        }
    }
}

