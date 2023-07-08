using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class heroActions : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public BoxCollider2D collision;
    public float moveSpeed = 2;
    public float jumpHeight = 10;
    private bool grounded = true;
<<<<<<< Updated upstream
    public bool facingRight = true;
=======
    private bool facingRight = true;
>>>>>>> Stashed changes

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
=======

    }
>>>>>>> Stashed changes

    }
    // Update is called once per frame
    void FixedUpdate()
    {
<<<<<<< Updated upstream
        //Boolean for if there's a floor in front of the hero
        bool isFloor;

        //Constantly moving forwards and checking for pits
        if (facingRight)
        {
            myRigidBody.velocity = new Vector2(moveSpeed, myRigidBody.velocity.y);
            isFloor = Physics2D.Raycast(transform.position + Vector3.right, Vector2.down, 10f);
=======
        //Constantly moving forwards
        if (facingRight)
        {
            myRigidBody.velocity = new Vector2(moveSpeed, myRigidBody.velocity.y);
>>>>>>> Stashed changes
        }
        else
        {
            myRigidBody.velocity = new Vector2(-moveSpeed, myRigidBody.velocity.y);
<<<<<<< Updated upstream
            isFloor = Physics2D.Raycast(transform.position + Vector3.left, Vector2.down, 10f);
        }

        //If there's a gap in the ground and the hero is grounded, jump
        if (!isFloor && grounded)
        {
            myRigidBody.velocity += new Vector2(0, jumpHeight);
            grounded = false;
        }


    }

    //Checks what object the hero hits when he collides with something
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Ground":
                grounded = true;
                break;
            case "Wall":
                turnAround();
                break;
            case "Danger":
                die();
                break;
        }
    }

    //Turns the hero around
    private void turnAround()
    {
        if(facingRight)
=======
        }

        //Detecting if there's a pit
        bool isFloor = Physics2D.Raycast(transform.position + Vector3.right, Vector2.down, 10f);
        if (!isFloor)
>>>>>>> Stashed changes
        {
            myRigidBody.velocity += new Vector2(0, jumpHeight);
        }
        else
        {
            facingRight = true;
        }
    }

<<<<<<< Updated upstream
    //Death animation and respawn
    public void die()
=======
    private void OnCollisionEnter2D(Collision2D collision)
>>>>>>> Stashed changes
    {

    }
}