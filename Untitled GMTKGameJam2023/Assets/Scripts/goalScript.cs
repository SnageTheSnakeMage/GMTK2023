using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalScript : MonoBehaviour
{
    public GameObject goalScreen;
    int voicelineNumber;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        voicelineNumber = Random.Range(1, 5);
        if (collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            goalScreen.SetActive(true);
            switch(voicelineNumber)
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
        }
    }
}
