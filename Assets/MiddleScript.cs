using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    public LogicScript logic;

    public PipeMoveScript pipeMove;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        pipeMove = GameObject.FindGameObjectWithTag("Pipe").GetComponent<PipeMoveScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logic.addScore(1);
            
            if(logic.getScore() % 10 == 0)
            {
                pipeMove.addSpeed();
            }
        }
        
    }

    
}
