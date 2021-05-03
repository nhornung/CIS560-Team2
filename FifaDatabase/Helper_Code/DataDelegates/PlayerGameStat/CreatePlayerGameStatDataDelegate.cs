using DataAccess;
using FifaDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Helper_Code.DataDelegates.PlayerGameStat
{
    internal class CreatePlayerGameStatDataDelegate : NonQueryDataDelegate<PlayerGameStatModel>
    {
        public readonly int gameID;
        public readonly int playerID;
        public readonly string stat;
        public readonly int gametime;

        public CreatePlayerGameStatDataDelegate(int gameID, int playerID, string stat, int gametime)
           : base("WorldCupSchema.CreatePlayerGameStat")
        {
            this.gameID = gameID;
            this.playerID = playerID;
            this.stat = stat;
            this.gametime = gametime;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("@GameID", SqlDbType.Int);
            p.Value = gameID;

            p = command.Parameters.Add("@PlayerID", SqlDbType.Int);
            p.Value = playerID;

            p = command.Parameters.Add("@Stat", SqlDbType.NVarChar);
            p.Value = stat;

            p = command.Parameters.Add("@GameTime", SqlDbType.Int);
            p.Value = gametime;
        }

        public override PlayerGameStatModel Translate(SqlCommand command)
        {
            return new PlayerGameStatModel((int)command.Parameters["PlayerID"].Value, playerID, stat, gametime);
        }
    }
}
