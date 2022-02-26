using System;
using UnityEngine;

public class Jetpacking : InAir
{

    public override PlayerState HandleInput(GameObject player)
    {

        if (Input.IsKeyReleased(Controls.Jump))
        {
            return StateMachine.inAir;
        }
        else
            return base.HandleInput(player);
    }

    public override void OnEnter(GameObject player)
    {
        var sprite = player.GetComponent<PrototypeSpriteRenderer>();
        sprite.SetColor(Color.Green);
        //base.OnEnter(player);
    }

    public override void OnExit(GameObject player)
    {

    }


    public override void Update(GameObject player)
    {
        // update x velocity
        base.Update(player);

        var p = player.GetComponent<PlayerMover>();

        if (p.currentJetpackStamina > 0)
        {
            if (p._Velocity.Y > 0)
            {
                p._Velocity.Y = 0;
            }

            p._Velocity.X = p._Velocity.X * 0.92f;

            p._Velocity.Y = Math.Max(p._Velocity.Y - p.JetpackAccel, -1 * p.JetpackSpeed);

            p.currentJetpackStamina -= 4;
        }


    }

}

