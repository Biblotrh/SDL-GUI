namespace SDLGUI
{
    class Assets
    {
        public static string pathToFonts = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\assets\\fonts\\";

        public static Colour BlackColour = new Colour(0, 0, 0);
        public static Colour WhiteColour = new Colour(255, 255, 255);
        public static Colour RedColour = new Colour(255, 0, 0);
        public static Colour GreenColour = new Colour(0, 255, 0);
        public static Colour BlueColour = new Colour(0, 0, 255);
        public static Colour GoldColour = new Colour(255, 215, 0);
        public static Colour YellowColour = new Colour(255, 255, 0);

        public static Font DefaultFont24 = new Font(pathToFonts + "OpenSans-Regular.ttf", 24);
        public static Font SplineSansMono24 = new Font(pathToFonts + "SplineSansMono.ttf", 24);
    }
}
