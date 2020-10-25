using System;

namespace Character
{
    class Player : Character
    {
        public int Experience;

        public int Gold;

        public Player(string name, int health, int defence, int damage, int experience, int gold){
            Name = name;
            Health = health;
            Defence = defence;
            Damage = damage;
            Experience = experience;
            Gold = gold;

        }


    }
}
