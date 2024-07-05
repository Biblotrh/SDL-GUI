using SDLGUI;

namespace SDL_GUI
{
    static class Test
    {
        static void Main()
        {
            Window window = new Window("Test", 800, 600);
            window.CreateWindow();

            Colour backgroundColour = new Colour(255, 255, 0, 255);

            while (window.running)
            {
                window.ClearWindow(backgroundColour);


                window.PresentWindow();
                window.EventLoop();
                window.SyncClock();
            }

            window.DestroyWindow();
        }
    }
}
