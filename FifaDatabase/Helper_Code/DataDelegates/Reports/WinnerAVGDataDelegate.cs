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
    public class WinnerAVGDataDelegate : DataReaderDelegate<IReadOnlyList<DoTraitsMatterModel>>
    {
        public WinnerAVGDataDelegate()
            : base("WorldCupSchema.DoTraitsMatterWinners")
        {
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<DoTraitsMatterModel> Translate(SqlCommand command, IDataRowReader reader)
        {
            var players = new List<DoTraitsMatterModel>();
            while (reader.Read())
            {
                players.Add(new DoTraitsMatterModel(

                    reader.GetDateTime("WinnerAgeAVG"),
                    reader.GetInt32("WinnerHeightAVG"),
                    reader.GetInt32("WinnerWeightAVG")));
            }

            return players;
        }

    }
}
