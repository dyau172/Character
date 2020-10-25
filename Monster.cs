using System;

namespace Character {
    class Monster : Character {
        public string Type;

        public Monster (string name, int health, int defence, int damage, string type) {
            Name = name;
            Health = health;
            Defence = defence;
            Damage = damage;
            Type = type;

        }

    }
}