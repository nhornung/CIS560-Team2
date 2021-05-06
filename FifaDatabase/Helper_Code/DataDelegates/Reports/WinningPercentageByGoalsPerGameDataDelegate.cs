using DataAccess;
using FifaDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Helper_Code.DataDelegates.Reports
{
    public class WinningPercentageByGoalsPerGame : DataReaderDelegate<IReadOnlyList<WinningPercentageModel>>
    {
        public WinningPercentageByGoalsPerGame()
            : base("WorldCupSchema.GetWinningPercentageByGoaliestTeams")
        {
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<WinningPercentageModel> Translate(SqlCommand command, IDataRowReader reader)
        {
            var teams = new List<WinningPercentageModel>();
            while (reader.Read())
            {
                teams.Add(new WinningPercentageModel(

                    reader.GetString("Nation"),
                    reader.GetDouble("WinningPercentage"),
                    reader.GetDouble("GoalsPerGame")));
            }

            return teams;
        }

    }
}
