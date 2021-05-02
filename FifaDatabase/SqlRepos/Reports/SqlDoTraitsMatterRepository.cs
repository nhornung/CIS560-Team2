using DataAccess;
using FifaDatabase.Helper_Code.DataDelegates.Reports;
using FifaDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.SqlRepos.Reports
{
    public class SqlDoTraitsMatterRepository : IDoTraitsMatterRepopository
    {
        private readonly SqlCommandExecutor executor;

        public SqlDoTraitsMatterRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<DoTraitsMatterModel> RetrieveWinnerAVG()
        {
            var myDelegate = new WinnerAVGDataDelegate();
            return executor.ExecuteReader(myDelegate);
        }

        public IReadOnlyList<DoTraitsMatterModel> RetrieveLoserAVG()
        {
            var myDelegate = new LoserAVGDataDelegate();
            return executor.ExecuteReader(myDelegate);
        }

    }
}
