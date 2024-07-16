namespace SDLGUI
{
    public class Colour
    {
        public byte r = 255, g = 255, b = 255, a = 255;

        public Colour(byte r, byte g, byte b, byte a = 255)
        { this.r = r; this.g = g; this.b = b; this.a = a; }
        public Colour(string hexText = "000000", byte a = 255) 
        {
            try
            {
                r = System.Convert.ToByte(hexText.Substring(0, 2), 16);
                g = System.Convert.ToByte(hexText.Substring(2, 2), 16);
                b = System.Convert.ToByte(hexText.Substring(4, 2), 16);
            }
            catch 
            { 
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine("Error: Colour hex value ("+hexText+") is invalid");
                System.Console.ForegroundColor = System.ConsoleColor.White;
            }
            this.a = a;
        }
    }
    public class Font
    {
        public System.IntPtr font = System.IntPtr.Zero;
        public int fontSize = 0;
        public Font(string pathToFont, int fontSize)
        {
            SDL2.SDL_ttf.TTF_Init();
            font = SDL2.SDL_ttf.TTF_OpenFont(pathToFont, fontSize);
            this.fontSize = fontSize;
        }
        public void Destroy() 
        { SDL2.SDL_ttf.TTF_CloseFont(font); font = System.IntPtr.Zero; }
    }
}
