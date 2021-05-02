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
    public class LoserAVGDataDelegate :  DataReaderDelegate<IReadOnlyList<DoTraitsMatterModel>>
    {
        public LoserAVGDataDelegate()
            : base("WorldCupSchema.DoTraitsMatterLosers")
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

                reader.GetDateTime("LoserAgeAVG"),
                reader.GetInt32("LoserHeightAVG"),
                reader.GetInt32("LoserWeightAVG")));
        }

        return players;
    }
    
    }
}
