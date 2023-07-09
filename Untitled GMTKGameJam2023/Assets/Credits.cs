using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject sceneChanger;
    public sceneChangerScript changer;

    // Start is called before the first frame update
    void Start()
    {
        sceneChanger = GameObject.FindGameObjectWithTag("SceneChanger");
        changer = sceneChanger.GetComponent<sceneChangerScript>();
    }

    public void mainMenu()
    {
        changer.LoadScene("Main Menu");
    }
}
