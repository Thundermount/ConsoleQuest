using System;

namespace ConsoleQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Game gm = new Game();
            Game.WriteLine("Вы шли по дороге. Внезапно вы замечаете бродягу, стоящего на вашем пути.");
            Action ac = new Action("Поговорить с бродягой", "Осмотреть окресности");
            Medallion md = new Medallion();
            while(Input.GetKey() != ConsoleKey.Escape)
            {
                ac.Run();
                int Result = ac.GetResult();
                if(Result == 1)
                {
                    if (!Player.Items.Contains(md)) {
                        Game.WriteLine("Бродяга говорит: В рот мне ноги да это же Девид Блейн!");
                        Player.Money += 50;
                        Player.Items.Add(md);
                        Game.WriteLine("Бродяга отдает вам медальон и 50 монет.");
                    }
                    else
                    {
                        Game.WriteLine("Бродяга ничего не говорит. Похоже он перестал удивляться.");
                    }
                }
                if(Result == 2)
                {
                    Game.WriteLine("Вы видите грунтовую дорогу, на которой стоит бродяга. Он смотрит на вас с восхищением.");
                }
            }
        }
    }
}