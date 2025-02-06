using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment14
{
    public class GameManager : MonoBehaviour
    {
        Player player;
        Enemy enemy;

        void Start()
        {
            player = new Player("Ahmed", 50);
            enemy = new Enemy("Alaa", 70);

            player.PrintInfo();
            enemy.PrintInfo();

            // Testing all cases for healing player
            player.Heal(5);
            player.PrintInfo();
            player.Heal(50);
            player.PrintInfo();
            player.Heal(60);
            player.PrintInfo();

            // Testing all cases for attacking player
            enemy.Attack(5, player);
            player.PrintInfo();
            enemy.Attack(60, player);
            player.PrintInfo();
            enemy.Attack(10, player);
            player.PrintInfo();

        }
    }
}