using DataAccess;
using FifaDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Helper_Code.DataDelegates
{

    internal class RetrieveTeamsDataDelegate : DataReaderDelegate<IReadOnlyList<TeamModel>>
    {
        public RetrieveTeamsDataDelegate()
            : base("WorldCupSchema.RetrieveTeams")
        {
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<TeamModel> Translate(SqlCommand command, IDataRowReader reader)
        {
            var teams = new List<TeamModel>();
            while (reader.Read())
            {
                teams.Add(new TeamModel(

                    reader.GetInt32("TeamID"),
                    reader.GetString("Nation")));
            }

            return teams;
        }
    }

}
