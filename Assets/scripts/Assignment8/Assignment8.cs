using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Exercise 1: Number Generator:
        int randomNum;
        while (true)
        {
            randomNum = Random.Range(1, 21);
            if (randomNum == 5)
            {
                Debug.Log("randomNum 15 skipped");
                continue;
            };
            if (randomNum == 15) break;
            Debug.Log(randomNum);
        }
        Debug.Log("The program has stopped because the random number is: " + randomNum);
    }

}
