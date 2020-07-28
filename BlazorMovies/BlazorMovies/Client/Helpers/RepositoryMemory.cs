using System;
using System.Collections.Generic;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Helpers
{
    public class RepositoryMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
            new Movie(){Title = "Spider-Man",ReleaseDate = new DateTime(2020, 7, 1)},
            new Movie(){Title = "Iron-Man",ReleaseDate = new DateTime(2020, 1, 1)},
            new Movie(){Title = "Super-Man",ReleaseDate = new DateTime(2020, 3, 1)},
            new Movie(){Title = "Joker",ReleaseDate = new DateTime(2020, 7, 1)},
            new Movie(){Title = "Gold",ReleaseDate = new DateTime(2020, 1, 1)},
            new Movie(){Title = "Fire",ReleaseDate = new DateTime(2020, 3, 1)}
            };
        }
    }
}