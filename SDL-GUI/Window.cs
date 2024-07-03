using SDL_GUI;
using SDL2;
using System;

namespace SDLGUI
{
    class Window
    {
        public string title = "Window";
        public int width = 800;
        public int height = 600;
        public SDL.SDL_WindowFlags flags = SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN;
        public IntPtr window = IntPtr.Zero;
        public IntPtr renderer = IntPtr.Zero;
        public bool running = true;

        public Window(string title = "Window", int width = 800, int height = 600, 
            SDL.SDL_WindowFlags flags = SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN)
        {
            this.title = title;
            this.width = width;
            this.height = height;
            this.flags = flags;
        }
        public void CreateWindow()
        {
            SDL.SDL_Init(SDL.SDL_INIT_VIDEO);
            window = SDL.SDL_CreateWindow(title, SDL.SDL_WINDOWPOS_CENTERED, SDL.SDL_WINDOWPOS_CENTERED, width, height, flags);
            renderer = SDL.SDL_CreateRenderer(window, -1, SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED);
        }
        public void DestroyWindow()
        {
            SDL.SDL_DestroyRenderer(renderer);
            SDL.SDL_DestroyWindow(window);
            SDL.SDL_Quit();
        }
        public void ClearWindow(Colour colour = null)
        {
            if (colour == null) colour = new Colour();
            
            SDL.SDL_SetRenderDrawColor(renderer, colour.r, colour.g, colour.b, colour.a);
            SDL.SDL_RenderClear(renderer);
        }
        public void PresentWindow()
        {
            SDL.SDL_RenderPresent(renderer);
        }
        public void EventLoop()
        {
            SDL.SDL_Event events;
            while (SDL.SDL_PollEvent(out events) != 0)
            {
                if (events.type == SDL.SDL_EventType.SDL_QUIT)
                {
                    running = false;
                    break;
                }
            }
        }
    }
}