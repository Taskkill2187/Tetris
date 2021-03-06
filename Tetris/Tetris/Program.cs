using System;

namespace Tetris
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (XNAMain game = new XNAMain())
            {
                game.Run();
            }
        }
    }
#endif
}

