using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalScript : MonoBehaviour
{
    private GameObject sceneChanger;
    private sceneChangerScript changer;
    /*public int levelTotal = 3;
    public int menuOffset = 2;
    public int nextScene;*/
    public GameObject goalScreen;
    int voicelineNumber;

    public levelLog Log;
    public int levelNumber;

    void Start()
    {
        /*sceneChanger = GameObject.FindGameObjectWithTag("SceneChanger");
        changer = sceneChanger.GetComponent<sceneChangerScript>();
        nextScene = SceneManager.GetActiveScene().buildIndex+1;*/
        Log = FindAnyObjectByType<levelLog>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        voicelineNumber = Random.Range(1, 5);
        if (collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            goalScreen.SetActive(true);
            Log.completedLevels[levelNumber] = true;
            switch (voicelineNumber)
            {
                case 1:
                    FindObjectOfType<AudioManager>().Play("win1");
                    break;
                case 2:
                    FindObjectOfType<AudioManager>().Play("win2");
                    break;
                case 3:
                    FindObjectOfType<AudioManager>().Play("win3");
                    break;
                case 4:
                    FindObjectOfType<AudioManager>().Play("win4");
                    break;


            }

            //Problem
/*            if(SceneManager.GetActiveScene().buildIndex == menuOffset + levelTotal -1)
            {
                
            }
            else
            {
                if(nextScene > PlayerPrefs.GetInt("levelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", nextScene);
                }
                changer.LoadScene(nextScene);
            }*/
        }
    }
}
