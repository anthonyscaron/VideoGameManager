using VideoGameManager.Controllers;

namespace VideoGameManager
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoGameController controller = new VideoGameController();
            controller.Run();
        }
    }
}
