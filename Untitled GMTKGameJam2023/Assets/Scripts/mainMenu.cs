using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

    public void levelSelect()
    {
        SceneManager.LoadScene("levelSelect");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
