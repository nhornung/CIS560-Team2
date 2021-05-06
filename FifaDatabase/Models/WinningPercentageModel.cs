using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Models
{
    public class WinningPercentageModel
    {
        public string Nation { get; set; }
        public double WinningPercentage { get; set; }
        public double GoalsPerGame { get; set; }

        public WinningPercentageModel(string nation, double winningpercentage, double goalsagame)
        {
            Nation = nation;
            WinningPercentage = Math.Round(winningpercentage * 100, 2);
            GoalsPerGame = Math.Round(goalsagame, 2); ;
        }
    }
}
