using System.Collections;
using UnityEngine;

namespace Assignment25
{
    public class PoUpBox : MonoBehaviour
    {
        public Transform boardHalf;
        public float rotationSpeed = 50f;

        public Vector3 bottomLeft;

        bool isOpened = true;
        bool isClosed = false;

        public float appearSpeed = 2f;

        public GameObject[] chessPeaces;

        GameObject[] oldGameObjects;


        void Start()
        {
            oldGameObjects = DeepCopyArray(chessPeaces);

            bottomLeft = GetCornerPosition(boardHalf.GetComponent<Renderer>(), new Vector3(1, 1, 0));
            foreach (GameObject row in chessPeaces)
            {
                foreach (Transform child in row.transform)
                {
                    child.localScale = Vector3.zero;
                    child.gameObject.SetActive(false);
                }
            }
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.RightArrow) && !isClosed)
            {
                isOpened = false;
                RotateObject(Vector3.back, bottomLeft);
                if (Mathf.Floor(boardHalf.rotation.eulerAngles.z) == 179) isClosed = true;
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && !isOpened)
            {
                isClosed = false;
                RotateObject(Vector3.forward, bottomLeft);
                if (Mathf.Floor(boardHalf.rotation.eulerAngles.z) == 0) isOpened = true;
            }
            else if (Input.GetKeyDown(KeyCode.W) && isOpened)
            {
                ShowObject(chessPeaces[0]);
                ShowObject(chessPeaces[1]);
            }
            else if (Input.GetKeyDown(KeyCode.B) && isOpened)
            {
                ShowObject(chessPeaces[2]);
                ShowObject(chessPeaces[3]);
            }
        }
        public void ShowObject(GameObject gameObject)
        {

            for (int i = 0; i < gameObject.transform.childCount; i++)
            {
                Vector3 targetScale = oldGameObjects[0].transform.GetChild(i).transform.localScale;
                Transform current = gameObject.transform.GetChild(i);
                GameObject target = current.gameObject;
                target.SetActive(true);
                StartCoroutine(ScaleUp(targetScale, current));
            }
        }
        IEnumerator ScaleUp(Vector3 targetScale, Transform transform)
        {
            float progress = 0f;

            while (progress < 1f)
            {
                progress += appearSpeed * Time.deltaTime;
                transform.localScale = Vector3.Lerp(Vector3.zero, targetScale, progress);
                yield return null;
            }

            transform.localScale = targetScale;
        }

        void RotateObject(Vector3 rotationAxis, Vector3 cornerOffset)
        {
            boardHalf.RotateAround(cornerOffset, rotationAxis, rotationSpeed * Time.deltaTime);
        }

        Vector3 GetCornerPosition(Renderer renderer, Vector3 cornerOffset)
        {
            if (renderer == null) return Vector3.zero;

            Bounds bounds = renderer.bounds;

            // Calculate the corner position using bounds
            Vector3 cornerPosition = bounds.center + Vector3.Scale(bounds.extents, cornerOffset);
            return cornerPosition;
        }

        GameObject[] DeepCopyArray(GameObject[] originalArray)
        {
            GameObject[] copiedArray = new GameObject[originalArray.Length];

            for (int i = 0; i < originalArray.Length; i++)
            {
                if (originalArray[i] != null)
                {
                    copiedArray[i] = Instantiate(originalArray[i]);
                }
            }

            return copiedArray;
        }
        void OnDisable()
        {
            StopAllCoroutines();

        }
    }
}