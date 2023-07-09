using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelSelect : MonoBehaviour
{
    private GameObject sceneChanger;
    private sceneChangerScript changer;
    public Button[] levelButtons;
    private readonly int firstLevelIndex = 2;

    // Start is called before the first frame update
    void Start()
    {
        sceneChanger = GameObject.FindGameObjectWithTag("SceneChanger");
        changer = sceneChanger.GetComponent<sceneChangerScript>();

        int levelAt = PlayerPrefs.GetInt("levelAt", firstLevelIndex);

        for (int i=0; i<levelButtons.Length; i++)
        {
            if (i+firstLevelIndex>levelAt)
            {
                levelButtons[i].interactable = false;
            }
        }
    }

    public void selectLevel(int id)
    {
        changer.LoadScene("level"+id.ToString());
    }

    public void backToMenu()
    {
        changer.PreviousScene();
    }
}
