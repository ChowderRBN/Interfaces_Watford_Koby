using System;                           // Brings in basic system functions (like Console)
using System.Collections.Generic;       // Not used here, but generally for lists, dictionaries, etc.
using System.Text;                      // Useful for string manipulation (not used here)

namespace Interfaces_Watford_Koby       // The namespace groups related classes under one name
{
    class Movie : IGenre                // Defines a Movie class that implements the IGenre interface
    {
        // Properties required by IGenre
        public string Esrb { get; set; }     // ESRB rating (e.g., PG-13, R)
        public string Genre { get; set; }    // Genre of the movie (e.g., action, drama)
        public string Title { get; set; }    // Title of the movie

        // Constructor to initialize a Movie object with given values
        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;                // Assign parameter to property
            Genre = genreParam;
            Title = titleParam;
        }

        // Method unique to the Movie class (not part of IGenre)
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, SSsssshhhhh!");  // Simulates playing the movie
        }

        // Method from IGenre interface — gives a summary of the movie
        public string Describe()
        {
            return $"{Title} is a {Genre} movie, rated {Esrb}!";
        }
    }
}
