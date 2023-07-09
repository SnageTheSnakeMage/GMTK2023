using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public DialogueManager dialogueManager;

    public void triggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void triggerDialogue(bool justOne)
    {
        if (justOne)
        {
            triggerDialogue();
        }
        else
        {
           dialogueManager.StartDialogue(dialogue);
        }
    }
}
