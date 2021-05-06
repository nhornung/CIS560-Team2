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

    internal class RetrieveManagersDataDelegate : DataReaderDelegate<IReadOnlyList<ManagerModel>>
    {
        public RetrieveManagersDataDelegate()
            : base("WorldCupSchema.RetrieveManagers")
        {
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<ManagerModel> Translate(SqlCommand command, IDataRowReader reader)
        {
            var managers = new List<ManagerModel>();
            while (reader.Read())
            {
                managers.Add(new ManagerModel(
                    reader.GetInt32("ManagerID"),
                    reader.GetString("Name"),
                    reader.GetString("Nationality")
                    ));
            }
            return managers;
        }
    }
}
