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

    }
}