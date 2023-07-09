using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class settingsMenu : MonoBehaviour
{
    private GameObject sceneChanger;
    private sceneChangerScript changer;
    public AudioMixer music;
    public AudioMixer sfx;


    // Start is called before the first frame update
    void Start()
    {
        sceneChanger = GameObject.FindGameObjectWithTag("SceneChanger");
        changer = sceneChanger.GetComponent<sceneChangerScript>();
    }

    public void musicAudio (float volume)
    {
        music.SetFloat("volume", volume);
    }

    public void sfxAudio(float volume)
    {
        sfx.SetFloat("volume", volume);
    }

    public void backButton()
    {
        changer.PreviousScene();
    }
}
