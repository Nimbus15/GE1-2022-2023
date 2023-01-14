using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SphereController : MonoBehaviour
{
    private float maxSphereSize = 50;
    private float growthRate = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ActionController.instance.machineState == MachineState.MACHINE_ON 
            && transform.localScale.x <= maxSphereSize)
        {
            transform.localScale += new Vector3(growthRate, growthRate, growthRate) * Time.deltaTime;
        }
      
    }
}
