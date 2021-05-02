using System.Collections.Generic;
using DataAccess;
using System;
using FifaDatabase.Models;
using FifaDatabase.SqlRepos;
using FifaDatabase.Helper_Code.DataDelegates;

namespace FifaDatabase.SqlRepos
{
    public class SqlHotHandRepository : IPlayerRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlHotHandRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public PlayerModel CreatePlayer(string name, string age, string position, int height, int weight)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            if (age == null)
                throw new ArgumentException("The parameter cannot be null", nameof(age));

            if (string.IsNullOrWhiteSpace(position))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(position));
            if (height < 100)
                throw new ArgumentException("Input is too small", nameof(height));
            if (height > 250)
                throw new ArgumentException("Input is too large", nameof(height));
            if (weight < 55)
                throw new ArgumentException("Input is too small", nameof(height));
            if (weight > 100)
                throw new ArgumentException("Input is too large", nameof(height));

            var myDelegate = new CreatePlayerDataDelegate(name, age, position, height, weight);
            return executor.ExecuteNonQuery(myDelegate);
        }

        public IReadOnlyList<PlayerModel> RetrievePlayers()
        {
            var myDelegate = new RetrievePlayersDataDelegate();
            return executor.ExecuteReader(myDelegate);
        }

        public PlayerModel EditPlayer(string name, string age, string position, int height, int weight)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            if (age == null)
                throw new ArgumentException("The parameter cannot be null", nameof(age));

            if (string.IsNullOrWhiteSpace(position))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(position));
            if (height < 100)
                throw new ArgumentException("Input is too small", nameof(height));
            if (height > 250)
                throw new ArgumentException("Input is too large", nameof(height));
            if (weight < 55)
                throw new ArgumentException("Input is too small", nameof(height));
            if (weight > 100)
                throw new ArgumentException("Input is too large", nameof(height));

            var myDelegate = new CreatePlayerDataDelegate(name, age, position, height, weight);
            return executor.ExecuteNonQuery(myDelegate);
        }

        public IReadOnlyList<PlayerModel> GetPlayerByName(string name)
        {
            var myDelegate = new GetPlayerByNameDataDelegate(name);
            return executor.ExecuteReader(myDelegate);
        }

    }
}
