using System.Collections.Generic;
using DataAccess;
using System;
using FifaDatabase.Models;
using FifaDatabase.SqlRepos;
using FifaDatabase.Helper_Code.DataDelegates;

namespace FifaDatabase.SqlRepos
{
    public class SqlManagerRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlManagerRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<TeamModel> RetrieveTeams()
        {
            var myDelegate = new RetrieveTeamsDataDelegate();
            return executor.ExecuteReader(myDelegate);
        }

        public TeamModel GetTeamByNation(string nation)
        {
            var myDelegate = new GetTeamByNationDataDelegate(nation);
            return executor.ExecuteReader(myDelegate);
        }

    }
}