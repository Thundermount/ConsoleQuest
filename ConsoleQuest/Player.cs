using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleQuest
{
    static class Player
    {
        public static float Health = 100.0f;
        public static int Money = 0;
        public static List<Item> Items = new List<Item>();
    }

    abstract class Item
    {
        public string Name;
        public string Description;
        public bool eatable = false;
    }
    class Medallion : Item
    {
        
        public Medallion()
        {
            this.Name = "Медальон";
            this.Description = "Выглядит как обычный старинный медальон.";
        }
    }
}
