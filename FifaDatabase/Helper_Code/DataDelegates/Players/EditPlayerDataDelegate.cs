using DataAccess;
using FifaDatabase.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace FifaDatabase.Helper_Code.DataDelegates
{
    internal class EditPlayerDataDelegate : NonQueryDataDelegate<PlayerModel>
    {
        public readonly string name;
        public readonly string age;
        public readonly string position;
        public readonly int height;
        public readonly int weight;
        public readonly int playerID;


        public EditPlayerDataDelegate(string name, string position, string age, int height, int weight, int playerID)
           : base("WorldCupSchema.UpdatePlayer")
        {
            this.name = name;
            this.age = age;
            this.position = position;
            this.height = height;
            this.weight = weight;
            this.playerID = playerID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = name;

            var ageDate = Convert.ToDateTime(age);
            p = command.Parameters.Add("Age", SqlDbType.Date);
            p.Value = age;

            p = command.Parameters.Add("Position", SqlDbType.NVarChar);
            p.Value = position;

            p = command.Parameters.Add("Height", SqlDbType.Int);
            p.Value = height;

            p = command.Parameters.Add("Weight", SqlDbType.Int);
            p.Value = weight;

            p = command.Parameters.Add("PlayerID", SqlDbType.Int);
            p.Value = playerID;
        }

        public override PlayerModel Translate(SqlCommand command)
        {
            return new PlayerModel(playerID, name, Convert.ToDateTime(age), position, height, weight);
        }
    }
}