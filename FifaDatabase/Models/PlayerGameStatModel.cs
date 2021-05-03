using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Models
{
    public class PlayerGameStatModel
    {
        public int PlayerID { get; set; }
        public int GameID { get; set; }
        public string Stat { get; set; }
        public int GameTime { get; set; }



        public PlayerGameStatModel(int playerid, int gameid, string stat, int gametime)
        {
            PlayerID = playerid;
            GameID = gameid;
            Stat = stat;
            GameTime = gametime;
        }
    }
}
