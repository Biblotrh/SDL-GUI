using SDLGUI;
#if DEBUG
using SDLGUIUNITTEST;
#endif
using System;

namespace SDL_GUI
{
    static class MainClass
    {
        static void Main()
        {
            #if DEBUG
                SDLGUITEST test = new SDLGUITEST();
            #endif

            Window window = new Window("Test", 800, 600);

            Colour backgroundColour = new Colour(255, 255, 0, 255);

            // Check FPS
            DateTime lastTime = DateTime.Now;
            window.SyncingClock = true;
            window.fps = 200;

            while (window.running)
            {
                window.ClearColourWindow(backgroundColour);


                // Events
                window.EventLoop((e) =>
                {
                    if (e.type == SDL2.SDL.SDL_EventType.SDL_QUIT) window.running = false;
                });

                // Write FPS
                DateTime currentTime = DateTime.Now;
                TimeSpan timeDiff = currentTime - lastTime;
                Console.WriteLine(1/timeDiff.TotalSeconds);
                lastTime = currentTime;

                window.PresentWindow();
            }

            window.DestroyWindow();
        }
    }
}
