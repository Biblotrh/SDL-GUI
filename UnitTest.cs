using SDLGUI;
using System;

namespace SDLGUIUNITTEST
{
    class SDLGUITEST
    {
        public int passed = 0;
        public int runned = 0;

        public SDLGUITEST()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("SDL GUI UNIT TEST");
            Console.ForegroundColor = ConsoleColor.White;

            STRUCTURETESTS();
            TEXTTEST();
            WINDOWTEST();

            if (runned == passed)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ALL TESTS PASSED");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(passed + "/" + runned + " TESTS PASSED");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        void STRUCTURETESTS()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("STRUCTURE TESTS");
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
            COLOUR_CREATECOLOUR_COLOURCREATED(0);
            COLOUR_CREATECOLOUR_COLOURCREATED(255);
            COLOUR_CREATECOLOUR_COLOURCREATED(0, 0);
            COLOUR_CREATECOLOUR_COLOURCREATED(255, 255);
            COLOUR_CREATECOLOUR_COLOURCREATED(0, 0, 0);
            COLOUR_CREATECOLOUR_COLOURCREATED(255, 255, 255);
            COLOUR_CREATECOLOUR_COLOURCREATED(255, 0, 0);
            COLOUR_CREATECOLOUR_COLOURCREATED(0, 255, 0);
            COLOUR_CREATECOLOUR_COLOURCREATED(0, 0, 255);
            COLOURHEX_CREATECOLOUR_COLOURCREATED("000000");
            COLOURHEX_CREATECOLOUR_COLOURCREATED("FFFFFF");
            COLOURHEX_CREATECOLOUR_COLOURCREATED("FF0000");
            COLOURHEX_CREATECOLOUR_COLOURCREATED("00FF00");
            COLOURHEX_CREATECOLOUR_COLOURCREATED("0000FF");
            COLOURHEX_CREATECOLOUR_COLOURCREATED("FFFF00", 255);
            COLOURHEX_CREATECOLOUR_COLOURCREATED("FF00FF", 50);
            COLOURHEX_CREATECOLOUR_COLOURCREATED("00FFFF", 100);
            COLOURHEX_CREATECOLOUR_COLOURCREATED("FF0000", 0);
            
