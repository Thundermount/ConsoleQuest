using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuest
{
    class Input
    {
        static Nullable <ConsoleKey> k;
        static Task process;
        // Запускается только один раз
        public static void Init()
        {
            if (process != null) return;
            process = Task.Run(ReciveInput);
        }
        /* Да я мог бы подключить виндосовскую библиотеку
         * user32 и брать нажатия с клавиатуры глобально
         * но в этом нет необходимости к тому же
         * для размера данного проекта хватает */
        private static async Task ReciveInput()
        {
            k = null;
            k = Console.ReadKey(true).Key;
            await Task.Delay(100);
            await ReciveInput();
        }
        public static ConsoleKey? GetKey()
        {
            ConsoleKey? k_temp = k;
            k = null;
            return k_temp;
        }
    }
}
