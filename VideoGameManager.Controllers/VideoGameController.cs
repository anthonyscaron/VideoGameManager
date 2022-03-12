using System;
using VideoGameManager.Data;
using VideoGameManager.Models;
using VideoGameManager.View;

namespace VideoGameManager.Controllers
{
    public class VideoGameController
    {
        public VideoGameView manager = new VideoGameView();
        public VideoGameRepository repository = new VideoGameRepository();
        public EntryValidation valid = new EntryValidation();
        
        public void Run()
        {
            bool active = true;

            while (active)
            {
                int menuSelection = manager.GetMenuChoice();

                switch (menuSelection)
                {
                    case 1:
                        CreateVideoGame();
                        break;
                    case 2:
                        DisplayAllVideoGames();
                        break;
                    case 3:
                        DisplaySpecificVideoGame();
                        break;
                    case 4:
                        UpdateVideoGame();
                        break;
                    case 5:
                        DeleteVideoGame();
                        break;
                    case 6:
                        active = false;
                        break;
                }
            }
        }

        private void CreateVideoGame()
        {
            Console.Clear();
            VideoGame newVideoGame = manager.GetNewVideoGameInfo();
            VideoGame added = repository.Create(newVideoGame);

            if (added != null)
            {
                manager.DisplayVideoGame(added);
                manager.ActionSuccess("Add Video Game");
            }
            else
            {
                manager.ActionFailure("Add Video Game");
            }
        }

        private void DisplayAllVideoGames()
        {
            Console.Clear();
            VideoGame[] allVideoGames = new VideoGame[10];
                
            allVideoGames = repository.GetAll();

            if (allVideoGames != null)
            {
                for (int i = 0; i < allVideoGames.Length; i++)
                {
                    if (allVideoGames[i] != null)
                    {
                        manager.DisplayVideoGame(allVideoGames[i]);
                    }
                }
                manager.ActionSuccess("Show All Video Games");
            }
            else
            {
                manager.ActionFailure("Show All Video Games");
            }
        }

        private void DisplaySpecificVideoGame()
        {
            Console.Clear();
            int id = valid.ValidInt("Enter a Video Game ID: ", 0, 10);

            VideoGame searched = repository.GetById(id);

            if (searched != null)
            {
                manager.DisplayVideoGame(searched);
                manager.ActionSuccess("Look Up Video Game");
            }
            else
            {
                manager.ActionFailure("Look up Video Game");
            }
        }

        private void UpdateVideoGame()
        {
            Console.Clear();
            int id = valid.ValidInt("Enter a Video Game ID: ", 0, 10);

            VideoGame searched = repository.GetById(id);

            if (searched != null)
            {
                manager.DisplayVideoGame(searched);
                Console.WriteLine();

                repository.Delete(id);

                searched = manager.GetNewVideoGameInfo();

                VideoGame updated = repository.Create(searched);

                if (updated != null)
                {
                    manager.DisplayVideoGame(updated);
                    manager.ActionSuccess("Update Video Game");
                }
                else
                {
                    manager.ActionFailure("Update Video Game");
                }
            }
            else
            {
                manager.ActionFailure("Look up Video Game");
            }
        }

        private void DeleteVideoGame()
        {
            Console.Clear();
            int id = valid.ValidInt("Enter a Video Game ID: ", 0, 10);

            repository.Delete(id);

            if (repository.GetById(id) == null)
            {
                manager.ActionSuccess("Delete Video Game");
            }
            else
            {
                manager.ActionFailure("Delete Video Game");
            }
        }
    }
}
