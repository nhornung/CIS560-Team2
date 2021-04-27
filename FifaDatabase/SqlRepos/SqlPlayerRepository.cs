using System.Collections.Generic;
using DAL;
using FifaDatabase.Models;
using FifaDatabase.Helper_Code.DataDelegates;
using System;
using FifaDatabase.SqlRepos;

namespace FifaDatabase
{
    public class SqlPlayerRepository : IPlayerRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlPlayerRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public PlayerModel CreatePlayer(string name, DateTime age, string position, int height, int weight)
        {
            //if (string.IsNullOrWhiteSpace(firstName))
            //    throw new ArgumentException("The parameter cannot be null or empty.", nameof(firstName));

            //if (string.IsNullOrWhiteSpace(lastName))
            //    throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastName));

            //if (string.IsNullOrWhiteSpace(email))
            //    throw new ArgumentException("The parameter cannot be null or empty.", nameof(email));

            var d = new CreatePlayerDataDelegate(name, age, position, height, weight);
            return executor.ExecuteNonQuery(d);
        }

        public IReadOnlyList<PlayerModel> RetrievePlayers()
        {
            return executor.ExecuteReader(new RetrievePlayersDataDelegate());
        }
    }
}
