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

        public Window(string title, int width, int height, SDL.SDL_WindowFlags flags)
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
    }
}