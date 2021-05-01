using System;
using System.Collections.Generic;
using FifaDatabase.Models;

namespace FifaDatabase.SqlRepos
{
    public interface IGameStatsRepository
    {
        IReadOnlyList<GameStatsModel> RetrieveHomeTeamStats(int gameid);
        IReadOnlyList<GameStatsModel> RetrieveAwayTeamStats(int gameid);
        IReadOnlyList<GameStatsModel> GetPlayerStatsByID(int playerid);
    }
}