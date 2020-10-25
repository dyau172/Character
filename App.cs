using System;

namespace Character {
    class App {

        Player player = new Player ("Hero", 100, 20, 0, 0, 0);
        Monster monster = new Monster ("John", 100, 10, 0, "Penguin");

        public void Run () {
            player.DisplayStats ();
            player.Damage ();
            player.DisplayStats ();
            player.Damage ();
            player.DisplayStats ();

            Console.WriteLine ();
            monster.DisplayStats ();

        }

    }

}