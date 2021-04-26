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
    class DALLocations
    {
        public List<LocationModel> GetLocations(string Country)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper_Code.Common.Helper.CnnVal("FifaWorldCup")))
            {
                try
                {

                    var output = connection.Query<LocationModel>($"SELECT * FROM WorldCupSchema.Location WHERE COUNTRY = '{Country}'").ToList();
                    return output;

                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.ToString());
                }
            }
            return null;
        }

        public List<LocationModel> GetAllLocations()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper_Code.Common.Helper.CnnVal("FifaWorldCup")))
            {
                try
                {

                    var output = connection.Query<LocationModel>($"SELECT * FROM WorldCupSchema.Location").ToList();
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
