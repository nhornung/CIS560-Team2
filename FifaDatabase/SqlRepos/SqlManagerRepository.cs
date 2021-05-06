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

        public IReadOnlyList<ManagerModel> RetrieveManagers()
        {
            var myDelegate = new RetrieveManagersDataDelegate();
            return executor.ExecuteReader(myDelegate);
        }

        public IReadOnlyList<ManagerModel> GetManagerByName(string name)
        {
            var myDelegate = new GetManagerByNameDataDelegate(name);
            return executor.ExecuteReader(myDelegate);
        }

    }
}