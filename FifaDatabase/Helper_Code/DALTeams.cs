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
    class DALTeams
    {
        public List<TeamModel> GetAllTeams()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper_Code.Common.Helper.CnnVal("FifaWorldCup")))
            {
                try
                {

                    var output = connection.Query<TeamModel>($"SELECT * FROM WorldCupSchema.Team").ToList();
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

                    var output = connection.Query<TeamModel>($"SELECT * FROM WorldCupSchema.Team WHERE Nation = '{Nation}'").ToList();
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
