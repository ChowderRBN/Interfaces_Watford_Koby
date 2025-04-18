using System;                           // Gives access to Console and other core functions
using System.Collections.Generic;       // Included for completeness; not used directly
using System.Text;                      // Included but not needed for this example

namespace Interfaces_Watford_Koby       // Project namespace
{
    internal class Game : IGenre        // Defines Game class implementing IGenre
    {
        // Interface properties
        public string Esrb { get; set; }     // ESRB rating (e.g., E, T, M)
        public string Genre { get; set; }    // Genre of the game
        public string Title { get; set; }   // Title of the game

        // Constructor to set all the properties
        public Game(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        // Unique method to start the game (not part of interface)
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting! Game ON!");  // Simulates gameplay start
        }

        // Interface method to describe the game
        public string Describe()
        {
            return $"{Title} is a {Genre} game, rated {Esrb}!";
        }
    }
}
