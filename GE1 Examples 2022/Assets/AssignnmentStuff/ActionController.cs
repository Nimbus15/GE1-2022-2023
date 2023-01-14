using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum MachineState
{
    MACHINE_OFF,
    MACHINE_HALFPOWER,
    MACHINE_ON
}

public class ActionController : MonoBehaviour
{
    public static ActionController instance;
    [SerializeField]
    public Material sparkMaterial;

    public MachineState machineState = MachineState.MACHINE_OFF;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null)
        {
            //Debug.LogError("More than one audioManager in the scene.");
            if (instance != this)
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
