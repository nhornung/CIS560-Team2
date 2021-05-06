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

    internal class RetrieveTournamentsDataDelegate : DataReaderDelegate<IReadOnlyList<TournamentModel>>
    {
        public RetrieveTournamentsDataDelegate()
            : base("WorldCupSchema.RetrieveTournaments")
        {
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<TournamentModel> Translate(SqlCommand command, IDataRowReader reader)
        {
            var tournaments = new List<TournamentModel>();
            while (reader.Read())
            {
                tournaments.Add(new TournamentModel(

                    reader.GetInt32("Tournament"),
                    reader.GetString("Country"),
                    reader.GetDateTime("StartDate"),
                    reader.GetDateTime("EndDate")));
            }

            return tournaments;
        }
    }

}
