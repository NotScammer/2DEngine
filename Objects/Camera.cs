namespace _2DEngine.Objects
{
    static class Camera
    {
        public static int x, y;
        public static readonly int renderDistance = 32;
        public static bool isInTheScene(PhysicalObject obj)
        {
            if (Math.Abs(obj.getX() - x) <= renderDistance && Math.Abs(obj.getY() - x) <= renderDistance)
            {
                return true;
            }
            return false;
        }
    }
}
