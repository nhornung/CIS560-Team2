using DataAccess;
using FifaDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Helper_Code.DataDelegates
{

    internal class RetrievePlayersDataDelegate : DataReaderDelegate<IReadOnlyList<PlayerModel>>
    {
        public RetrievePlayersDataDelegate()
            : base("WorldCupSchema.RetrievePlayers")
        {
        }

        public override IReadOnlyList<PlayerModel> Translate(SqlCommand command, IDataRowReader reader)
        {
            var players = new List<PlayerModel>();

            while (reader.Read())
            {
                players.Add(new PlayerModel(
                    reader.GetInt32("PlayerID"),
                    reader.GetString("Name"),
                    reader.GetDateTimeOffset("Age"),
                    reader.GetString("Position"),
                    reader.GetInt32("Height"),
                    reader.GetInt32("Weight")));
            }

            return players;
        }
    }
    
}

