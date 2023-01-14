using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Platform : MonoBehaviour
{
    public GameObject platform;
    public GameObject targetPoint;
    //public GameObject startpoint;
    private GameObject thePlayer;
    public delegate void OnTurnMachineDelegate();
    public static event OnTurnMachineDelegate turnMachineDelegate;
    public GameObject travelBubble;


    // Start is called before the first frame update
    void Start()
    {
        turnMachineDelegate += startMachine;
        platform = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            thePlayer = other.gameObject;

            //Debug.Log("Working");
          
            turnMachineDelegate();
        }
    }

    public void startMachine()
    {
        Debug.Log("startMachine");
        ActionController.instance.machineState = MachineState.MACHINE_ON;
       // Debug.Log(ActionController.instance.machineState + "At Sstartmachine");
       // thePlayer.GetComponent<TankController1>().enabled = false;
       // thePlayer.transform.parent = platform.transform;
       // var pos = thePlayer.transform.position;
       // var newY = thePlayer.transform.position.y + targetPoint.transform.position.y *
       //   Mathf.Sin(Time.time * speed);
       // thePlayer.transform.position = new Vector3(pos.x, newY, pos.z);
        if(platform.transform.position.y < targetPoint.transform.position.y)
         StartCoroutine(movePlatformUpCo());  
    }

    float speed = .02f;

    IEnumerator movePlatformUpCo()//working
    {
        Debug.Log("movePlatformUpCo");
        var pos = platform.transform.position;
        Vector3 newTarget = new Vector3(pos.x, targetPoint.transform.position.y, pos.z);
        //var newY = startpoint.transform.position.y + targetPoint.transform.position.y *
        //    Mathf.Sin(Time.time * speed);
        
        float ellapsedTime = 0.0f;
        while (ellapsedTime < 1.0f)
        {
            ellapsedTime += Time.deltaTime;
            transform.position = Vector3.Lerp(pos, newTarget, ellapsedTime);
            yield return 0;
        }
        
        platform.transform.position = new Vector3(pos.x, newTarget.y, pos.z);
        travelBubble.GetComponent<MeshRenderer>().enabled = true;
        yield return new WaitForSeconds(1);
    }

    
}
