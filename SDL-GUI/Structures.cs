namespace SDLGUI
{
    public class Colour
    {
        public byte r = 255;
        public byte g = 255;
        public byte b = 255;
        public byte a = 255;
        public Colour(byte? r = null, byte? g = null, byte? b = null, byte? a = null)
        {
            if (r == null) r = 0;
            if (g == null) g = 0;
            if (b == null) b = 0;
            if (a == null) a = 255;

            this.r = (byte)r;
            this.g = (byte)g;
            this.b = (byte)b;
            this.a = (byte)a;
        }
    }
    public class Font
    {
        public System.IntPtr font = System.IntPtr.Zero;
        public string path = Assets.pathToFonts + "OpenSans-Regular.ttf";
        public int size = 24;
        
        public Font(string path, int size = 24) {
            this.size = size;
            this.path = path;
            Update();
        }
        public Font() { Update(); }
        public void Update() { font = SDL2.SDL_ttf.TTF_OpenFont(path, size); }
        public void Destroy() { SDL2.SDL_ttf.TTF_CloseFont(font); font = System.IntPtr.Zero; }
    }
}
