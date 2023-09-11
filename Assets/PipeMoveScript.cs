using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public LogicScript script;
    public float movespeed = 5;
    public float deadZone = -35;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
        if(transform.position.x < deadZone)
        {
            Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
    }
    

    void VelocityRate()
    {
       
    }

}
