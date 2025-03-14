using UnityEngine;

namespace Assignment29
{
    public class TestCustomObject : MonoBehaviour
    {
        void Start()
        {
            CustomObject customObject = new(1, "Ibrahim");
            CustomObject customObject2 = new(2, "Ahmed");
            CustomObject customObject3 = new(2, "Ahmed");
            print(customObject);
            print(customObject == customObject2);
            print(customObject2 == customObject3);
            print(customObject != customObject2);
            print(customObject2 != customObject3);
        }
    }
}