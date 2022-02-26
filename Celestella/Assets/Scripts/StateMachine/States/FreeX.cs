namespace heartflutter.States
{
    public class FreeX : PlayerState
    {
        public virtual PlayerState HandleInput(Entity player)
        {
            return null;
        }

        public virtual void OnEnter(Entity player)
        {

        }

        public virtual void OnExit(Entity player)
        {

        }

        public virtual void Update(Entity player)
        {
            var p = player.GetComponent<PlayerMover>();
            p.handleXAcceleration();
        }
    }
}
