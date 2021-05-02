using System.Collections.Generic;
using DataAccess;
using System;
using FifaDatabase.Models;
using FifaDatabase.SqlRepos;
using FifaDatabase.Helper_Code.DataDelegates;
using FifaDatabase.SqlRepos.Reports;
using FifaDatabase.Helper_Code.DataDelegates.Reports;

namespace FifaDatabase.SqlRepos.Reports
{
    public class SqlHotHandRepository : IHotHandRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlHotHandRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<HotHandModel> RetrieveHotHands()
        {
            var myDelegate = new HotHandDataDelegate();
            return executor.ExecuteReader(myDelegate);
        }

    }
}