using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMe : MonoBehaviour
{
    public GameObject itemToRotate;
    // Start is called before the first frame update
    void Start()
    {
         Instantiate(itemToRotate, new Vector3(2.0f, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            itemToRotate.transform.Rotate(45f, 45f, 0f, Space.Self);
        }
    }
}
