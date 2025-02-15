using UnityEngine;

namespace Assignment20
{

    public class InteractiveToy : MonoBehaviour
    {
        public GameObject bikeWheel;
        public GameObject bike;

        float degreeX = 0f;
        void Start()
        {

        }

        void Update()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                float rotationSpeed = 45f;
                degreeX += rotationSpeed * Time.deltaTime; // rotation forward
                var (x1, y1, z1) = GetDataFormQuaternion(bikeWheel.transform.eulerAngles);
                bikeWheel.transform.rotation = Quaternion.Euler(degreeX, y1, z1);
                bike.transform.position += new Vector3(0, 0, 0.01f);

            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                float rotationSpeed = 45f;
                degreeX -= rotationSpeed * Time.deltaTime; // rotation backward
                var (x1, y1, z1) = GetDataFormQuaternion(bikeWheel.transform.eulerAngles);
                bikeWheel.transform.rotation = Quaternion.Euler(degreeX, y1, z1);
                bike.transform.position -= new Vector3(0, 0, 0.01f);
            }
        }

        (float x, float y, float z) GetDataFormQuaternion(Vector3 angles)
        {
            return (angles.x, angles.y, angles.z);
        }
    }
}
