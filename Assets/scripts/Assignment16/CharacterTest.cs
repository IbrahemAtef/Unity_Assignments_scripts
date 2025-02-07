using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Officer officer = new Officer("Officer1", 100, new Position(0, 0, 0));
            Soldier soldier = new Soldier();
            Character[] characters = new Character[2];
            characters[0] = soldier;
            characters[1] = officer;

            foreach (Character c in characters)
            {
                c.DisplayInfo();
            }

            Debug.Log("Soldier health before the attack: " + soldier.Health);
            officer.Attack(50, soldier, "shooting");
            Debug.Log("Soldier health after the attack: " + soldier.Health);
        }
    }
}
