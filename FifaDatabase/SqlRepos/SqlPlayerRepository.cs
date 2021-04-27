using System.Collections.Generic;
using DataAccess;
using System;
using FifaDatabase.Models;
using FifaDatabase.SqlRepos;
using FifaDatabase.Helper_Code.DataDelegates;

namespace PersonData
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
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            if (age == null)
                throw new ArgumentException("The parameter cannot be null", nameof(age));

            if (string.IsNullOrWhiteSpace(position))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(position));
            if (height < 100)
                throw new ArgumentException("Input is too small", nameof(height));
            if (height > 100)
                throw new ArgumentException("Input is too large", nameof(height));
            if (weight < 100)
                throw new ArgumentException("Input is too small", nameof(height));
            if (weight > 100)
                throw new ArgumentException("Input is too large", nameof(height));

            var myDelegate = new CreatePlayerDataDelegate(name, age, position, height, weight);
            return executor.ExecuteNonQuery(myDelegate);
        }


        public PlayerModel GetPlayerByID(int playerID)
        {
            throw new NotImplementedException();
        }

        public PlayerModel GetPlayerByName(string name)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<PlayerModel> RetrievePersons()
        {
            var myDelegate = new RetrievePlayersDataDelegate();
            return executor.ExecuteReader(myDelegate);
        }

        public IReadOnlyList<PlayerModel> RetrievePlayers()
        {
            throw new NotImplementedException();
        }
    }
}
