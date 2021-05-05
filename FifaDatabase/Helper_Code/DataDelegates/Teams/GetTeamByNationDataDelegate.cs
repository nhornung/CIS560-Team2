using DataAccess;
using FifaDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FifaDatabase.Helper_Code.DataDelegates
{

    internal class GetTeamByNationDataDelegate : DataReaderDelegate<TeamModel>
    {
        public readonly string nation;
        public GetTeamByNationDataDelegate(string nation)
            : base("WorldCupSchema.GetTeamByNation")
        {
            this.nation = nation;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("@Nation", SqlDbType.NVarChar);
            p.Value = nation;

            p = command.Parameters.Add("@TeamID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override TeamModel Translate(SqlCommand command, IDataRowReader reader)
        {
            var players = new List<TeamModel>();
            while (reader.Read())
            {
                players.Add(new TeamModel(

                    reader.GetInt32("TeamID"),
                    reader.GetString("Nation")));
                    
            }
            if (players.Count == 0)
                MessageBox.Show($"{nation} Doesn't exist in the database or {nation} is mispelled, you must enter the full name correctly");

            return players[0];
        }
    }
}
