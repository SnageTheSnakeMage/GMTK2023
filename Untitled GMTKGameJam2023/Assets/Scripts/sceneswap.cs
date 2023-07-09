using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswap : MonoBehaviour
{
    public void Sceneswap(string sceneName)
    {
        if (sceneName == "Main Menu") {
            FindObjectOfType<AudioManager>().Stop("Main Theme");
            FindObjectOfType<AudioManager>().Play("Main Menu");
        }
        else
        {
            FindObjectOfType<AudioManager>().Stop("Main Menu");
        }
        SceneManager.LoadScene(sceneName);
    }
}