            FONT_CREATEFONT_FONTCREATED(Assets.pathToFonts + "OpenSans-Regular.ttf", 24);
            FONT_CREATEFONT_FONTCREATED(Assets.pathToFonts + "OpenSans-Regular.ttf", 12);
            FONT_CREATEFONT_FONTCREATED(Assets.pathToFonts + "OpenSans-Regular.ttf", 36);
            FONT_CREATEFONT_FONTCREATED(Assets.pathToFonts + "OpenSans-Regular.ttf", 48);
            FONT_CREATEFONT_FONTCREATED(Assets.pathToFonts + "OpenSans-Regular.ttf", 60);
            FONT_CREATEFONT_FONTCREATED(Assets.pathToFonts + "OpenSans-Regular.ttf", 72);
            FONT_CREATEFONT_FONTCREATED(Assets.pathToFonts + "OpenSans-Regular.ttf", 84);
            FONT_CREATEFONT_FONTCREATED(Assets.pathToFonts + "OpenSans-Regular.ttf", 96);
            FONT_CREATEFONT_FONTCREATED(Assets.pathToFonts + "OpenSans-Regular.ttf", 108);
            FONT_DESTROYFONT_FONTDESTROYED(Assets.pathToFonts + "OpenSans-Regular.ttf", 24);
            FONT_DESTROYFONT_FONTDESTROYED(Assets.pathToFonts + "OpenSans-Regular.ttf", 12);
            FONT_DESTROYFONT_FONTDESTROYED(Assets.pathToFonts + "OpenSans-Regular.ttf", 36);
            FONT_DESTROYFONT_FONTDESTROYED(Assets.pathToFonts + "OpenSans-Regular.ttf", 48);
            FONT_DESTROYFONT_FONTDESTROYED(Assets.pathToFonts + "OpenSans-Regular.ttf", 60);
            FONT_DESTROYFONT_FONTDESTROYED(Assets.pathToFonts + "OpenSans-Regular.ttf", 72);
            FONT_DESTROYFONT_FONTDESTROYED(Assets.pathToFonts + "OpenSans-Regular.ttf", 84);
            FONT_DESTROYFONT_FONTDESTROYED(Assets.pathToFonts + "OpenSans-Regular.ttf", 96);
            FONT_DESTROYFONT_FONTDESTROYED(Assets.pathToFonts + "OpenSans-Regular.ttf", 108);
        }
        void TEXTTEST()
        {
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("TEXT TESTS");
            System.Console.ForegroundColor = ConsoleColor.White;

            TEXT_CREATTEXT_TEXTCREATED("Hello");
            TEXT_CREATTEXT_TEXTCREATED("Hello World");
            TEXT_CREATTEXT_TEXTCREATED("Hello World!!!");
            TEXT_CREATTEXT_TEXTCREATED("Hello World!!!\nHello World!!!");
            TEXT_CREATTEXT_TEXTCREATED("Hello World!!!\nHello World!!!\nHello World!!!");
            TEXT_CREATTEXT_TEXTCREATED("Hello World!!!\nHello World!!!\nHello World!!!\nHello World!!!");
            TEXT_DESTROYTEXT_TEXTDESTROYED("Hello");
            TEXT_DESTROYTEXT_TEXTDESTROYED("Hello World");
            TEXT_DESTROYTEXT_TEXTDESTROYED("Hello World!!!");
            TEXT_DESTROYTEXT_TEXTDESTROYED("Hello World!!!\nHello World!!!");
            TEXT_DESTROYTEXT_TEXTDESTROYED("Hello World!!!\nHello World!!!\nHello World!!!");
            TEXT_DESTROYTEXT_TEXTDESTROYED("Hello World!!!\nHello World!!!\nHello World!!!\nHello World!!!");
            TEXT_SETPOSITIONANDSIZE_TEXTSET(0, 0, 0, 0);
            TEXT_SETPOSITIONANDSIZE_TEXTSET(100, 100, 100, 100);
            TEXT_SETPOSITIONANDSIZE_TEXTSET(200, 200, 200, 200);
            TEXT_SETPOSITIONANDSIZE_TEXTSET(3000, 3000, 3000, 3000);
            TEXT_SETPOSITIONANDSIZE_TEXTSET(4000, 4000, 4000, 4000);
            TEXT_UPDATECOLOUR_COLOURUPDATED("000000", 0);
            TEXT_UPDATECOLOUR_COLOURUPDATED("FFFFFF", 255);
            TEXT_UPDATECOLOUR_COLOURUPDATED("FF0000", 255);
            TEXT_UPDATECOLOUR_COLOURUPDATED("00FF00", 255);
            TEXT_UPDATECOLOUR_COLOURUPDATED("0000FF", 255);
            TEXT_UPDATECOLOUR_COLOURUPDATED("FFFF00", 255);
            TEXT_UPDATECOLOUR_COLOURUPDATED("FF00FF", 50);
            TEXT_UPDATECOLOUR_COLOURUPDATED("00FFFF", 100);
            TEXT_UPDATEFONT_FONTUPDATED(Assets.pathToFonts + "OpenSans-Regular.ttf", 24);
            TEXT_UPDATEFONT_FONTUPDATED(Assets.pathToFonts + "OpenSans-Regular.ttf", 12);
            TEXT_UPDATEFONT_FONTUPDATED(Assets.pathToFonts + "OpenSans-Regular.ttf", 36);
            TEXT_UPDATEFONT_FONTUPDATED(Assets.pathToFonts + "OpenSans-Regular.ttf", 48);
            TEXT_UPDATEFONT_FONTUPDATED(Assets.pathToFonts + "OpenSans-Regular.ttf", 60);
            TEXT_UPDATEFONT_FONTUPDATED(Assets.pathToFonts + "OpenSans-Regular.ttf", 72);
            TEXT_UPDATEFONT_FONTUPDATED(Assets.pathToFonts + "OpenSans-Regular.ttf", 84);
            TEXT_AUTOSIZE_AUTOSIZED("HELLO");
            TEXT_AUTOSIZE_AUTOSIZED("HELLO WORLD");
            TEXT_AUTOSIZE_AUTOSIZED("HELLO WORLD!!!");
            TEXT_AUTOSIZE_AUTOSIZED("HELLO WORLD!!!\nHELLO WORLD!!!");
            TEXT_AUTOSIZE_AUTOSIZED("HELLO WORLD!!!\nHELLO WORLD!!!\nHELLO WORLD!!!");
            TEXT_AUTOSIZE_AUTOSIZED("HELLO WORLD!!!\nHELLO WORLD!!!\nHELLO WORLD!!!\nHELLO WORLD!!!");
        }
        void WINDOWTEST()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WINDOW TESTS");
            Console.ForegroundColor = ConsoleColor.White;

