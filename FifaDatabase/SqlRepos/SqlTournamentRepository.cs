using System.Collections.Generic;
using DataAccess;
using System;
using FifaDatabase.Models;
using FifaDatabase.SqlRepos;
using FifaDatabase.Helper_Code.DataDelegates;

namespace FifaDatabase.SqlRepos
{
    public class SqlTournamentRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlTournamentRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<TournamentModel> RetrieveTournaments()
        {
            var myDelegate = new RetrieveTournamentsDataDelegate();
            return executor.ExecuteReader(myDelegate);
        }

    }
}