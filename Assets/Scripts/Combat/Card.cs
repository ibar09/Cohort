using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public string cardName;
    public string description;
    public int manaCost;
    public Sprite cardImage;
    public CardType cardType;
    public int value;
    public EffectType effectType;
    public BuffType buffType;


}
public enum CardType
{
    ATTACK,

    HEAL,
    BUFF,
    DEBUFF,
}
public enum EffectType
{
    NONE,
    STUN,
    POISON,

}
public enum BuffType
{
    NONE,
    ATTACK,
    DEFENSE,
    MANA,
}
