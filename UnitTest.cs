using SDLGUI;
using System;

namespace SDLGUITEST
{
    class SDLGUITEST
    {
        public int passed = 0;
        public int runned = 0;

        public SDLGUITEST()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("SDL GUI TEST");
            Console.ForegroundColor = ConsoleColor.White;

            CORETESTS();
        }

        public void CORETESTS()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CORE TESTS");
            Console.ForegroundColor = ConsoleColor.White;

            COLOUR_CREATECOLOUR_COLOURCREATED(0, 0, 0, 0);
            COLOUR_CREATECOLOUR_COLOURCREATED(255, 255, 255, 255);
            COLOUR_CREATECOLOUR_COLOURCREATED(255, 0, 0, 255);
            COLOUR_CREATECOLOUR_COLOURCREATED(0, 255, 0, 255);
            COLOUR_CREATECOLOUR_COLOURCREATED(0, 0, 255, 255);
            COLOUR_CREATECOLOUR_COLOURCREATED(255, 255, 0, 255);
            COLOUR_CREATECOLOUR_COLOURCREATED(255, 0, 255, 255);
            COLOUR_CREATECOLOUR_COLOURCREATED(0, 255, 255, 255);
            COLOUR_CREATECOLOUR_COLOURCREATED(255, 255, 255, 0);
            COLOUR_CREATECOLOUR_COLOURCREATED(255, 0, 0, 0);
            COLOUR_CREATECOLOUR_COLOURCREATED(0, 255, 0, 0);
            COLOUR_CREATECOLOUR_COLOURCREATED(0, 0, 255, 0);
            COLOUR_CREATECOLOUR_COLOURCREATED(255, 255, 0, 0);
            COLOUR_CREATECOLOUR_COLOURCREATED(255, 0, 255, 0);
            COLOUR_CREATECOLOUR_COLOURCREATED(0, 255, 255, 0);
            COLOUR_CREATECOLOUR_COLOURCREATED(255, 255, 255, 255);

        }

        public void COLOUR_CREATECOLOUR_COLOURCREATED(byte r, byte g, byte b, byte a)
        {
            runned++;
            // Arrange
            Colour colour = new Colour(r, g, b, a);
            // Assert
            if (colour.r == r && colour.g == g && colour.b == b && colour.a == a)
            {
                passed++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("COLOUR_CREATECOLOUR_COLOURCREATED PASSED");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("COLOUR_CREATECOLOUR_COLOURCREATED FAILED");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}