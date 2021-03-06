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

    internal class GetPlayerStatsByIDDataDelegate : DataReaderDelegate<IReadOnlyList<GameStatsModel>>
    {
        public readonly int playerid;

        public GetPlayerStatsByIDDataDelegate(int playerid)
           : base("WorldCupSchema.GetPlayerStatsByID")
        {
            this.playerid = playerid;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("@PlayerID", SqlDbType.NVarChar);
            p.Value = playerid;
        }

        public override IReadOnlyList<GameStatsModel> Translate(SqlCommand command, IDataRowReader reader)
        {
            var gameStats = new List<GameStatsModel>();
            while (reader.Read())
            {
                gameStats.Add(new GameStatsModel(
                reader.GetInt32("GameID"),
                reader.GetInt32("TournamentYear"),
                reader.GetInt32("Goals"),
                reader.GetInt32("Saves"),
                reader.GetInt32("Tackles"),
                reader.GetInt32("Assists"),
                reader.GetInt32("RedCard"),
                reader.GetInt32("YellowCard")));
            }
            return gameStats;
        }
    }

}