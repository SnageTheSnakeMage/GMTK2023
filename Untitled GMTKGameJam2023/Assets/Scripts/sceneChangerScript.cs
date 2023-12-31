using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChangerScript : MonoBehaviour
{
    private List<string> sceneHistory = new List<string>();  //running history of scenes//The last string in the list is always the current scene running


    void Start()
    {
        DontDestroyOnLoad(this.gameObject);  //Allow this object to persist between scene changes
        sceneHistory.Add("Main Menu");
    }

    //Call this whenever you want to load a new scene
    //It will add the new scene to the sceneHistory list
    public void LoadScene(string newScene)
    {
        if (newScene == "Main Menu")
        {
            FindObjectOfType<AudioManager>().Stop("Main Theme");
            FindObjectOfType<AudioManager>().Play("Main Menu");
        }
        else
        {
            FindObjectOfType<AudioManager>().Stop("Main Menu");
            FindObjectOfType<AudioManager>().Play("Main Theme");
        }
        sceneHistory.Add(newScene);
        SceneManager.LoadScene(newScene);
    }

    //Call this whenever you want to load a new scene
    //It will add the new scene to the sceneHistory list
    public void LoadScene(int sceneIndex)
    {
        sceneHistory.Add(NameFromIndex(sceneIndex));
        SceneManager.LoadScene(NameFromIndex(sceneIndex));
    }

    private static string NameFromIndex(int BuildIndex)
    {
        string path = SceneUtility.GetScenePathByBuildIndex(BuildIndex);
        int slash = path.LastIndexOf('/');
        string name = path.Substring(slash + 1);
        int dot = name.LastIndexOf('.');
        return name.Substring(0, dot);
    }

    //Call this whenever you want to load the previous scene
    //It will remove the current scene from the history and then load the new last scene in the history
    //It will return false if we have not moved between scenes enough to have stored a previous scene in the history
    public bool PreviousScene()
    {
        bool returnValue = false;
        if (sceneHistory.Count >= 2)  //Checking that we have actually switched scenes enough to go back to a previous scene
        {
            returnValue = true;
            sceneHistory.RemoveAt(sceneHistory.Count - 1);
            SceneManager.LoadScene(sceneHistory[sceneHistory.Count - 1]);
        }

        return returnValue;
    }

}
