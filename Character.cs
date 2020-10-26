using System;
using System.Collections.Generic;

namespace Character {
    class Character {
        public string Name { get; set; }

        int health;
        public int Health {
            get{return health;}
            set {
                if (value <= 0) {
                    health = 0;
                }else {
                    health = value;
                }

            }
        }
        public int Defence { get; set; }

        public int Attack { get; set; }

        public Character () {

        }

        public void Damage () {
            int damage = new Random ().Next (5, 30);
            
            Health -= damage;
        }

       

        public void DisplayStats () {
            Console.WriteLine ($"Name: {Name}");
            Console.WriteLine ($"Health Points: {Health}");
            

        }

    }
}