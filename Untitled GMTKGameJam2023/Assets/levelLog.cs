using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelLog : MonoBehaviour
{
    public bool[] completedLevels;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void CompletedLevel(int level)
    {
        completedLevels[level] = true;
    }
}
