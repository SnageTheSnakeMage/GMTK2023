using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswap : MonoBehaviour
{
    public void Sceneswap(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
