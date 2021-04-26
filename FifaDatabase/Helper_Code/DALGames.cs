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
    class DALGames
    {
        public List<GameModel> GetAllGames()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper_Code.Common.Helper.CnnVal("FifaWorldCup")))
            {
                try
                {

                    var output = connection.Query<GameModel>($"SELECT * FROM WorldCupSchema.Game").ToList();
                    return output;

                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.ToString());
                }
            }
            return null;
        }

        public List<TeamModel> GetTeams(string Nation)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper_Code.Common.Helper.CnnVal("FifaWorldCup")))
            {
                try
                {

                    var output = connection.Query<TeamModel>($"SELECT * FROM WorldCupSchema.Game WHERE Nation = '{Nation}'").ToList();
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
