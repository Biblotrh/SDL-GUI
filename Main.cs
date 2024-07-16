using SDL2;
using SDLGUI;

namespace SDL_GUI
{
    static class MainClass
    {
        static void Main()
        {
            // Init
            SDLGUI.SDLGUI.Init();

#if DEBUG
            SDLGUIUNITTEST.SDLGUITEST test = new SDLGUIUNITTEST.SDLGUITEST();
#endif

            SDLGUI.Window window = new SDLGUI.Window("Test");

            // [Note] Thread Load And Create Assets witch background loading screen

            // Set FPS
            window.fps = 60;

            // Add text
            SDLGUI.Text text = new SDLGUI.Text(window.renderer);
            SDLGUI.Font font = new SDLGUI.Font(SDLGUI.Assets.pathToFonts + "OpenSans-Regular.ttf", 24);
            SDL2.SDL_ttf.TTF_SetFontStyle(font.font, SDL2.SDL_ttf.TTF_STYLE_BOLD);
            text.font = font;
            text.Update(window.renderer);

            while (window.running)
            {
                // SetBackgroundColour
                window.ClearColourWindow(SDLGUI.Assets.YellowColour);

                // render text
                text.Render(window.renderer);

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

            text.Destroy();
            font.Destroy();
            window.DestroyWindow();
        }
    }
}
