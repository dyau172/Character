using System;

namespace Character
{
    class Player : Character
    {
        public int Experience;

        public int Gold;

        public Player(string name, int health, int defence, int attack,  int experience, int gold){
            Name = name;
            Health = health;
            Defence = defence;
            Attack = attack;
            Experience = experience;
            Gold = gold;

        }


    }
}
