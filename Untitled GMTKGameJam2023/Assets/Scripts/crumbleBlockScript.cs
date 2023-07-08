using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crumbleBlockScript : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public Animator animator;
    public int iD;
    private dragAndDropManager dragAndDropMgr;
    void Start()
    {
        dragAndDropMgr = GameObject.FindGameObjectWithTag("dragAndDropManager").GetComponent<dragAndDropManager>();
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
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            crumble();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            crumble();
        }
    }

    private void crumble()
    {
        boxCollider.enabled = false;
        animator.SetBool("crumble", true);
    }
}
