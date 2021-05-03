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

    internal class RetrieveGamesDataDelegate : DataReaderDelegate<IReadOnlyList<GameSearchModel>>
    {
        public RetrieveGamesDataDelegate()
            : base("WorldCupSchema.RetrieveGames")
        {
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<GameSearchModel> Translate(SqlCommand command, IDataRowReader reader)
        {
            var games = new List<GameSearchModel>();
            while (reader.Read())
            {
                games.Add(new GameSearchModel(
                    reader.GetInt32("GameID"),
                    reader.GetString("Venue"),
                    reader.GetInt32("TournamentYear"),
                    reader.GetString("HomeTeam"),
                    reader.GetString("AwayTeam"),
                    reader.GetDateTime("GameDate"),
                    reader.GetString("TournamentStage"),
                    reader.GetInt32("Attendance"),
                    reader.GetInt32("TeamA"),
                    reader.GetInt32("TeamB"),
                    reader.GetInt32("Winner")
                    )) ;
             }
            return games;
        }
    }
}
