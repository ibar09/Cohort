using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outline : MonoBehaviour
{
    Material material;
    public GameObject talkIcon;
    public string speakerNameTopic;
    public DialogueManager dialogueManager;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        dialogueManager.startDialogue(speakerNameTopic);
        talkIcon.SetActive(false);
    }

    private void OnMouseOver()
    {
        material.SetFloat("_Thickness", 0.8f);
        talkIcon.SetActive(true);
    }
    private void OnMouseExit()
    {
        material.SetFloat("_Thickness", 0f);
        talkIcon.SetActive(false);
    }
}
