using System;
using VideoGameManager.Models;

namespace VideoGameManager.View
{
    public class VideoGameView
    {
        public EntryValidation valid = new EntryValidation();

        public int GetMenuChoice()
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("\n1. Add Video Game");
            Console.WriteLine("2. Show All Video Games");
            Console.WriteLine("3. Look Up Video Game");
            Console.WriteLine("4. Update Video Game");
            Console.WriteLine("5. Delete Video Game");
            Console.WriteLine("6. Exit Program");
            Console.WriteLine();

            int selection = valid.ValidInt("Enter a selection: ", 1, 6);

            return selection;
        }

        public VideoGame GetNewVideoGameInfo()
        {
            VideoGame videoGame = new VideoGame();

            /* A video game couldn't be published beyond the current year. Since that fluxtuates, I created a variable for the max range.
               As for the min range, it is hard set to 1958, which is when the first video game was believed to be created.*/
            int currentYear = 2021;

            videoGame.Title = valid.ValidString("Enter the title of the video game: ");
            videoGame.ReleaseYear = valid.ValidInt("Enter the release year of the video game: ", 1958, currentYear);
            videoGame.Developer = valid.ValidString("Enter the name of the video game's Developer: ");
            videoGame.Genre = valid.ValidString("Enter the genre of the video game: ");
            videoGame.Rating = valid.ValidInt("Enter the video game's rating on a scale of 1 to 10: ", 1, 10);

            return videoGame;
        }

        public void DisplayVideoGame(VideoGame videoGame)
        {
            Console.WriteLine("\nVideo Game ID: {0}", videoGame.Id);
            Console.WriteLine("Title: {0}", videoGame.Title);
            Console.WriteLine("Release Year: {0}", videoGame.ReleaseYear);
            Console.WriteLine("Developer: {0}", videoGame.Developer);
            Console.WriteLine("Genre: {0}", videoGame.Genre);
            Console.WriteLine("Rating: {0}", videoGame.Rating);
        }

        public void ActionSuccess(string action)
        {
            Console.WriteLine("\n{0} executed successfully!", action);
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public void ActionFailure(string action)
        {
            Console.WriteLine("\n{0} failed to execute!", action);
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
