using System;

namespace Character
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Player player = new Player("Hero", 100, 20, 0, 0, 0);
            Monster monster = new Monster("John", 100, 10, 0, "Penguin");

            player.DisplayStats();
            player.Damage();
            player.DisplayStats();
            player.Damage();
            player.DisplayStats();
            
            Console.WriteLine();
            monster.DisplayStats();


           

        }


        public void Test(){
            
        }
    }
}
