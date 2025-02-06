using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment14
{
    public class Character
    {
        private string name = "";
        private int health = 0;

        public Character(string name, int health)
        {
            this.name = name;
            this.health = health;
        }

        public string Name
        {
            get { return name; }
            set { if (value.Length == 0) Debug.Log("name is empty"); else name = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public virtual void PrintInfo()
        {
            Debug.Log("Character Name: " + Name + ", Character Health: " + Health);
        }
    }

}
