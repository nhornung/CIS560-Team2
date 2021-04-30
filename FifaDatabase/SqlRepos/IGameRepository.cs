using System;
using System.Collections.Generic;
using FifaDatabase.Models;

namespace FifaDatabase.SqlRepos
{
    public interface IGameRepository
    {
        /// <summary>
        /// Retrieves all persons in the database.
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{Person}"/> containing all persons.
        /// </returns>
        IReadOnlyList<GameSearchModel> RetrieveGames();
    }
}