using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePlayerState : BattleBaseState
{
    public CharacterBattle target;
    public override void EnterState(BattleHandler battle)
    {
        return;
    }
    public override void Action(BattleHandler battle, Card card)
    {
        battle.HandleCard(card);
        PassTurn(battle);
    }



    public override void PassTurn(BattleHandler battle)
    {
        battle.switchState(battle.enemyState);
    }


    public void SetTarget(CharacterBattle target)
    {
        this.target = target;
    }

}
