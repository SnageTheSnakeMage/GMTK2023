using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crumbleBlockScript : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public Animator animator;

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
