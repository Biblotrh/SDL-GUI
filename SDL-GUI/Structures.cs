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
            if (a == null) a = 0;

            this.r = (byte)r;
            this.g = (byte)g;
            this.b = (byte)b;
            this.a = (byte)a;
        }
    }
}
