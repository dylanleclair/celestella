using System;

namespace heartflutter.States
{
    public class Climbing : PlayerState
    {
        public PlayerState HandleInput(Entity player)
        {


            // handle moving up

            // handle moving up onto an object?

            // handle down

            // handle jump

            throw new NotImplementedException();
        }

        public void OnEnter(Entity player)
        {
            var sprite = player.GetComponent<PrototypeSpriteRenderer>();
            sprite.SetColor(Color.Red);
        }

        public void OnExit(Entity player)
        {
            throw new NotImplementedException();
        }

        public void Update(Entity player)
        {
            throw new NotImplementedException();
        }
    }
}
