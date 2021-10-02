using System;
using PraticaSemanaIV.Shared.Entity;
using System.Collections.Generic;


namespace PraticaSemanaIV.Client.Services
{
    public class ServiceMovie : IServiceMovie
    {
        public List<Movie>GetMovies(){
            return new List<Movie>(){
                new Movie(){Id =1,Name="Movie 1", Sinopsis="Trama de la movie...", Poster="/Images/Movies/Movie1.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =2,Name="Movie 2", Sinopsis="Trama de la movie...", Poster="/Images/Movies/Movie2.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =3,Name="Movie 3", Sinopsis="Trama de la movie...", Poster="/Images/Movies/Movie3.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =4,Name="Movie 4", Sinopsis="Trama de la movie...", Poster="/Images/Movies/Movie4.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =5,Name="Movie 5", Sinopsis="Trama de la movie...", Poster="/Images/Movies/Movie5.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =6,Name="Movie 6", Sinopsis="Trama de la movie...", Poster="/Images/Movies/Movie6.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =7,Name="Movie 7", Sinopsis="Trama de la movie...", Poster="/Images/Movies/Movie7.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =8,Name="Movie 8", Sinopsis="Trama de la movie...", Poster="/Images/Movies/Movie8.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =9,Name="Movie 9", Sinopsis="Trama de la movie...", Poster="/Images/Movies/Movie9.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =10,Name="Movie 10", Sinopsis="Trama de la movie...",Poster="/Images/Movies/Movie10.jpg", Premier= new DateTime(2021,10,10)}
            };
        }  
    }
}