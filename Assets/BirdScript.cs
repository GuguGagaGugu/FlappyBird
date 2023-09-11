using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class BirdScript : MonoBehaviour
{
    public LogicScript logic;
    public Rigidbody2D myRigidBody;
    public float BirdVelocity = 10;
    public bool BirdisAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && BirdisAlive)
        {
            myRigidBody.velocity = Vector2.up * BirdVelocity; 
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)//если колизия произойдет
    {
        logic.gameOver();
        BirdisAlive = false;
    }

    
}
