using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockItem : MonoBehaviour
{
    public int iD;
    private dragAndDropManager dragAndDropMgr;
    void Start()
    {
        dragAndDropMgr = GameObject.FindGameObjectWithTag("dragAndDropManager").GetComponent<dragAndDropManager>();
    }

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Destroy(this.gameObject);
            dragAndDropMgr.allItems[iD].quantity++;
            dragAndDropMgr.allItems[iD].quantityText.text = dragAndDropMgr.allItems[iD].quantity.ToString();
            FindObjectOfType<AudioManager>().Play("Remove");
        }
    }

}
