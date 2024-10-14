using UnityEngine;
using System;

[CreateAssetMenu(fileName = "new speaker", menuName = "Speaker")]
public class Speaker : ScriptableObject
{
    public string SpeakerName;
    public Sprite image;

    [Serializable]
    public struct lineStruct
    {
        public string topic;
        public string targetTopic;
        public string nextSpeaker;
        [TextArea(0, 10)]
        public string[] line;
        public bool optionsTrigger;
        public string[] options;

    }
    public lineStruct[] lines;

    public string[] getLinesBasedOnTopic(string topic)
    {
        foreach (Speaker.lineStruct lineGroup in lines)
        {
            if (lineGroup.topic == topic)
            {
                return lineGroup.line;
            }

        }
        return null;
    }
    public string[] getOptionsBasedOnTopic(string topic)
    {
        foreach (Speaker.lineStruct lineGroup in lines)
        {
            if (lineGroup.topic == topic)
            {
                return lineGroup.options;
            }

        }
        return null;
    }
    public string getNextSpeaker(string topic)
    {
        foreach (Speaker.lineStruct lineGroup in lines)
        {
            if (lineGroup.topic == topic)
            {
                return lineGroup.nextSpeaker;
            }

        }
        return "";
    }
    public string getNextTopic(string topic)
    {
        foreach (Speaker.lineStruct lineGroup in lines)
        {
            if (lineGroup.topic == topic)
            {
                return lineGroup.targetTopic;
            }

        }
        return "";
    }
    public bool getIfOptions(string topic)
    {
        foreach (Speaker.lineStruct lineGroup in lines)
        {
            if (lineGroup.topic == topic)
            {
                return lineGroup.optionsTrigger;
            }

        }
        return false;
    }

}
