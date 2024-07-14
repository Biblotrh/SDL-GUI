namespace SDL_GUI
{
    static class MainClass
    {
        static void Main()
        {
#if DEBUG
            SDLGUIUNITTEST.SDLGUITEST test = new SDLGUIUNITTEST.SDLGUITEST();
#endif

            SDLGUI.Window window = new SDLGUI.Window("Test");

            // [Note] Thread Load And Create Assets witch background loading screen

            // Set FPS
            window.fps = 60;
            // Add text
            SDLGUI.Text text = new SDLGUI.Text(window.renderer);

            while (window.running)
            {
                // SetBackgroundColour
                window.ClearColourWindow(SDLGUI.Assets.YellowColour);

                // render text
                text.render(window.renderer);

                // Write FPS
                System.Console.WriteLine("FPS: " + window.fpsData);

                // Events
                window.EventLoop((e) =>
                {
                    if (e.type == SDL2.SDL.SDL_EventType.SDL_QUIT) window.running = false;
                });

                // Update Window
                window.PresentWindow();
            }

            window.DestroyWindow();
        }
    }
}
