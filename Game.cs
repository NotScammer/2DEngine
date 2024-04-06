using _2DEngine.Objects;
using System.Drawing;

namespace _2DEngine
{
    static class Game
    {
        public static List<PhysicalObject> objects;

        public static bool isRunning;

        public static void Init()
        {
            Camera.x = 0; Camera.y = 0;
            objects = new List<PhysicalObject>();
            PhysicalObject ob = new PhysicalObject(5, 3, Color.Red); //for debug purposes
            PhysicalObject ob2 = new PhysicalObject(0,0,Color.Black);
        }
        public static void tick()
        {
            Renderer.Render();
        }
    }
}
