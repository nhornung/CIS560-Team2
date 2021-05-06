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

    internal class GetManagerByNameDataDelegate : DataReaderDelegate<IReadOnlyList<ManagerModel>>
    {
        public readonly string name;

        public GetManagerByNameDataDelegate(string name)
           : base("WorldCupSchema.GetManagerByName")
        {
            this.name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("@Name", SqlDbType.NVarChar);
            p.Value = name;
        }

        public override IReadOnlyList<ManagerModel> Translate(SqlCommand command, IDataRowReader reader)
        {
            var managers = new List<ManagerModel>();
            while (reader.Read())
            {
                managers.Add(new ManagerModel(
                reader.GetInt32("ManagerID"),
                reader.GetString("Name"),
                reader.GetString("Nationality")));
            }
            return managers;
        }
    }

}