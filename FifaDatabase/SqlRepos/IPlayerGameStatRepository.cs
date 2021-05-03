using FifaDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.SqlRepos
{
     public interface IPlayerGameStatsRepository
    {
        PlayerGameStatModel CreatePlayerGameStat(int gameID, int playerID, string stat, int gametime);
    }
}
