using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment14
{
    public class Player : Character
    {
        public Player(string name, int health) : base(name, health)
        {
            this.Name = name;
            this.Health = health;
        }

        public void Heal(int heal)
        {
            if (this.Health == 100) Debug.Log("Health is already 100");
            else if (this.Health + heal > 100) this.Health = 100;
            else this.Health += heal;
        }

        public override void PrintInfo()
        {
            Debug.Log("Player Name: " + Name + ", Player Health: " + Health);
        }
    }

}