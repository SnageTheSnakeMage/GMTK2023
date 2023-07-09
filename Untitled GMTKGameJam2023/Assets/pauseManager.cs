using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class pauseManager : MonoBehaviour
{
    public GameObject pausemenu;
    public bool ispaused = false;
    public void Pause()
    {
        ispaused = true;
        pausemenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        ispaused = false;
        pausemenu.SetActive(false); 
        Time.timeScale = 0;
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && !ispaused)
        {
            Pause();
        }
        if (Input.GetKeyUp(KeyCode.Escape) && ispaused)
        {
            Resume();
        }
    }
}