using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class springScript : MonoBehaviour
{
    public int jumpforce = 4;
    public Rigidbody2D heroRb;
    public int iD;
    private dragAndDropManager dragAndDropMgr;

    private void Start()
    {
        jumpforce = 13;
        heroRb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        dragAndDropMgr = GameObject.FindGameObjectWithTag("dragAndDropManager").GetComponent<dragAndDropManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("player got a boost!");
           // FindObjectOfType<AudioManager>().Play("boing");
            heroRb.velocity += Vector2.up * jumpforce;
        }
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(this.gameObject);
            dragAndDropMgr.allItems[iD].quantity++;
            dragAndDropMgr.allItems[iD].quantityText.text = dragAndDropMgr.allItems[iD].quantity.ToString();
            FindObjectOfType<AudioManager>().Play("Remove");
        }
    }

}
