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

    internal class GetViewershipByStageOrTeamDataDelegate : DataReaderDelegate<IReadOnlyList<ViewershipModel>>
    {
        public readonly string stage;
        public readonly DateTime? start;
        public readonly DateTime? end;

        public GetViewershipByStageOrTeamDataDelegate(string stage, DateTime? start, DateTime? end)
           : base("WorldCupSchema.GetViewershipByStageOrTeam")
        {
            this.stage = stage;
            this.start = start;
            this.end = end;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            if(stage == null)
            {
                var p = command.Parameters.Add("@Stage", SqlDbType.NVarChar);
                p.Value = System.DBNull.Value;
            }
            else
            {
                var p = command.Parameters.Add("@Stage", SqlDbType.NVarChar);
                p.Value = stage;
            }
            if (start == null)
            {
                var p = command.Parameters.Add("@GameDate1", SqlDbType.NVarChar);
                p.Value = new DateTime(1900, 07, 28);
            }
            else
            {
                var p = command.Parameters.Add("@GameDate1", SqlDbType.NVarChar);
                p.Value = start;
            }
            if (end == null)
            {
                var p = command.Parameters.Add("@GameDate2", SqlDbType.NVarChar);
                p.Value = new DateTime(2050, 01, 01);
            }
            else
            {
                var p = command.Parameters.Add("@GameDate2", SqlDbType.NVarChar);
                p.Value = end;
            }
        }

        public override IReadOnlyList<ViewershipModel> Translate(SqlCommand command, IDataRowReader reader)
        {
            var viewers = new List<ViewershipModel>();
            while (reader.Read())
            {
                viewers.Add(new ViewershipModel(
                    reader.GetInt32("Views"),
                    reader.GetString("Nation"),
                    stage
                ));
            }
            
            return viewers;
        }
    }

}
