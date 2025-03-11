using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment27
{
    public class Assignment27 : MonoBehaviour
    {
        void Start()
        {
            int a = 0, b = 0, c;
            assignValue(a);
            Debug.Log($"a: {a}");
            assignValue(ref b);
            Debug.Log($"b: {b}");
            assignValueUsingOut(out c);
            Debug.Log($"c: {c}");
        }

        void assignValue(int val)
        {
            val += 10;
        }
        void assignValue(ref int val)
        {
            val += 10;
        }
        void assignValueUsingOut(out int val)
        {
            val = 5;
        }
    }
}
