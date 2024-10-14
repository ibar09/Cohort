using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueOption : MonoBehaviour
{

    public string speakerNameTopic;

    public string option;
    public DialogueManager dialogueManager;
    private void OnEnable()
    {
        TextMeshProUGUI optionText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        optionText.text = option;
    }
    public void click()
    {
        dialogueManager.startDialogue(speakerNameTopic);
        foreach (DialogueOption opt in dialogueManager.optionBoxs)
        {
            opt.gameObject.SetActive(false);
        }

    }
}
