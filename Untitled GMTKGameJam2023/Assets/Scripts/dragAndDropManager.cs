using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragAndDropManager : MonoBehaviour
{
    public itemController[] allItems;
    public GameObject[] itemPrefabs;
    public GameObject[] itemPreviewImage;
    public int currentItemID;

    void Update()
    {
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

        if(Input.GetMouseButtonDown(0) && allItems[currentItemID].selected)
        {
            allItems[currentItemID].selected = false;
            Instantiate(itemPrefabs[currentItemID], new Vector3(worldPosition.x, worldPosition.y),Quaternion.identity);
            Destroy(GameObject.FindGameObjectWithTag("Preview"));
        }
    }
}
