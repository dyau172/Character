using System;

namespace Character {
    class Character {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Defence { get; set; }

        public int Attack {get; set;}

        

        

        

        public Character(){
           
            
        }

        public void Damage ()
        {
            int damage = new Random().Next(5,30);
            Health -= damage;
        }


       


        public void DisplayStats(){
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health Points: {Health}");
            Console.WriteLine();
            
            
        }

    }
}