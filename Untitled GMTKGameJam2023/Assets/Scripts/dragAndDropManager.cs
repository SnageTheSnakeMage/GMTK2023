using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Pathfinding.RaycastModifier;


public class dragAndDropManager : MonoBehaviour
{
    //This script sets up a central manager for all placeable items
    public itemController[] allItems;
    public GameObject[] itemPrefabs;
    public GameObject[] itemPreviewImage;
    public int currentItemID;
    public bool placeable = true;
    void Update()
    {
        //gets position of the cursor and gives it a point in world space
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

        if(Input.GetMouseButtonDown(0) && allItems[currentItemID].selected && placeable)
        {
            Instantiate(itemPrefabs[currentItemID], new Vector3(worldPosition.x, worldPosition.y),Quaternion.identity);
            allItems[currentItemID].quantity--;
            allItems[currentItemID].quantityText.text = allItems[currentItemID].quantity.ToString();

            if (allItems[currentItemID].quantity <= 0)
            {
                allItems[currentItemID].selected = false;
                Destroy(GameObject.FindGameObjectWithTag("Preview"));
            }


        }
    }
}
