using System.Security.AccessControl;
using PraticaSemanaIV.Shared.Entity;
using System.Collections.Generic;

namespace PraticaSemanaIV.Client.Services
{
    public interface IServiceMovie
    {
        List<Movie> GetMovies();
    }
}