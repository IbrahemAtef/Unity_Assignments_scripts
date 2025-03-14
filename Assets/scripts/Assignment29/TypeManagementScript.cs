using System.Collections.Generic;
using UnityEngine;

public class TypeManagementScript : MonoBehaviour
{
    void Start()
    {
        Animal cat = new Cat();
        cat.MakeSound();
        cat.Move();

        Cat cat1 = cat as Cat;
        cat1.MakeSound();
        cat1.Move();

        List<ICanFight> canFights = new List<ICanFight> { new Cat(), new Warrior() };
        foreach (var canFight in canFights)
        {
            canFight.Attack();
            if (canFight is Cat) Debug.Log("The object is a Cat.");
            else Debug.Log("The object is a Warrior.");
        }
    }
}
