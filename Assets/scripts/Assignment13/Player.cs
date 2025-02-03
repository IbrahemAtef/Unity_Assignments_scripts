using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string playerName;
    public int health;

    static public int playerCount = 0;

    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;
    }

    public void Heal(int amount)
    {
        health += amount;
        Debug.Log(health);
    }

    public void Heal(bool fullRestore)
    {
        if (fullRestore == true)
        {
            health = 100;
            Debug.Log(health);
        }
        else Debug.Log("Health didn't change");
    }

    static public void ShowPlayerCount()
    {
        Debug.Log(playerCount);
    }
}
