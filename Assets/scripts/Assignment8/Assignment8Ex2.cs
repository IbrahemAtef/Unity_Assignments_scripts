using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment8Ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Exercise 2: Funny Sentence Generator:
        string[] arr = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        int randomindex = Random.Range(0, arr.Length);
        string sentence = arr[randomindex] + " ";
        int c = 0;
        while (c < 5)
        {
            if (c == 4) sentence += arr[randomindex] + ".";
            else sentence += arr[randomindex] + " ";
            randomindex = Random.Range(0, arr.Length);
            c++;
        }
        Debug.Log(sentence);
    }
}
