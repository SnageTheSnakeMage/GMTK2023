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
    [SerializeField]
    private bool facingRight = true;
    public LayerMask ground;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
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
        Debug.DrawLine(this.transform.position, new Vector3(this.transform.position.x+1, this.transform.position.y-1));
        Debug.DrawLine(transform.position, transform.position + (new Vector3(1f, -1f)), Color.red);
        bool isFloor = Physics2D.Raycast(transform.position, transform.position + (new Vector3(1f,-1f)), 5f, ground);
        Debug.Log(isFloor.ToString());
        if(!isFloor)
        {
            facingRight = false;
        }
    }
}
