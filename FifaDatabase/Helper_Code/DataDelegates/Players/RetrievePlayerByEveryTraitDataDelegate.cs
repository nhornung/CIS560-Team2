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

    internal class GetPlayerByEveryTraitDataDelegate : DataReaderDelegate<IReadOnlyList<PlayerModel>>
    {
        public readonly string name;
        public readonly string age;
        public readonly string position;
        public readonly int height;
        public readonly int weight;


        public GetPlayerByEveryTraitDataDelegate(string name, string position, string age, int height, int weight)
           : base("WorldCupSchema.GetPlayerByEveryTrait")
        {
            this.name = name;
            this.age = age;
            this.position = position;
            this.height = height;
            this.weight = weight;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            var p = command.Parameters.Add("@Age", SqlDbType.Date);
            p.Value = age;
            if (name == "" || name == null)
            {
                p = command.Parameters.Add("@Name", SqlDbType.NVarChar);
                p.Value = System.DBNull.Value;
            }
            else
            {
                p = command.Parameters.Add("@Name", SqlDbType.NVarChar);
                p.Value = name;
            }

            if(position == "" || position == null)
            {
               p = command.Parameters.Add("@Position", SqlDbType.NVarChar);
                p.Value = System.DBNull.Value;
            }
            else
            {
               p = command.Parameters.Add("@Position", SqlDbType.NVarChar);
                p.Value = position;
            }

            p = command.Parameters.Add("@Height", SqlDbType.Int);
            p.Value = height;

            p = command.Parameters.Add("@Weight", SqlDbType.Int);
            p.Value = weight;
        }

        public override IReadOnlyList<PlayerModel> Translate(SqlCommand command, IDataRowReader reader)
        {
            var players = new List<PlayerModel>();
            int count = 0;
            while (reader.Read())
            {
                count++;
                Debug.WriteLine(count);
                players.Add(new PlayerModel(

                    reader.GetInt32("PlayerID"),
                    reader.GetString("Name"),
                    reader.GetDateTime("Age"),
                    reader.GetString("Position"),
                    reader.GetInt32("Height"),
                    reader.GetInt32("Weight")));
            }
            if (players.Count == 0)
                MessageBox.Show($"{name} Doesn't exist in the database or {name} is mispelled, you must enter the full name correctly");

            return players;
        }
    }

}
