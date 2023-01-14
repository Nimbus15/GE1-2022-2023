using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySpawner : MonoBehaviour
{
    public GameObject targetPoint;
    private bool isSpawning = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(ActionController.instance.machineState == MachineState.MACHINE_ON
            && !isSpawning)
            StartCoroutine(SpawnParticle()); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Portal1") && ActionController.instance.machineState == MachineState.MACHINE_ON)
        {
            //StartCoroutine(Spawn());
            
        }
    }

    private void OnTriggerExit(Collider other)
    {

    }

    IEnumerator Spawn()
    {
        Debug.Log("Spawn");
        Debug.Log(ActionController.instance.machineState + "At Spawner");

        while (true)
        {
            Debug.Log("SpawnSparkLOOP");
            GameObject g = GameObject.CreatePrimitive(PrimitiveType.Cube);
            g.GetComponent<Transform>().localScale = new Vector3(.2f, .2f, .2f);
            g.AddComponent<Rigidbody>();
            g.AddComponent<Lifetime>();
            g.GetComponent<Lifetime>().lifetime = 1f;
            g.GetComponent<MeshRenderer>().material = ActionController.instance.sparkMaterial;
            g.GetComponent<Rigidbody>().useGravity = true;
            GameObject CubeHolder = GameObject.FindGameObjectWithTag("CubeHolder");
            g.transform.parent = CubeHolder.transform;
            g.transform.position = transform.position;
            yield return new WaitForSeconds(.1f);
        }
    }

    IEnumerator SpawnParticle()
    {
        Debug.Log("SpawnParticle()");
        if (this.gameObject.CompareTag("ParticleSpawn"))
        {
            Debug.Log("ifSpawnParticle");
            isSpawning = true;
            while (true)
            {
                Debug.Log("SpawnLoopParticle");
                GameObject g = GameObject.CreatePrimitive(PrimitiveType.Cube);
                g.GetComponent<Transform>().localScale = new Vector3(1f, 1f, 10f);
                g.AddComponent<Rigidbody>();
                g.GetComponent<Rigidbody>().useGravity = false;
                //g.AddComponent<Lifetime>();
                g.AddComponent<ParticleAccelated>();
                g.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
                g.layer = LayerMask.NameToLayer("ParticleLayer");
                //g.GetComponent<Collider>().isTrigger = true;
                //GameObject tp = GameObject.FindGameObjectWithTag("TargetPoint");
                GameObject tp = targetPoint;

             
                g.GetComponent<ParticleAccelated>().spawnPoint = this.gameObject.transform;
                g.GetComponent<ParticleAccelated>().targetPoint = tp.gameObject.transform;
                g.GetComponent<ParticleAccelated>().setStartPosition(this.gameObject.transform.position);

                g.transform.forward = g.GetComponent<ParticleAccelated>().targetPoint.transform.position -
                 g.GetComponent<ParticleAccelated>().spawnPoint.transform.position;
                g.transform.localScale = new Vector3(g.transform.localScale.x, g.transform.localScale.y,
                    Random.Range(3f, 15f));// tweak
                Rigidbody rb = g.GetComponent<Rigidbody>();
                float force = Random.Range(30f, 500f); // tweak
                Vector3 direction =  tp.gameObject.transform.position - this.gameObject.transform.position;
                direction = direction.normalized;
                rb.AddForce(direction * force, ForceMode.Impulse);
                //g.GetComponent<Lifetime>().lifetime = 2f;
                yield return new WaitForSeconds(Random.Range(0.5f, 2f));
            }
        }
    }
}
