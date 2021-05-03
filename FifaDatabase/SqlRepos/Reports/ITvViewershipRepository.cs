using FifaDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.SqlRepos.Reports
{
    public interface ITvViewershipRepository
    {
        IReadOnlyList<ViewershipModel> GetViewershipByStageOrTeam(string stage, DateTime? start, DateTime? end);
    }
}
