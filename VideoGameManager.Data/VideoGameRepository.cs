using VideoGameManager.Models;

namespace VideoGameManager.Data
{
    public class VideoGameRepository
    {
        public VideoGame[] videoGames = new VideoGame[10];
        
        public VideoGameRepository()
        {
            VideoGame videoGame1 = new VideoGame();
            videoGame1.Id = 0;
            videoGame1.Title = "Teamfight Tactics";
            videoGame1.ReleaseYear = 2019;
            videoGame1.Developer = "Riot Games";
            videoGame1.Genre = "Auto Battler";
            videoGame1.Rating = 8;

            videoGames[0] = videoGame1;

            VideoGame videoGame2 = new VideoGame();
            videoGame2.Id = 1;
            videoGame2.Title = "New World";
            videoGame2.ReleaseYear = 2021;
            videoGame2.Developer = "Amazon Game Studios";
            videoGame2.Genre = "MMORPG";
            videoGame2.Rating = 7;

            videoGames[1] = videoGame2;

            VideoGame videoGame3 = new VideoGame();
            videoGame3.Id = 2;
            videoGame3.Title = "The Legend of Zelda: Breath of the Wild";
            videoGame3.ReleaseYear = 2017;
            videoGame3.Developer = "Nintendo Entertainment";
            videoGame3.Genre = "Action-Adventure";
            videoGame3.Rating = 10;

            videoGames[2] = videoGame3;
        }
        
        public VideoGame Create(VideoGame videoGame)
        {
            for (int i = 0; i < videoGames.Length; i++)
            {
                if (videoGames[i] == null)
                {
                    videoGame.Id = i;
                    videoGames[i] = videoGame;
                    return videoGame;
                }
            }

            return null;
        }

        public VideoGame[] GetAll()
        {
            return videoGames;
        }

        public VideoGame GetById(int id)
        {
            return videoGames[id];
        }

        public void Delete(int id)
        {
            videoGames[id] = null;
        }
    }
}
