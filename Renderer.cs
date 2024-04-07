using _2DEngine.Objects;
using System.Drawing;
namespace _2DEngine
{
    public static class Renderer
    {
        public static void Render()
        {
            //RENDERS THE SCENE

#pragma warning disable CA1416 // Validate platform compatibility
            Bitmap scene = new(65, 65);
            for (int i = 0 ; i < 65; i++)
            {
                for(int j = 0 ; j < 65; j++)
                {
                    scene.SetPixel(i, j, Color.White);
                }
            }
            if (Game.objects is not null && Game.objects.Count > 0)
            {
                foreach (PhysicalObject obj in Game.objects)
                {
                    if (Camera.isInTheScene(obj))
                    {
                        scene.SetPixel(Camera.renderDistance + obj.getX(), 65 - (obj.getY() + Camera.renderDistance), obj.getColor());
                    }
                }
            }
            scene.Save("render.jpeg");
#pragma warning restore CA1416 // Validate platform compatibility

        }
    }
}
