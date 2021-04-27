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

        ///// <summary>
        ///// Fetches the person with the given <paramref name="personId"/> if it exists.
        ///// </summary>
        ///// <param name="personId">Identifier of the person to fetch.</param>
        ///// <returns>
        ///// An instance of <see cref="Person"/> containing the information of the requested person.
        ///// </returns>
        ///// <exception cref="DataAccess.RecordNotFoundException">
        ///// Thrown if <paramref name="personId"/> does not exist.
        ///// </exception>
        //PlayerModel FetchPerson(int playerID);

        ///// <summary>
        ///// Gets the person with the given <paramref name="personId"/> if it exists.
        ///// </summary>
        ///// <param name="email">Email of the person to get.</param>
        ///// <returns>
        ///// An instance of <see cref="Person"/> containing the information of the requested person
        ///// if one exists with with the provided <paramref name="email"/>.
        ///// If one is not found, <c>null</c> is returned.
        ///// </returns>
        //PlayerModel GetPerson(string email);

        /// <summary>
        /// Creates a new person in the repository.
        /// </summary>
        /// <param name="firstName">First name of the person to create.</param>
        /// <param name="lastName">Last name of the person to create.</param>
        /// <param name="email">Email of the person to create.</param>
        /// <returns>
        /// The resulting instance of <see cref="Person"/>.
        /// </returns>
        PlayerModel CreatePlayer(string name, DateTime age, string position, int height, int weight);
    }
}

