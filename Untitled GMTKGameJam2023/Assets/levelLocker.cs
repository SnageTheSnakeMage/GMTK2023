using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelLocker : MonoBehaviour
{
    public levelLog Log;
    public Button[] allLevels;
    private void Start()
    {
        Log = FindAnyObjectByType<levelLog>();
        //unlock all completed levels
        for (int i = 0; i < 8; i++)
        {
            allLevels[i].interactable = Log.completedLevels[i];
        }
        //unlock upcoming levels
        for (int i = 0;i < 8; i++)
        {
            if (Log.completedLevels[i])
            {
                Debug.Log("level" + i + "is complete");
                allLevels[1 + i].interactable = true;
                Debug.Log("unlocked level" + i);
            }
            else
            {
                Debug.Log("level" + i + "was locked");
                allLevels[i].interactable = false;
            }
        }
        //level 1 is always unlocked
        allLevels[0].interactable = true;
    }
}
