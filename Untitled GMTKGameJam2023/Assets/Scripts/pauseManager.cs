using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class pauseManager : MonoBehaviour
{
    public GameObject pausemenu;
    public bool ispaused = false;
    public void Pause()
    {
        FindObjectOfType<AudioManager>().Stop("Main Theme");
        ispaused = true;
        pausemenu.SetActive(true);
        Time.timeScale = 0;
        Debug.Log("Paused Game");
    }
    public void Resume()
    {
        FindObjectOfType<AudioManager>().Play("Main Theme");
        ispaused = false;
        pausemenu.SetActive(false); 
        Time.timeScale = 0;
        Debug.Log("Resumed Game");
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