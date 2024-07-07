using SDL2;
using System;

namespace SDLGUI
{
    class Window
    {
        public IntPtr window = IntPtr.Zero;
        public IntPtr renderer = IntPtr.Zero;
        public bool running = true;
        public bool SyncingClock = false;
        public uint fps = 60;
        DateTime lastTime = DateTime.Now;

        public Window(string title = "Window", int width = 800, int height = 600, 
            SDL.SDL_WindowFlags flags = SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN)
        {
            window = SDL.SDL_CreateWindow(title, SDL.SDL_WINDOWPOS_CENTERED, SDL.SDL_WINDOWPOS_CENTERED, width, height, flags);
            renderer = SDL.SDL_CreateRenderer(window, -1, SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED);
        }
        public void DestroyWindow()
        {
            SDL.SDL_DestroyRenderer(renderer);
            SDL.SDL_DestroyWindow(window);
        }
        public void ClearColorWindow(Colour colour = null)
        {
            if (colour == null) colour = new Colour();
            SDL.SDL_SetRenderDrawColor(renderer, colour.r, colour.g, colour.b, colour.a);
            SDL.SDL_RenderClear(renderer);
        }
        private void SyncClock()
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan timeDiff = currentTime - lastTime;
            while(Convert.ToUInt32(timeDiff.Milliseconds) < 1000 / fps)
            {
                currentTime = DateTime.Now;
                timeDiff = currentTime - lastTime;
            }
            lastTime = currentTime;
        }
        public void PresentWindow()
        {
            SDL.SDL_RenderPresent(renderer);
            if (SyncingClock) SyncClock();
        }
        public void EventLoop(Action<SDL.SDL_Event> eventFunction = null)
        {
            SDL.SDL_Event events;
            while (SDL.SDL_PollEvent(out events) != 0)
            {
                if (eventFunction != null) eventFunction(events);
                else DefaultEventHandler(events);
            }
        }
        private void DefaultEventHandler(SDL.SDL_Event events)
        {
            if (events.type == SDL.SDL_EventType.SDL_QUIT) running = false;
        }
    }
}