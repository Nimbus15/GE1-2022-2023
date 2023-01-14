using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    public float lifetime;
    private float lifetimeCounter;
    // Start is called before the first frame update
    void Start()
    {
        lifetimeCounter = lifetime;
    }

    // Update is called once per frame
    void Update()
    {
        lifetimeCounter -= Time.deltaTime;
        if(lifetimeCounter <=0)
        {
            Destroy(this.gameObject);
        }
        //AUTOMATIC WEAPON SET LIFETIME BACK TO LIFETIMECOUNTER
    }
}
