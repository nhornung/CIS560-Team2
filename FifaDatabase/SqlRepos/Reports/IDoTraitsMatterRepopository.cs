using FifaDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.SqlRepos.Reports
{
    public interface IDoTraitsMatterRepopository
    {
        IReadOnlyList<DoTraitsMatterModel> RetrieveWinnerAVG();
        IReadOnlyList<DoTraitsMatterModel> RetrieveLoserAVG();
    }
}
