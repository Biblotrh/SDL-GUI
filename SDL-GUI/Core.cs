using System;

namespace SDLGUI
{
    class SDLGUI
    {
        public static void Init()
        {
            SDL2.SDL.SDL_Init(SDL2.SDL.SDL_INIT_EVERYTHING);
            SDL2.SDL_ttf.TTF_Init();
        }
    }
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
    class Text
    {
        public string text = "text";
        public Colour colour = Assets.BlackColour;
        public Font font = new Font(Assets.pathToFonts + "OpenSans-Regular.ttf");
        public bool blend = true;
        public bool autoSize = true;
        public int x = 0;
        public int y = 0;
        public int w = 0;
        public int h = 0;

        SDL2.SDL.SDL_Rect textbox = new SDL2.SDL.SDL_Rect();
        System.IntPtr texture = System.IntPtr.Zero;

        public Text(IntPtr renderer) { Update(renderer); }
        public void Update(IntPtr renderer) 
        {
            if(autoSize)
            {
                w = text.Length * font.size;
                h = font.size;
            }
            textbox.x = x;
            textbox.y = y;
            textbox.w = w;
            textbox.h = h;

            SDL2.SDL.SDL_Color sdl_colour = new SDL2.SDL.SDL_Color();
            sdl_colour.r = colour.r;
            sdl_colour.g = colour.g;
            sdl_colour.b = colour.b;
            sdl_colour.a = colour.a;

            if (!blend) texture = SDL2.SDL.SDL_CreateTextureFromSurface(renderer, SDL2.SDL_ttf.TTF_RenderText_Solid(font.font, text, sdl_colour));
            else texture = SDL2.SDL.SDL_CreateTextureFromSurface(renderer, SDL2.SDL_ttf.TTF_RenderText_Blended(font.font, text, sdl_colour));
        }
        public void Render(IntPtr renderer) { SDL2.SDL.SDL_RenderCopy(renderer, texture, System.IntPtr.Zero, ref textbox); }
        public void Destroy() { font.Destroy(); }
    }
}