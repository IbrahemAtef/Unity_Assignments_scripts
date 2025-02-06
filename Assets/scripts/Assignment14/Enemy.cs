using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment14
{
    public class Enemy : Character
    {
        public Enemy(string name, int health) : base(name, health)
        {
            this.Name = name;
            this.Health = health;
        }

        public void Attack(int attack, Character character)
        {
            if (character.Health == 0) Debug.Log("Health is already 0");
            else if (character.Health - attack < 0) character.Health = 0;
            else character.Health -= attack;
        }

        public override void PrintInfo()
        {
            Debug.Log("Enemy Name: " + Name + ", Enemy Health: " + Health);
        }
    }
}
