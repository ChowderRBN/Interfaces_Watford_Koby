using System;                           // Required for Console and other base features

namespace Interfaces_Watford_Koby       // Your program's namespace
{
    internal class Program              // Main class where execution starts
    {
        static void Main(string[] args)     // Entry point of the program
        {
            // Create a Game object with specific ESRB, genre, and title
            Game myGame = new Game("M", "episodic adventure", "Life is Strange 2");
            Console.WriteLine(myGame.Describe());   // Output the game description
            myGame.PlayGame();                      // Simulate playing the game

            // Create a Movie object with specific ESRB, genre, and title
            Movie myMovie = new Movie("PG-13", "Sci-fi/Adventure", "Interstellar");
            Console.WriteLine(myMovie.Describe());  // Output the movie description
            myMovie.PlayMovie();                    // Simulate playing the movie
        }
    }
}
