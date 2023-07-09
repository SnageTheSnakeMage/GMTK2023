using UnityEngine;

public class audioPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Main Theme");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
