using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BattleHandler : MonoBehaviour
{
    public BattleBaseState currentState;
    public BattlePlayerState playerState = new BattlePlayerState();
    public BattleEnemyState enemyState = new BattleEnemyState();
    public CharacterBattle player;
    public CharacterBattle target;

    void Start()
    {
        currentState = playerState;

    }

    public void switchState(BattleBaseState b)
    {
        currentState = b;
        b.EnterState(this);
    }
    public void Action(Card card)
    {

        currentState.Action(this, card);
    }
    public void HandleCard(Card card)
    {
        switch (card.cardType)
        {
            case CardType.ATTACK:
                target.currentHealth -= card.value;
                print("attacking");
                GameObject obj = Instantiate(GameManager.Instance.popUpText, target.transform.position, Quaternion.identity);
                obj.GetComponent<TextMesh>().text = card.value.ToString();
                break;
            case CardType.HEAL:
                player.currentHealth += card.value;
                print("healing");
                break;

        }
    }


}
