namespace SDLGUI
{
    class Window
    {
        public System.IntPtr window = System.IntPtr.Zero;
        public System.IntPtr renderer = System.IntPtr.Zero;
        public bool running = true;
        public uint fps = 0;
        public double fpsData = 0;
        System.DateTime lastTime = System.DateTime.Now;
        System.DateTime currentTime = System.DateTime.Now;

        public Window(string title = "Window", int? _width = null, int? _height = null, SDL2.SDL.SDL_WindowFlags? _flags = null)
        {
            int width = 800;
            int height = 800;
            SDL2.SDL.SDL_WindowFlags flags = SDL2.SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN;

            if (_width != null) width = (int)_width;
            if (_height != null) height = (int)_height;
            if (_flags != null) flags = (SDL2.SDL.SDL_WindowFlags)_flags;

            window = SDL2.SDL.SDL_CreateWindow(title, SDL2.SDL.SDL_WINDOWPOS_CENTERED, SDL2.SDL.SDL_WINDOWPOS_CENTERED, width, height, flags);
            renderer = SDL2.SDL.SDL_CreateRenderer(window, -1, SDL2.SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED);
        }
        public void DestroyWindow()
        {
            SDL2.SDL.SDL_DestroyRenderer(renderer);
            SDL2.SDL.SDL_DestroyWindow(window);
            window = System.IntPtr.Zero;
            renderer = System.IntPtr.Zero;
        }
        public void ClearColourWindow(Colour colour = null)
        {
            if (colour == null) colour = new Colour();
            SDL2.SDL.SDL_SetRenderDrawColor(renderer, colour.r, colour.g, colour.b, colour.a);
            SDL2.SDL.SDL_RenderClear(renderer);
        }
        private void SyncClock()
        {
            System.TimeSpan timeDiff = currentTime - lastTime;
            while(System.Convert.ToUInt32(timeDiff.Milliseconds) < 1000 / fps)
            {
                currentTime = System.DateTime.Now;
                timeDiff = currentTime - lastTime;
            } 
        }
        public void PresentWindow()
        {
            currentTime = System.DateTime.Now;

            SDL2.SDL.SDL_RenderPresent(renderer);
            if (fps != 0) SyncClock();

            // FPS Data
            System.TimeSpan timeDiff = currentTime - lastTime;
            fpsData = 1 / timeDiff.TotalSeconds;
            lastTime = currentTime;
        }
        public void EventLoop(System.Action<SDL2.SDL.SDL_Event> eventFunction = null)
        {
            SDL2.SDL.SDL_Event events;
            while (SDL2.SDL.SDL_PollEvent(out events) != 0)
            {
                if (eventFunction != null) eventFunction(events);
                else DefaultEventHandler(events);
            }
        }
        private void DefaultEventHandler(SDL2.SDL.SDL_Event events)
        {
            if (events.type == SDL2.SDL.SDL_EventType.SDL_QUIT) running = false;
        }
    }
}