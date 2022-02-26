using UnityEngine;

public class Sliding : LockedX
{

    // must be recorded apart from PlayerMover direction, since
    // slide deceleration will be in the opposite of this direction.
    private sbyte _direction;
    private float _slideTimer;
    private float _slideDeceleration;

    private const float _slideTime = 0.4f;
    private const float _slideDistance = 48 * 4;


    public override PlayerState HandleInput(GameObject player)
    {

        var p = player.GetComponent<PlayerMover>();

        if (Input.IsKeyPressed(Controls.Jump))
        {
            return StateMachine.jumping;
        }

        else if (_slideTimer > _slideTime * 0.7f)
        {
            // return horizontal controls back to player

            if ((Input.IsKeyDown(Controls.Left) || Input.IsKeyDown(Controls.Right)) && p.CollisionState.Below)
                return StateMachine.running;
            else if (p.CollisionState.Below)
            {
                return StateMachine.standing;
            }
            else return StateMachine.inAir;
        }
        else
            return base.HandleInput(player);

    }
    public override void OnEnter(GameObject player)
    {

        // reset the slide timer
        _slideTimer = 0;

        var p = player.GetComponent<PlayerMover>();

        // record direction to slide in
        if (p._Direction.X > 0)
            _direction = 1;
        else if (p._Direction.X < 0)
            _direction = -1;

        // calculate initial slide velocity
        float slideVelocity = _direction * _slideTime * (2 * _slideDistance / (_slideTime * _slideTime)) * Time.DeltaTime;

        // add velocity to player vector
        p._Velocity.X += slideVelocity;

        // update state color
        var sprite = player.GetComponent<PrototypeSpriteRenderer>();
        sprite.SetColor(Color.White);

        base.OnEnter(player);

    }



    public override void Update(GameObject player)
    {

        _slideDeceleration = (2 * _slideDistance / (_slideTime * _slideTime)) * Time.DeltaTime * Time.DeltaTime;
        _slideTimer += Time.DeltaTime;

        var p = player.GetComponent<PlayerMover>();

        if (_direction > 0)
            p._Velocity.X -= _slideDeceleration;
        else if (_direction < 0)
            p._Velocity.X += _slideDeceleration;

        base.Update(player);
    }


}

