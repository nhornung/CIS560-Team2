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
    public class SqlTvViewershipRepository : ITvViewershipRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlTvViewershipRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }
        public IReadOnlyList<ViewershipModel> GetViewershipByStageOrTeam(string stage, DateTime? start, DateTime? end)
        {
            var myDelegate = new GetViewershipByStageOrTeamDataDelegate(stage, start, end);
            return executor.ExecuteReader(myDelegate);
        }
    }
}
