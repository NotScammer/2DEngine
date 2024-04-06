using _2DEngine;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Game starting");
        Game.isRunning = true;
        Game.Init();

        //Start the game clock
        Thread gameClock = new Thread(clock);
        gameClock.Start();
    }
    static void clock()
    {
        Thread.Sleep(1000);
        /*while (Game.isRunning)
        {
            //do things
            Thread.Sleep(250); //1000ms/250ms = 4fps
        }*/
        Game.tick(); //once
    }
}