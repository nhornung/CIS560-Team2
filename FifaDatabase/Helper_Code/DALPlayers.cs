using Dapper;
using FifaDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaDatabase.Helper_Code
{
    class DALPlayers
    {
        public List<PlayerModel> GetPlayers(string Name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper_Code.Common.Helper.CnnVal("FifaWorldCup")))
            {
                try
                {

                    var output = connection.Query<PlayerModel>($"SELECT * FROM WorldCupSchema.Player WHERE Name = '{Name}'").ToList();
                    return output;

                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.ToString());
                }
            }
            return null;
        }

        public List<PlayerModel> GetAllPlayers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper_Code.Common.Helper.CnnVal("FifaWorldCup")))
            {
                try
                {

                    var output = connection.Query<PlayerModel>($"SELECT * FROM WorldCupSchema.Player").ToList();
                    return output;

                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.ToString());
                }
            }
            return null;
        }
    }
}
