using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : ScriptableObject
{
    public string effectName;
    public string description;
    public int duration;
    public int damage;
    public Sprite effectImage;
    public Effect()
    {

    }


    public void ApplyEffect(CharacterBattle target)
    {
        if (effectName == "Stun")
        {
            target.isStunned = true;
        }
        if (effectName == "Poison")
        {
            target.takeDamage(damage);
        }
    }

}
