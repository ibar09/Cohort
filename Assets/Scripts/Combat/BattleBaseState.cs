
using UnityEngine;

public abstract class BattleBaseState
{
    public abstract void EnterState(BattleHandler battle);
    public abstract void Action(BattleHandler battle, Card card);

    public abstract void PassTurn(BattleHandler battle);


}
