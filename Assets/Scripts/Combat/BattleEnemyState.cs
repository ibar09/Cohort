using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleEnemyState : BattleBaseState
{
    public override void EnterState(BattleHandler battle)
    {
        Action(battle, null);
    }
    public override void Action(BattleHandler battle, Card card)
    {
        Debug.Log("Enemy attack ! Enemy dealt 2 damage to the player");
        battle.player.takeDamage(2);
        PassTurn(battle);
    }



    public override void PassTurn(BattleHandler battle)
    {
        battle.switchState(battle.playerState);

        Debug.Log("switching to player's turn !");
    }
}
