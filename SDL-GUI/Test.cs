using SDLGUI;
using SDL2;

namespace SDL_GUI
{
    static class Test
    {
        static void Main()
        {
            SDL2.SDL.SDL_Init(SDL2.SDL.SDL_INIT_VIDEO);
            SDL2.SDL.SDL_Window window = SDL2.SDL.SDL_CreateWindow("SDL2-CS GUI", 100, 100, 640, 480, SDL2.SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);
            SDL2.SDL.SDL_Renderer renderer = SDL2.SDL.SDL_CreateRenderer(window, -1, SDL2.SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED);
            SDL2.SDL.SDL_Event e;
            bool quit = false;
            SDL2.SDL.SDL_Rect rect = new SDL2.SDL.SDL_Rect();
            rect.x = 10;
            rect.y = 10;
            rect.w = 100;
            rect.h = 100;
            SDL2.SDL.SDL_SetRenderDrawColor(renderer, 255, 0, 0, 255);
            SDL2.SDL.SDL_RenderFillRect(renderer, ref rect);
            SDL2.SDL.SDL_RenderPresent(renderer);
            while (!quit)
            {
                while (SDL2.SDL.SDL_PollEvent(out e) != 0)
                {
                    if (e.type == SDL2.SDL.SDL_EventType.SDL_QUIT)
                    {
                        quit = true;
                    }
                }
            }
            SDL2.SDL.SDL_DestroyRenderer(renderer);
            SDL2.SDL.SDL_DestroyWindow(window);
            SDL2.SDL.SDL_Quit();
        }
    }
}