            WINDOW_CREATEWINDOW_WINDOWCREATED("Test", 800, 600);
            WINDOW_CREATEWINDOW_WINDOWCREATED("Test", 1024, 768);
            WINDOW_CREATEWINDOW_WINDOWCREATED("Test", 1280, 720);
            WINDOW_CREATEWINDOW_WINDOWCREATED("Hello", 1920, 1080);
            WINDOW_CREATEWINDOW_WINDOWCREATED("Hello", 2560, 1440);
            WINDOW_CREATEWINDOW_WINDOWCREATED("World\nHello", 3840, 2160);
            WINDOW_CREATEWINDOW_WINDOWCREATED("Test");
            WINDOW_CREATEWINDOW_WINDOWCREATED("Test", 1024);
            
            WINDOW_DESTROYWINDOW_WINDOWDESTROYED("Test", 800, 600);
            WINDOW_DESTROYWINDOW_WINDOWDESTROYED("Test", 1024, 768);
            WINDOW_DESTROYWINDOW_WINDOWDESTROYED("Test", 1280, 720);
            WINDOW_DESTROYWINDOW_WINDOWDESTROYED("Hello", 1920, 1080);
            WINDOW_DESTROYWINDOW_WINDOWDESTROYED("Hello", 2560, 1440);
            WINDOW_DESTROYWINDOW_WINDOWDESTROYED("World\nHello", 3840, 2160);
            
            WINDOW_CLEARCOLOURRENDER_CLEARCOLOURRENDERED("Test", 800, 600, 255, 255, 255, 0);
            WINDOW_CLEARCOLOURRENDER_CLEARCOLOURRENDERED("Test", 1024, 768, 255, 255, 255, 0);
            WINDOW_CLEARCOLOURRENDER_CLEARCOLOURRENDERED("Test", 1280, 720, 255, 255, 0, 255);
            WINDOW_CLEARCOLOURRENDER_CLEARCOLOURRENDERED("Hello", 1920, 1080, 255, 0, 255, 255);
            WINDOW_CLEARCOLOURRENDER_CLEARCOLOURRENDERED("Hello", 2560, 1440, 0, 255, 255, 255);
            WINDOW_CLEARCOLOURRENDER_CLEARCOLOURRENDERED("World\nHello", 3840, 2160, 255, 0, 0, 255);
            
