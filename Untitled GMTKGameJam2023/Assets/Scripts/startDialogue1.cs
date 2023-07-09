using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startDialogue1 : MonoBehaviour
{
    public GameObject hero;
    private DialogueTrigger dialogueTrigger;
    public GameObject dialogueBox;
    public GameObject dialogueBox2;
    public GameObject buttons;

    // Start is called before the first frame update
    void Start()
    {
        hero.SetActive(false);
        dialogueBox2.SetActive(false);
        buttons.SetActive(false);
        dialogueTrigger = this.gameObject.GetComponent<DialogueTrigger>();
        dialogueTrigger.triggerDialogue(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogueBox == null)
        {
            hero.SetActive(true);
        }
    }
}
