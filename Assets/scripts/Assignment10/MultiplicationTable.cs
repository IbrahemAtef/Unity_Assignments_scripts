using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Assignment 10: Create a Multiplication Table for 5 (from 1 to 10)
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log($"5 * {i} = {Multiply(5, i)}");
        }
    }

    int Multiply(int x, int y)
    {
        return x * y;
    }
}
