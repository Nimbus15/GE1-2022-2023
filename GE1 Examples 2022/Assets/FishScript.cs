using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour
{
    public Transform head;
    public Transform tail;

    [Range(0, 1.0f)]
    public float frequency;
    public int headAmplitude;
    public int tailAmplitude;
    public float theta;

    // Start is called before the first frame update
    void Start()
    {
        head = gameObject.transform.Find("headCube");   
        tail = gameObject.transform.Find("tailCube");  
    } 

    // Update is called once per frame
    void Update()
    {
        head.transform.rotation = new Transform(head.transform.rotation.x, head.transform.rotation.y, head.transform.rotation.y + Mathf.Sin(theta) * headAmplitude);
        tail.transform.rotation = new Transform(tail.transform.rotation.x, tail.transform.rotation.y, tail.transform.rotation.y + Mathf.Sin(theta) * tailAmplitude);
    }
}
