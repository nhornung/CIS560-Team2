using System.Collections.Generic;
using DataAccess;
using System;
using FifaDatabase.Models;
using FifaDatabase.SqlRepos;
using FifaDatabase.Helper_Code.DataDelegates;

namespace FifaDatabase.SqlRepos
{
    public class SqlGameRepository : IGameRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlGameRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<GameSearchModel> RetrieveGames()
        {
            var myDelegate = new RetrieveGamesDataDelegate();
            return executor.ExecuteReader(myDelegate);
        }

        public GameModel CreateRealGame(int stadiumid, int tournamentid, int teama, int teamb, DateTime date,
            string tournamentstage, int attendance, int winner)
        {
            var myDelegate = new CreateGameDataDelegate(stadiumid, tournamentid, teama, teamb, date, tournamentstage, attendance, winner);
            return executor.ExecuteNonQuery(myDelegate);
        }

    }
}