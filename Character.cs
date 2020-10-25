using System;

namespace Character {
    class Character {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Defence { get; set; }
        public int Damage { get; set; }

        //public string Sprite;


        public void DisplayStats(){
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health Points: {Health}");
            
        }

    }
}