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
    
    void Start()
    {
        respawnPosition = GameObject.FindGameObjectWithTag("Respawn").transform;
        heroActions = hero.GetComponent<heroActions>();
        heroActions.sprite.flipX = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Ground":
                Debug.Log("Hit Some Ground");
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
        Debug.Log("turned around");
        if (heroActions.facingRight)
        {
            heroActions.facingRight = false;
            frontHitbox.offset = new Vector2(-1.1f,0);
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
        int voicelineNumber = Random.Range(1, 6);
        if (!heroActions.facingRight)
        {
            turnAround();
        }
        switch(voicelineNumber){
            case 1:
                FindObjectOfType<AudioManager>().Play("fail" + voicelineNumber.ToString());
                break;
            case 2:
                FindObjectOfType<AudioManager>().Play("fail" + voicelineNumber.ToString());
                break;
            case 3:
                FindObjectOfType<AudioManager>().Play("fail" + voicelineNumber.ToString());
                break;
            case 4:
                FindObjectOfType<AudioManager>().Play("fail" + voicelineNumber.ToString());
                break;
            case 5:
                FindObjectOfType<AudioManager>().Play("fail" + voicelineNumber.ToString());
                break;
        }
        hero.transform.position = respawnPosition.position;
           
    }

}
