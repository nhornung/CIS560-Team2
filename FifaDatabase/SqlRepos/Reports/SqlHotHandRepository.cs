using FifaDatabase.Helper_Code.DataDelegates.Reports;
using FifaDatabase.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
