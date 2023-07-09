using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class previewItem : MonoBehaviour
{
    public SpriteRenderer sprite;
    public int iD;
    public dragAndDropManager dragAndDropMgr;

    public void Start()
    {
        dragAndDropMgr = FindObjectOfType<dragAndDropManager>();
    }
    private void FixedUpdate()
    {
        if(dragAndDropMgr.currentItemID != iD)
        {
            Destroy(gameObject);
        }
        if(Physics2D.OverlapBox(this.transform.position, new Vector2(.9f,0.9f), 0))
        {
            sprite.color = new Color(1, 0, 0, 0.3529412f);
            dragAndDropMgr.placeable = false;
        }
        else
        {
            sprite.color = new Color(0.371262f, 0.9716981f, 0.9252314f, 0.3529412f);
            dragAndDropMgr .placeable = true;
        }
    }
}
