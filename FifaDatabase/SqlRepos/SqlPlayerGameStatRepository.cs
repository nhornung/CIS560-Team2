using DataAccess;
using FifaDatabase.Helper_Code.DataDelegates.PlayerGameStat;
using FifaDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.SqlRepos
{
    public class SqlPlayerGameStatRepository : IPlayerGameStatsRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlPlayerGameStatRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public PlayerGameStatModel CreatePlayerGameStat(int gameID, int playerID, string stat, int gametime)
        {
            var myDelegate = new CreatePlayerGameStatDataDelegate(gameID, playerID, stat, gametime);
            return executor.ExecuteNonQuery(myDelegate);
        }
    }
}
