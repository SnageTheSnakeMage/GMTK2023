using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelLog : MonoBehaviour
{
    public bool[] completedLevels;
    public static levelLog instance;
    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void CompletedLevel(int level)
    {
        completedLevels[level] = true;
    }
}
