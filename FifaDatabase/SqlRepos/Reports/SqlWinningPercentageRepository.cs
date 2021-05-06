using FifaDatabase.Helper_Code.DataDelegates.Reports;
using FifaDatabase.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FifaDatabase.Helper_Code.DataDelegates;

namespace FifaDatabase.SqlRepos.Reports
{
    public class SqlWinningPercentageRepository 
    {
        private readonly SqlCommandExecutor executor;

        public SqlWinningPercentageRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }
        public IReadOnlyList<WinningPercentageModel> GetViewershipByStageOrTeam()
        {
            var myDelegate = new WinningPercentageByGoalsPerGame();
            return executor.ExecuteReader(myDelegate);
        }
    }
}
