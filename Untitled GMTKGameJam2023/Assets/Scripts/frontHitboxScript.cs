using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frontHitboxScript : MonoBehaviour
{
    public GameObject hero;
    public heroActions heroActions;
    public BoxCollider2D frontHitbox;

    // Start is called before the first frame update
    void Start()
    {
        heroActions = hero.GetComponent<heroActions>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Ground":
                turnAround();
                break;
            case "Danger":
                
                break;
        }
    }

    //Turns the hero around
    private void turnAround()
    {
        if (heroActions.facingRight)
        {
            heroActions.facingRight = false;
        }
        else
        {
            heroActions.facingRight = true;
        }
    }
}
