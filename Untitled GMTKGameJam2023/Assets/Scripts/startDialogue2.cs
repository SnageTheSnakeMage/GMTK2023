using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startDialogue2 : MonoBehaviour
{
    public float timer = 10f;
    private bool timerReached = false;
    private DialogueTrigger dialogueTrigger;

    public GameObject hero;
    public GameObject dialogueBox1;
    public GameObject dialogueBox2;
    public GameObject buttons;

    // Start is called before the first frame update
    void Awake()
    {
        dialogueTrigger = this.gameObject.GetComponent<DialogueTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogueBox1 == null)
        {
            if(!timerReached)
            {
                timer -= Time.deltaTime;
                if(timer<=0)
                {
                    timerReached = true;

                    hero.SetActive(false);
                    dialogueBox2.SetActive(true);
                    dialogueTrigger.triggerDialogue(false);
                }
            }
        }

        if(dialogueBox2 == null)
        {
            hero.SetActive(true);
            buttons.SetActive(true);
        }
    }
}
