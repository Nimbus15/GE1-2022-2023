using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PortalMovement : MonoBehaviour
{
    private Vector3 rotation;
    public float speed=1;
    
    // Start is called before the first frame update
    private void Awake()
    {
        rotation = Vector3.up;
    }
    void Start()
    {
        Platform.turnMachineDelegate += rotatePortals;
    }

    // Update is called once per frame
    void Update()
    {
      
       
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        
    }

    private void rotatePortals()
    {

        Debug.Log("rotatePortals");

        //else if (Input.GetKey(KeyCode.C)) _rotation = Vector3.down;
        // else _rotation = Vector3.zero;
        StartCoroutine(rotateCo());
       
    }

    IEnumerator rotateCo()
    {
        while (true)
        {
            if (this.CompareTag("Portal1"))
            {
                transform.Rotate(rotation * speed * Time.deltaTime);
            }
            else if (this.CompareTag("Portal2"))
            {
                transform.Rotate(-(rotation * speed * Time.deltaTime));
            }
            if (speed <= 2000000)
                speed += speed;
            yield return new WaitForSeconds(.1f);
        }
    }


}
