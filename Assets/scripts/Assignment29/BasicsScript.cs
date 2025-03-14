using System;
using UnityEngine;

namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var num = 5;
            var name = "Ibrahim";
            var isHuman = true;
            bool isOdd = num % 2 == 1 ? true : false;
            Debug.Log($"num : {num}, name : {name}, isHum   an : {isHuman}");
            string msg = $"The number {num} is {(isOdd ? "Odd" : "Even")}";
            Debug.Log(msg);
            Debug.Log("Current Date: " + DateTime.Today.ToShortDateString());
            Debug.Log("Current Time: " + DateTime.Now.ToShortTimeString()); //);
            Debug.Log("Current Day: " + DateTime.Today.DayOfWeek);
        }
    }
}
