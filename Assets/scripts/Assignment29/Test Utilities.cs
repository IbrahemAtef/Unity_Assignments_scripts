using UnityEngine;

namespace Assignment29
{
    public class TestUtalities : MonoBehaviour
    {
        void Start()
        {
            int sum = Utilities.Add(1, 2, 3, 4, 5);
            Debug.Log($"The sum : {sum}");
            string repeatStr = "Hello".RepeatString(3);
            Debug.Log(repeatStr);
        }
    }
}