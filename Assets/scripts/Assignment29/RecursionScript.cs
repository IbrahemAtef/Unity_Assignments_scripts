using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursionScript : MonoBehaviour
{
    void Start()
    {
        print("Fibonacci for the number 10: " + FibonacciRecursive(10));
        print("Fibonacci for the number 10: " + FibonacciRecursive(10));
        print("Fibonacci for the number 30: " + FibonacciIterative(30));
        print("Fibonacci for the number 30: " + FibonacciIterative(30));
    }
    int FibonacciRecursive(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    int FibonacciIterative(int n)
    {
        int result = 0, fNum = 0, sNum = 1; ;
        for (int i = 2; i <= n; i++)
        {
            result = fNum + sNum;
            (fNum, sNum) = (sNum, result);
        }
        return result;
    }
}
