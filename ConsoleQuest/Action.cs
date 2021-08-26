using System;

namespace ConsoleQuest
{
    class Action
    {
        int Result;
        string[] ActionNames;
        public Action(params string[] ActionNames)
        {
            this.ActionNames = ActionNames;
        }
        private void ActionError(int input)
        {
            Console.WriteLine("Введите число от 1 до " + ActionNames.Length);
            Console.WriteLine("Вы ввели: " + input);
            Run();
        }
        public void Run()
        {
            Console.Write("-------------------\n");
            Console.WriteLine("Вы можете:");
            for (int i = 0; i < ActionNames.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + ActionNames[i]);
            }
            int input = new int();
            try
            {
                input = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                ActionError(input);
            }
            if (input > 9 || input > ActionNames.Length)
            {
                ActionError(input);
            }
            else
                Result = input;
        }
        public int GetResult()
        {
            return Result;
        }

    }
}
