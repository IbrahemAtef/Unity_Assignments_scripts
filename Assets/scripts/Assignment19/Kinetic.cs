using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace Assignment19
{
    public class Kinetic : MonoBehaviour
    {
        public GameObject[] holders;
        float degreeX = 0f;
        void Start()
        {
        }

        void Update()
        {
            float rotationSpeed = 45f;
            degreeX -= rotationSpeed * Time.deltaTime;
            var (y0, z0) = GetDataFormQuaternion(holders[0].transform.eulerAngles);
            var (y1, z1) = GetDataFormQuaternion(holders[1].transform.eulerAngles);
            var (y2, z2) = GetDataFormQuaternion(holders[2].transform.eulerAngles);
            var (y3, z3) = GetDataFormQuaternion(holders[3].transform.eulerAngles);
            holders[0].transform.rotation = Quaternion.Euler(degreeX, y0, z0);
            holders[1].transform.rotation = Quaternion.Euler(degreeX, y1, z1);
            holders[2].transform.rotation = Quaternion.Euler(degreeX * 0.5f, y2, z2);
            holders[3].transform.rotation = Quaternion.Euler(degreeX * 0.5f, y3, z3);
        }

        (float y, float z) GetDataFormQuaternion(Vector3 angles)
        {
            return (angles.y, angles.z);
        }
    }
}
