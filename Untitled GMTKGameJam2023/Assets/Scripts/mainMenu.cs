using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject sceneChanger;
    public sceneChangerScript changer;

    // Start is called before the first frame update
    void Start()
    {
        sceneChanger = GameObject.FindGameObjectWithTag("SceneChanger");
        changer = sceneChanger.GetComponent<sceneChangerScript>();
    }

    public void levelSelect()
    {
        changer.LoadScene("levelSelect");
    }

    public void settings()
    {
        changer.LoadScene("Settings");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
