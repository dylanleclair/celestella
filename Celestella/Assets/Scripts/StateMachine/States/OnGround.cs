namespace heartflutter.States
{


    /// <summary>
    /// This class is the base class in the hierarchial FSM that allows us to control
    /// player movement. It handles jumping within it's HandleInput,
    /// so that other states that take place on ground do not have to.
    /// </summary>
    public class OnGround : FreeX
    {
        public override PlayerState HandleInput(Entity player)
        {
            // if no we walk off of a surface, change state to InAir

            var p = player.GetComponent<PlayerMover>();

            if (!p.CollisionState.Below)
            {
                return StateMachine.inAir; // then we are falling bro
            }

            // otherwise, check for valid on ground inputs
            else if (Input.IsKeyPressed(Controls.Jump))
            {
                // handle jumping
                return StateMachine.jumping;

            }
            else
                return base.HandleInput(player); // no change in state

        }

        public override void OnEnter(Entity player)
        {

            var p = player.GetComponent<PlayerMover>();
            p.ResetJetpackStamina();
            p.resetJumps();

        }

        public override void OnExit(Entity player)
        {
            base.OnExit(player);
        }

        public override void Update(Entity player)
        {
            // handles updating it


            base.Update(player);
        }
    }
}
