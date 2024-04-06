using System.Drawing;

namespace _2DEngine.Objects
{
    public class GraphicalObject
    {
        private int x, y;
        private Color color;
        public GraphicalObject(int x, int y, Color c)
        {
            this.x = x;
            this.y = y;
            color = c;
        }
        public Color getColor()
        {
            return color;
        }
        
    }
}
