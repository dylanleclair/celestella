﻿using UnityEngine;

public class Standing : OnGround
{
    public override PlayerState HandleInput(GameObject player)
    {


        if (Input.IsKeyPressed(Controls.Left) || Input.IsKeyPressed(Controls.Right))
        {
            return StateMachine.running;
        }
        else
            return base.HandleInput(player);


    }

    public override void OnEnter(GameObject player)
    {
        // update state color
        var sprite = player.GetComponent<PrototypeSpriteRenderer>();
        sprite.SetColor(Color.Black);

        base.OnEnter(player);

    }

}


