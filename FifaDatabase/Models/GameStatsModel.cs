using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Models
{
    public class GameStatsModel
    {
        public int Goals { get; set; }
        public int Saves { get; set; }
        public int Assists { get; set; }
        public int Tackles { get; set; }
        public int YellowCard { get; set; }
        public int RedCard { get; set; }



        public GameStatsModel(int goals, int saves, int assists, int tackles, int yellowcard, int redcard)
        {
            Goals = goals;
            Saves = saves;
            Assists = assists;
            Tackles = tackles;
            YellowCard = yellowcard;
            RedCard = redcard;
        }
    }
}
