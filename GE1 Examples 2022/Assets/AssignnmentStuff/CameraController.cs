using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float maxCameraDistanceZ = -75;
    private float speed = -1;//tweak - 4
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()// when nested in a parent ge it will show me the local position of the child member
    {
        if (ActionController.instance.machineState == MachineState.MACHINE_ON
           && transform.position.z >= maxCameraDistanceZ)
        {
            transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
            transform.LookAt(transform.parent);
        }
    }
}
