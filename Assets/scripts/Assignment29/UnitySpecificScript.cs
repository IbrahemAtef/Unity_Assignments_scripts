using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitySpecificScript : MonoBehaviour
{
    GameObject targetObject;
    GameObject joker;
    Light light;
    void OnEnable()
    {
        print("GameObject Enabled");
    }
    // Start is called before the first frame update
    void Start()
    {
        print("Game started!");
        targetObject = GameObject.Find("TargetObject");
        print(targetObject != null ? "Found object by name: " + targetObject.name : "No TargetObject found.");
        joker = GameObject.FindGameObjectWithTag("Joker");
        print(joker != null ? "Found object by tag: " + joker.name : "No Joker object found.");
        light = GameObject.FindObjectOfType<Light>();
        print(light != null ? " Found object of type Light: " + light.name : "No Light object found.");
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            targetObject.SetActive(false);
            print("TargetObject deactivated!");
        }
    }
    void OnDisable()
    {
        print("GameObject Disabled");
    }
}
