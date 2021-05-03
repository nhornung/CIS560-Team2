using System;
using System.Collections.Generic;
using FifaDatabase.Models;

namespace FifaDatabase.SqlRepos
{
    public interface IPlayerRepository
    {
        /// <summary>
        /// Retrieves all persons in the database.
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{Person}"/> containing all persons.
        /// </returns>
        IReadOnlyList<PlayerModel> RetrievePlayers();

        /// <summary>
        /// Creates a new person in the repository.
        /// </summary>
        /// <param name="firstName">First name of the person to create.</param>
        /// <param name="lastName">Last name of the person to create.</param>
        /// <param name="email">Email of the person to create.</param>
        /// <returns>
        /// The resulting instance of <see cref="Person"/>.
        /// </returns>
        PlayerModel CreatePlayer(string name, string age, string position, int height, int weight);

        IReadOnlyList<PlayerModel> GetPlayerByName(string name);

        IReadOnlyList<PlayerModel> GetPlayerByEveryTrait(string name, string age, string position, int height, int weight);
    }
}

