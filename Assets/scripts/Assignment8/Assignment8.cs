using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Exercise 1: Number Generator:
        int i = 0;
        while (i < 20)
        {
            Debug.Log(Random.Range(1, 21));
            Debug.Log(i);
            if (i == 5) continue;
            if (i == 15) break;
            i++;
        }
    }
}
