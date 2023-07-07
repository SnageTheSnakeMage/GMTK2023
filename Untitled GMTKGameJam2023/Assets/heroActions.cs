using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroActions : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public BoxCollider2D collision;
    public float moveSpeed = 2;
    public float jumpHeight;
    private bool grounded;
    private bool facingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Constantly moving forwards
        if(facingRight)
        {
            myRigidBody.velocity = Vector2.right * moveSpeed;
        }
        else
        {
            myRigidBody.velocity = Vector2.left * moveSpeed;
        }

        //Detecting if there's a pit
        bool isFloor = Physics.Raycast(transform.position, transform.TransformDirection(new Vector3(1f,-1f)), 1f);
        if(!isFloor)
        {
            facingRight = false;
        }
    }
}
