using System;

namespace heartflutter.States
{
    public class InAir : FreeX
    {
        public override PlayerState HandleInput(Entity player)
        {
            var p = player.GetComponent<PlayerMover>();

            // If the player has landed
            if (p.Grounded)
            {
                // if the player is moving to either side still, assume they are running
                if (Math.Abs(p._Velocity.X) > 0)
                    return StateMachine.running;
                else
                    // finally, if they aren't moving and don't intend to slide, stay standing.
                    return StateMachine.standing;
            }
            else if (Input.IsKeyPressed(Controls.Jump) && p.currentJetpackStamina > 0)
            {
                return StateMachine.jetpacking;
            }
            else
                return base.HandleInput(player);
        }

        public override void OnEnter(Entity player)
        {
            var sprite = player.GetComponent<PrototypeSpriteRenderer>();
            sprite.SetColor(Color.Orange);

            base.OnEnter(player);

        }

        public override void OnExit(Entity player)
        {
            var p = player.GetComponent<PlayerMover>();
            p._Velocity.Y = 0;

            base.OnExit(player);
        }

        public override void Update(Entity player)
        {

            base.Update(player);

        }
    }
}
