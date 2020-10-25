using System;

namespace Character
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Hero", 100, 20, 30, 0, 0);
            Monster monster = new Monster("John", 100, 10, 40, "Penguin");

            player.DisplayStats();
            Console.WriteLine();
            monster.DisplayStats();
        }
    }
}
