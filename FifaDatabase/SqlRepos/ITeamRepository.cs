using System;
using System.Collections.Generic;
using FifaDatabase.Models;

namespace FifaDatabase.SqlRepos
{
    public interface ITeamRepository
    {
        /// <summary>
        /// Retrieves all persons in the database.
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{Person}"/> containing all persons.
        /// </returns>
        IReadOnlyList<TeamModel> RetrieveTeams();
    }
}