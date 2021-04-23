using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Models
{
    public class GameModel
    {
        public int GameId { get; set; }
        public int StadiumID { get; set; }
        public int TournamentID { get; set; }
        public int TeamA { get; set; }
        public int TeamB { get; set; }
        public int Weight { get; set; }
        public DateTime GameDate { get; set; }
        public int Attendance { get; set; }
        public string TournamentStage { get; set; }
    }
}