            WINDOW_SYNCCLOK_CLOCKSYNCED("Test", 800, 600, 60, 100, 5);
            WINDOW_SYNCCLOK_CLOCKSYNCED("Hello", 1024, 768, 60, 100, 5);
            WINDOW_SYNCCLOK_CLOCKSYNCED("Hello\nWorld", 1024, 768, 100, 100, 10);

        }

        void COLOUR_CREATECOLOUR_COLOURCREATED(byte r = 255, byte g = 255, byte b = 255, byte a = 255)
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
        void COLOURHEX_CREATECOLOUR_COLOURCREATED(string hexString = "000000", byte a = 255)
        {
            runned++;
            // Arrange
            Colour colour = new Colour(hexString, a);
            byte r = System.Convert.ToByte(hexString.Substring(0, 2), 16);
            byte g = System.Convert.ToByte(hexString.Substring(2, 2), 16);
            byte b = System.Convert.ToByte(hexString.Substring(4, 2), 16);

            // Assert
            if (colour.r == r && colour.g == g && colour.b == b && colour.a == a)
            {
                passed++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("COLOURHEX_CREATECOLOUR_COLOURCREATED PASSED");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("COLOURHEX_CREATECOLOUR_COLOURCREATED FAILED");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        void WINDOW_CREATEWINDOW_WINDOWCREATED(string title, int? width = null, int? height = null)
        {
            runned++;
            // Arrange
            Window window = new Window(title, width, height);
            if (width == null) width = 800;
            if (height == null) height = 800;
            // Assert
            SDL2.SDL.SDL_GetWindowSize(window.window, out int w, out int h);
            if (window.window != IntPtr.Zero && window.renderer != IntPtr.Zero &&
                SDL2.SDL.SDL_GetWindowTitle(window.window) == title && 
                w == width && h == height)
            {
                passed++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("WINDOW_CREATEWINDOW_WINDOWCREATED PASSED");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("WINDOW_CREATEWINDOW_WINDOWCREATED FAILED");
                Console.ForegroundColor = ConsoleColor.White;
            }
            // clean up
            window.DestroyWindow();
        }
        void WINDOW_DESTROYWINDOW_WINDOWDESTROYED(string title, int width, int height)
        {
            runned++;
            // Arrange
            Window window = new Window(title, width, height);
            // Assert
            SDL2.SDL.SDL_GetWindowSize(window.window, out int w, out int h);
            if (window.window != IntPtr.Zero && window.renderer != IntPtr.Zero &&
                SDL2.SDL.SDL_GetWindowTitle(window.window) == title &&
                w == width && h == height)
            {
                window.DestroyWindow();
                if (window.window == IntPtr.Zero && window.renderer == IntPtr.Zero)
                {
                    passed++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("WINDOW_DESTROYWINDOW_WINDOWDESTROYED PASSED");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("WINDOW_DESTROYWINDOW_WINDOWDESTROYED FAILED DESTROY WINDOW");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("WINDOW_DESTROYWINDOW_WINDOWDESTROYED FAILED AT CREATE WINDOW");
                Console.ForegroundColor = ConsoleColor.White;
                window.DestroyWindow();
            }
        }
        void WINDOW_CLEARCOLOURRENDER_CLEARCOLOURRENDERED(string title, int width, int height, byte r, byte g, byte b ,byte a)
        {
            runned++;
            // Arrange
            Window window = new Window(title, width, height);
            SDL2.SDL.SDL_GetWindowSize(window.window, out int w, out int h);
            if (window.window != IntPtr.Zero && window.renderer != IntPtr.Zero &&
                SDL2.SDL.SDL_GetWindowTitle(window.window) == title &&
                w == width && h == height)
            {
                // Act
                Colour colour = new Colour(r, g, b, a);
                window.ClearColourWindow(colour);
                
                // Assert
                SDL2.SDL.SDL_GetRenderDrawColor(window.renderer, out byte rr, out byte gg, out byte bb, out byte aa);
                if(rr == r && gg == g && bb == b && aa == a)
                {
                    passed++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("WINDOW_CLEARCOLOURRENDER_CLEARCOLOURRENDERED PASSED");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("WINDOW_CLEARCOLOURRENDER_CLEARCOLOURRENDERED FAILED AT RENDER DRAW COLOUR");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("WINDOW_CLEARCOLOURRENDER_CLEARCOLOURRENDERED FAILED AT CREATE WINDOW");
                Console.ForegroundColor = ConsoleColor.White;
            }
            // clean up
            window.DestroyWindow();
        }
        void WINDOW_SYNCCLOK_CLOCKSYNCED(string title, int width, int height, uint fps, int testammount, float error)
        {
            runned++;
            // Arrange
            Window window = new Window(title, width, height);
            SDL2.SDL.SDL_GetWindowSize(window.window, out int w, out int h);
            if (window.window != IntPtr.Zero && window.renderer != IntPtr.Zero &&
                SDL2.SDL.SDL_GetWindowTitle(window.window) == title &&
                w == width && h == height)
            {
                window.fps = fps;
                int loop = 0;
                double avg = 0;

                // Act
                while (loop <= testammount)
                {
                    avg += window.fpsData;
                    window.PresentWindow();
                    loop++;
                }
                double avgFPS = avg / testammount;

                // Assert
                if (avgFPS > fps - error && avgFPS < fps + error)
                {
                    passed++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("WINDOW_SYNCCLOK_CLOCKSYNCED PASSED");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("WINDOW_SYNCCLOK_CLOCKSYNCED FAILED");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("WINDOW_SYNCCLOK_CLOCKSYNCED FAILED AT CREATE WINDOW");
                Console.ForegroundColor = ConsoleColor.White;
            }
            // clean up
            window.DestroyWindow();
        }
        public void FONT_CREATEFONT_FONTCREATED(string path, int size = 24)
        {
            // Arrange
            runned++;
            // Act
            Font font = new Font(path, size);
            // Assert
            if (font.font != System.IntPtr.Zero && font.fontSize == size)
            {
                passed++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("FONT_CREATEFONT_FONTCREATED PASSED");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FONT_CREATEFONT_FONTCREATED FAILED");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void FONT_DESTROYFONT_FONTDESTROYED(string path, int size = 24)
        {
            // Arrange
            runned++;
            Font font = new Font(path, size);
            if(font.font != System.IntPtr.Zero && font.fontSize == size)
            {
                // Act
                font.Destroy();
                // Assert
                if (font.font == System.IntPtr.Zero)
                {
                    passed++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("FONT_DESTROYFONT_FONTDESTROYED PASSED");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("FONT_DESTROYFONT_FONTDESTROYED FAILED");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FONT_DESTROYFONT_FONTDESTROYED FAILED AT CREATE FONT");
                Console.ForegroundColor = ConsoleColor.White;
                font.Destroy();
            }
        }
        public void TEXT_CREATTEXT_TEXTCREATED(string text = "Hello")
        {
            // arrange
            runned++;
            Window window = new Window("Test", 800, 600);
            // act
            Text textTest = new Text(window.renderer);
            textTest.text = text;
            textTest.Update(window.renderer);
            // assert
            if(textTest.text == text && textTest.font.font != IntPtr.Zero && textTest.texture != IntPtr.Zero)
            {
                passed++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("TEXT_CREATTEXT_TEXTCREATED PASSED");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("TEXT_CREATTEXT_TEXTCREATED FAILED");
                Console.ForegroundColor = ConsoleColor.White;
            }
            // clean Up
            textTest.Destroy();
            window.DestroyWindow();
        }
        public void TEXT_DESTROYTEXT_TEXTDESTROYED(string text = "Hello")
        {
            // arrange
            runned++;
            Window window = new Window("Test", 800, 600);
            Text textTest = new Text(window.renderer);
            textTest.text = text;
            textTest.Update(window.renderer);
            if(textTest.text == text && textTest.font.font != IntPtr.Zero && textTest.texture != IntPtr.Zero)
            {
                // act
                textTest.Destroy();
                // assert
                if (textTest.texture == IntPtr.Zero)
                {
                    passed++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("TEXT_DESTROYTEXT_TEXTDESTROYED PASSED");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("TEXT_DESTROYTEXT_TEXTDESTROYED FAILED");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("TEXT_DESTROYTEXT_TEXTDESTROYED FAILED AT CREATE TEXT");
                Console.ForegroundColor = ConsoleColor.White;
                textTest.Destroy();
            }
            // clean Up
            textTest.Destroy();
            window.DestroyWindow();
        }
        public void TEXT_SETPOSITIONANDSIZE_TEXTSET(int x = 0, int y = 0, int w = 0, int h = 0)
        {
            // arrange
            runned++;
            Window window = new Window("Test", 800, 600);
            Text textTest = new Text(window.renderer);
            // act
            textTest.autoSize = false;
            textTest.x = x;
            textTest.y = y;
            textTest.w = w;
            textTest.h = h;
            textTest.Update(window.renderer);
            // assert
            if (textTest.x == x && textTest.y == y && textTest.w == w && textTest.h == h)
            {
                passed++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("TEXT_SETPOSITIONANDSIZE_TEXTSET PASSED");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("TEXT_SETPOSITIONANDSIZE_TEXTSET FAILED");
                Console.ForegroundColor = ConsoleColor.White;
            }
            // cleanUp
            textTest.Destroy();
            window.DestroyWindow();

        }
        public void TEXT_AUTOSIZE_AUTOSIZED(string text = "HELLO")
        {
            // Arrange
            runned++;
            Window window = new Window("Test", 800, 600);
            Text textTest = new Text(window.renderer);
            // Act
            textTest.autoSize = true;
            textTest.text = text;
            textTest.Update(window.renderer);
            // Assert
            if (textTest.w == text.Length * textTest.font.fontSize && textTest.h == textTest.font.fontSize)
            {
                passed++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("TEXT_AUTOSIZE_AUTOSIZED PASSED");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("TEXT_AUTOSIZE_AUTOSIZED FAILED");
                Console.ForegroundColor = ConsoleColor.White;
            }
            // clean Up
            textTest.Destroy();
            window.DestroyWindow();
        }
        public void TEXT_UPDATECOLOUR_COLOURUPDATED(string hexText = "000000", byte a = 255)
        {
            // arrange
            runned++;
            Window window = new Window("Test", 800, 600);
            Text textTest = new Text(window.renderer);
            Colour colour = new Colour(hexText, a);
            // act
            if(textTest.colour.r == 0 && textTest.colour.g == 0 && textTest.colour.b == 0 && textTest.colour.a == 255)
            {
                textTest.colour = colour;
                textTest.Update(window.renderer);
                // assert
                if (textTest.colour.r == colour.r && textTest.colour.g == colour.g && textTest.colour.b == colour.b && textTest.colour.a == colour.a)
                {
                    passed++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("TEXT_UPDATECOLOUR_COLOURUPDATED PASSED");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("TEXT_UPDATECOLOUR_COLOURUPDATED FAILED");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("TEXT_UPDATECOLOUR_COLOURUPDATED FAILED AT CREATE TEXT");
                Console.ForegroundColor = ConsoleColor.White;
            }
            // cleanUp
            textTest.Destroy();
            window.DestroyWindow();
        }
        public void TEXT_UPDATEFONT_FONTUPDATED(string path, int size = 24)
        {
            // arrange
            runned++;
            Window window = new Window("Test", 800, 600);
            Text textTest = new Text(window.renderer);
            Font font = new Font(path, size);
        // act
            textTest.font = font;
            textTest.Update(window.renderer);
            // assert
            if (textTest.font.font == font.font && textTest.font.fontSize == font.fontSize)
            {
                passed++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("TEXT_UPDATEFONT_FONTUPDATED PASSED");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("TEXT_UPDATEFONT_FONTUPDATED FAILED");
                Console.ForegroundColor = ConsoleColor.White;
            }        
            // cleanUP
            textTest.Destroy();
            window.DestroyWindow();
        }
    }
}