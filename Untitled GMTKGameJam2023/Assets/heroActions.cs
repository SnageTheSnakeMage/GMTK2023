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
    private bool facingRight = true;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //Constantly moving forwards
        if (facingRight)
        {
            myRigidBody.velocity = new Vector2(moveSpeed, myRigidBody.velocity.y);
        }
        else
        {
            myRigidBody.velocity = new Vector2(-moveSpeed, myRigidBody.velocity.y);
        }
        //Detecting if there's a pit
        bool isFloor = Physics2D.Raycast(transform.position + Vector3.right, Vector2.down, 10f);
        if (!isFloor)
        {
            myRigidBody.velocity += new Vector2(0, jumpHeight);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}