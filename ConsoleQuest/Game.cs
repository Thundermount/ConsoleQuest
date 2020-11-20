using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace ConsoleQuest
{
    class Game
    {
        public Game()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Input.Init();
        }
        private static int WriteDelay = 70;
        private static bool skip = false;
        public static void WriteLine(string text)
        {
            Write(text);  
            Console.Write("\n");
        }
        public static void Write(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                if (!skip)
                {
                    if (Input.GetKey() == ConsoleKey.Enter) skip = true;
                    Thread.Sleep(WriteDelay);
                    if (text[i].Equals('.') || text[i].Equals('?') || text[i].Equals('!')) Thread.Sleep(1000);
                }
            }
        }
    }
}
