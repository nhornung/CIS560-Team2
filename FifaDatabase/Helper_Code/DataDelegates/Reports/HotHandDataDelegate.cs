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
    internal class HotHandDataDelegate : DataReaderDelegate<IReadOnlyList<HotHandModel>>
    {
        public HotHandDataDelegate()
            : base("WorldCupSchema.HotHand")
        {
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<HotHandModel> Translate(SqlCommand command, IDataRowReader reader)
        {
            var players = new List<HotHandModel>();
            while (reader.Read())
            {
                players.Add(new HotHandModel(

                    reader.GetString("Name"),
                    reader.GetInt32("Goals")));
            }

            return players;
        }
    }
}
