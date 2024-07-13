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

            CORETESTS();
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

        void CORETESTS()
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
            COLOUR_CREATECOLOUR_COLOURCREATED(0);
            COLOUR_CREATECOLOUR_COLOURCREATED(255);
            COLOUR_CREATECOLOUR_COLOURCREATED(0, 0);
            COLOUR_CREATECOLOUR_COLOURCREATED(255, 255);
            COLOUR_CREATECOLOUR_COLOURCREATED(0, 0, 0);
            COLOUR_CREATECOLOUR_COLOURCREATED(255, 255, 255);
            COLOUR_CREATECOLOUR_COLOURCREATED(255, 0, 0);
            COLOUR_CREATECOLOUR_COLOURCREATED(0, 255, 0);
            COLOUR_CREATECOLOUR_COLOURCREATED(0, 0, 255);
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

        void COLOUR_CREATECOLOUR_COLOURCREATED(byte ?r = null, byte ?g = null, byte ?b = null, byte ?a = null)
        {
            runned++;
            // Arrange
            Colour colour = new Colour(r, g, b, a);
            if (r == null) r = 0;
            if (g == null) g = 0;
            if (b == null) b = 0;
            if (a == null) a = 0;
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
    }
}