using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class heroActions : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Rigidbody2D myRigidBody;
    public BoxCollider2D bodyHit;
    public float moveSpeed = 2;
    public float jumpHeight = 10;
    public bool grounded = true;
    public bool facingRight = true;
    public float lookDownBy = 5f;
    public Animator anim;


    //used for death method
    public frontHitboxScript frontHitbox;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Boolean for if there's a floor in front of the hero
        bool isFloor;

        //Constantly moving forwards and checking for pits
        if (facingRight)
        {
            if (grounded)
            {
                myRigidBody.velocity = new Vector2(moveSpeed, myRigidBody.velocity.y);
            }
            isFloor = Physics2D.Raycast(transform.position + Vector3.right, Vector2.down, lookDownBy);
            RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(2,0), Vector2.down, lookDownBy);
            if (hit)
            {
                if (hit.transform.gameObject.tag == "Danger" && grounded)
                {
                    jump();
                }
            }
        }
        else
        {
            if (grounded)
            {
                myRigidBody.velocity = new Vector2(-moveSpeed, myRigidBody.velocity.y);
            }
            isFloor = Physics2D.Raycast(transform.position + Vector3.left, Vector2.down, lookDownBy);
            RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(-2, 0), Vector2.down, lookDownBy);
            if (hit)
            {
                if (hit.transform.gameObject.tag == "Danger" && grounded)
                {
                    jump();
                }
            }
        }

        //If there's a gap in the ground and the hero is grounded, jump
        if (!isFloor && grounded)
        {
            jump();
        }

        //jump anime check

    }

    //Checks what object the hero hits when he collides with something
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Ground":
                grounded = true;
                anim.SetBool("jumping?", false);
                break;
            case "Danger":
                frontHitbox.die();
                anim.SetBool("jumping?", false);
                break;
            
        }
    }

    public void jump()
    {
        anim.SetBool("jumping?", true);
        myRigidBody.velocity += new Vector2((myRigidBody.velocity.x/Mathf.Abs(myRigidBody.velocity.x)), jumpHeight);
        grounded = false;
    }

    //Death animation and respawn
 
}