
using UnityEngine;

public class FreeX : PlayerState
{
    public virtual PlayerState HandleInput(GameObject player)
    {
        return null;
    }

    public virtual void OnEnter(GameObject player)
    {

    }

    public virtual void OnExit(GameObject player)
    {

    }

    public virtual void Update(GameObject player)
    {
        //var p = player.GetComponent<PlayerMover>();
        //p.handleXAcceleration();
    }
}

