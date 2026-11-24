using Heirloom;
using Heirloom.Desktop;

namespace heirloom;

class Program
{
    static Image imatge;
    static Vector posicio;
    static void Main(string[] args)
    {
        Application.Run(() =>
        {
            // crear finestra
            var window = new Window("imatge", (800,600));
            imatge = new Image("imatge.png");
            posicio = new Vector(0,0);
            
            var loop = GameLoop.Create(window.Graphics, OnUpdate, 60);
            loop.Start();
        });
    }

  private static void OnUpdate(GraphicsContext gfx, float dt)
  {
    gfx.Clear(Color.DarkGray);
    gfx.DrawImage(imatge, posicio);
    if(Input.CheckKey(Key.Left, ButtonState.Pressed))
        {
            posicio.X -= 10;
        }
  }
}
