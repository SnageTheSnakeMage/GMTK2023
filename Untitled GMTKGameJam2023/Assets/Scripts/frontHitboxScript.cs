using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frontHitboxScript : MonoBehaviour
{
    public GameObject hero;
    public heroActions heroActions;
    public BoxCollider2D frontHitbox;

    //used for death method
    public Transform respawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        heroActions = hero.GetComponent<heroActions>();
        heroActions.sprite.flipX = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Ground":
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
        if (heroActions.facingRight)
        {
            heroActions.facingRight = false;
            frontHitbox.offset = new Vector2(-0.68f,0);
            heroActions.sprite.flipX = false;
        }
        else
        {
            heroActions.facingRight = true;
            frontHitbox.offset = new Vector2(0.68f, 0);
            heroActions.sprite.flipX = true;
        }
    }
    //moved die method here to access turnAround
    public void die()
    {
        hero.transform.position = respawnPosition.position;
        turnAround();   
    }
}
