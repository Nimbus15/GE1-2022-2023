using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed;
    public float fireRate;
    public Transform transform;
    public Collider2D sphereCollider;
    public bool isTrigger=false;

    private Transform playerTransform;

    public GameObject bulletPrehab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if input button is pressed
        //shootCo()
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        // if the other player's tag is the play
        // get the player transform from other
        // print player
    }

    public virtual void OnTriggerStay(Collider other)
    {
        // if the other player's tag is the play
        // get the player transform from other
        // print player
    }

    public virtual void OnTriggerExit(Collider other)
    {
        // if the other player's tag is the play
        // get the player transform
        // print player
    }

    private IEnumerator shootCo()
    {
        //spawn bullet
        yield return fireRate;
    }
}
