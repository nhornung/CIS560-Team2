using DataAccess;
using FifaDatabase.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace FifaDatabase.Helper_Code.DataDelegates
{
    internal class CreatePlayerDataDelegate : NonQueryDataDelegate<PlayerModel>
    {
        public readonly string name;
        public readonly DateTime age;
        public readonly string position;
        public readonly int height;
        public readonly int weight;


        public CreatePlayerDataDelegate(string name, DateTime age, string position, int height, int weight)
           : base("WorldCupSchema.CreatePlayer")
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

            var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = name;

            p = command.Parameters.Add("Age", SqlDbType.Date);
            p.Value = age;

            p = command.Parameters.Add("Position", SqlDbType.NVarChar);
            p.Value = position;

            p = command.Parameters.Add("Height", SqlDbType.Int);
            p.Value = height;

            p = command.Parameters.Add("Weight", SqlDbType.Int);
            p.Value = weight;

            p = command.Parameters.Add("PlayerID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override PlayerModel Translate(SqlCommand command)
        {
            return new PlayerModel((int)command.Parameters["PlayerID"].Value, name, age, position, height, weight);
        }
    }
}