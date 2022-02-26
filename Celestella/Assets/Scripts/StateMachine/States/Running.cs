using UnityEngine;

public class Running : OnGround
{


    /// <summary>
    /// This is an example of when we need to override parent class
    /// </summary>
    /// <param name="player"></param>
    /// <returns></returns>
    public override PlayerState HandleInput(GameObject player)
    {

        var p = player.GetComponent<PlayerMover>();

        // if standing, change states
        if (!Input.IsKeyDown(Controls.Left) && !Input.IsKeyDown(Controls.Right)) // alternatively if neither left or right is down
        {
            return StateMachine.standing;
        } // if we are running, and the down key is pressed, slide!
        else if (Input.IsKeyPressed(Controls.Down))
        {
            return StateMachine.sliding;
        }
        else // check for jumping
        {
            return base.HandleInput(player);
        }


    }


    public override void OnEnter(GameObject player)
    {
        // update state color
        var sprite = player.GetComponent<PrototypeSpriteRenderer>();
        sprite.SetColor(Color.Blue);

        base.OnEnter(player);


    }

    public override void Update(GameObject player)
    {

        base.Update(player);
    }


}

