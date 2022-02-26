using UnityEngine;

public class Jumping : PlayerState
{
    public PlayerState HandleInput(GameObject player)
    {
        // maybe add logic for holding a jump
        return StateMachine.inAir;
    }

    public void OnEnter(GameObject player)
    {


        // get playermover
        var p = player.GetComponent<PlayerMover>();

        p._Velocity.Y = 0;
        // add jump velocity
        p._Velocity.Y += p.JumpVelocity;


        // update state color
        var sprite = player.GetComponent<PrototypeSpriteRenderer>();
        sprite.SetColor(Color.Yellow);


    }

    public void OnExit(GameObject player)
    {
    }

    public void Update(GameObject player)
    {
    }
}

