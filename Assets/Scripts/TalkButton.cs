using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkButton : MonoBehaviour
{
    public string speakerNameTopic;
    public DialogueManager dialogueManager;

    private void OnMouseDown()
    {
        dialogueManager.startDialogue(speakerNameTopic);
    }
}
