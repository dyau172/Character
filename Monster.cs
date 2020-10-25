using System;

namespace Character {
    class Monster : Character {
        public string Type;

        public Monster (string name, int health, int defence, int attack, string type) {
            Name = name;
            Health = health;
            Defence = defence;
            Attack = attack;
            Type = type;

        }

    }
}