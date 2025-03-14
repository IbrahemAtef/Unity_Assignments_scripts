using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exception : MonoBehaviour
{
    int playerScore;
    int deviser;
    void Start()
    {
        playerScore = 100;
        deviser = 0;
        try
        {
            Debug.Log("Attempting to calculate score multiplier...");
            int totalScore = playerScore / deviser;
        }
        catch (System.DivideByZeroException)
        {
            Debug.LogError("Error: Division by zero occurred while calculating score multiplier.");
        }
        finally
        {
            Debug.Log("Score calculation complete. Cleaning up resources.");
        }
    }
}
