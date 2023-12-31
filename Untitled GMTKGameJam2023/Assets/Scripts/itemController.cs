using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class itemController : MonoBehaviour
{
    public int iD;
    public int quantity;
    public TextMeshProUGUI quantityText;
    public bool selected = false;
    public dragAndDropManager dragAndDropMgr;
    void Start()
    {
        quantityText.text = quantity.ToString();
        dragAndDropMgr = GameObject.FindGameObjectWithTag("dragAndDropManager").GetComponent<dragAndDropManager>();
    }
    public void ChangedSelection()
    {
        if (dragAndDropMgr.currentItemID != iD)
        {
            Destroy(GameObject.FindGameObjectWithTag("Preview"));
        }
    }
    public void BlockSelected()
    {
        if(quantity > 0) 
        {
            Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
            Instantiate(dragAndDropMgr.itemPreviewImage[iD], new Vector3(worldPosition.x, worldPosition.y, 0), Quaternion.identity);
            dragAndDropMgr.currentItemID = iD;
            selected = true;
        }
    }

}
