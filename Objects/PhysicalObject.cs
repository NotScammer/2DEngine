using System.Drawing;

namespace _2DEngine.Objects
{
    internal class PhysicalObject
    {
        private int x, y;
        GraphicalObject obj;
        public PhysicalObject(int x, int y,Color c)
        {
            this.x = x;
            this.y = y;
            obj = new GraphicalObject(x, y, c);
            Game.objects.Add(this);
        }
        public int getX() { return x; }
        public int getY() { return y; }

        public void setX( int x) { this.x = x;}
        public void setY( int y) { this.y = y;}
        public Color getColor()
        {
            return obj.getColor();
        }
    }
}
