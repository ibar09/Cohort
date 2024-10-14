using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Speaker[] speakers;
    private Speaker speaker;
    public TextMeshProUGUI speakerNameGUI;
    public TextMeshProUGUI line;
    public string topic;
    public Image img;
    private int counter = 0;
    private State state = State.COMPLETED;
    public Button nextButton;
    private bool next = false;
    public DialogueOption[] optionBoxs;
    public GameObject dialogueBox;
    private string speakerName;

    public enum State
    {
        PLAYING,
        COMPLETED
    }

    public void startDialogue(string name)
    {
        dialogueBox.SetActive(true);
        string[] speakerTopic = name.Split('-');
        speakerName = speakerTopic[0];
        topic = speakerTopic[1];
        showDialogue();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            next = true;
        }
    }
    public void showDialogue()
    {
        speaker = findSpeaker(speakerName);
        int x = 0;
        if (speaker.getLinesBasedOnTopic(topic) != null)
        {
            x = speaker.getLinesBasedOnTopic(topic).Length;

        }

        if (counter < x)
        {

            speakerNameGUI.text = speaker.SpeakerName;
            img.sprite = speaker.image;
            StartCoroutine(showNextLineCouroutine(line, speaker.getLinesBasedOnTopic(topic), counter));
            counter++;
        }
        else if (speaker.getNextSpeaker(topic) != "" && speaker.getNextTopic(topic) != "")
        {
            Debug.Log(speaker.getIfOptions(topic));
            if (speaker.getIfOptions(topic))
            {
                counter = 0;
                Debug.Log("dkhalt");
                int optionIndex = 0;
                foreach (DialogueOption option in optionBoxs)
                {
                    string[] optTargetTopic = speaker.getOptionsBasedOnTopic(topic)[optionIndex].Split("-");
                    option.speakerNameTopic = speaker.getNextSpeaker(topic) + "-" + optTargetTopic[1];
                    option.option = optTargetTopic[0];
                    option.gameObject.SetActive(true);
                    optionIndex++;
                }
            }
            else
            {
                foreach (Speaker character in speakers)
                {

                    counter = 0;

                    if (character.SpeakerName == speaker.getNextSpeaker(topic))
                    {
                        speakerName = character.SpeakerName;
                        speakerNameGUI.text = character.SpeakerName;
                        img.sprite = character.image;
                        StartCoroutine(showNextLineCouroutine(line, character.getLinesBasedOnTopic(speaker.getNextTopic(topic)), counter));
                        topic = speaker.getNextTopic(topic);
                        speaker = character;
                        counter++;
                        break;
                    }
                }
            }
        }
        else
        {
            counter = 0;
            speaker = speakers[0];
            topic = "intro";
            dialogueBox.SetActive(false);


        }
    }
    IEnumerator showNextLineCouroutine(TextMeshProUGUI line, string[] speakerLines, int lineIndex)
    {
        Debug.Log("new line");
        next = false;
        int i = 0;
        line.text = "";
        state = State.PLAYING;
        while (state != State.COMPLETED)
        {
            nextButton.interactable = false;
            line.text += speakerLines[lineIndex][i];
            yield return new WaitForSeconds(0.03f);
            if (next)
            {
                line.text = speakerLines[lineIndex];
                setNext(false);
                state = State.COMPLETED;
                nextButton.interactable = true;
                break;
            }

            if (++i == speakerLines[lineIndex].Length)
            {
                state = State.COMPLETED;
                nextButton.interactable = true;
            }
        }
    }
    public Speaker findSpeaker(string name)
    {
        foreach (Speaker character in speakers)
        {
            if (character.SpeakerName == name)
                return character;
        }
        return null;
    }
    public void setNext(bool value)
    {
        next = value;
    }
}
