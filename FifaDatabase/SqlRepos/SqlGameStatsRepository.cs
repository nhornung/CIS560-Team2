using System.Collections.Generic;
using DataAccess;
using System;
using FifaDatabase.Models;
using FifaDatabase.SqlRepos;
using FifaDatabase.Helper_Code.DataDelegates;

namespace FifaDatabase.SqlRepos
{
    public class SqlGameStatsRepository : IPlayerGameStatsRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlGameStatsRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<GameStatsModel> RetrieveHomeTeamStats(int gameid)
        {
            var myDelegate = new RetrieveGameStatsHomeTeamDataDelegate(gameid);
            return executor.ExecuteReader(myDelegate);
        }

        public IReadOnlyList<GameStatsModel> RetrieveAwayTeamStats(int gameid)
        {
            var myDelegate = new RetrieveGameStatsAwayTeamDataDelegate(gameid);
            return executor.ExecuteReader(myDelegate);
        }

        public IReadOnlyList<GameStatsModel> GetPlayerStatsByID(int gameid)
        {
            var myDelegate = new GetPlayerStatsByIDDataDelegate(gameid);
            return executor.ExecuteReader(myDelegate);
        }
    }
}
