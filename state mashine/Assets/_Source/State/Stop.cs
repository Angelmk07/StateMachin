using Assets.PlayerSystem;
using UnityEngine;

namespace Assets._Source.State
{
    public class Stop : State
    {
        StateMachinGame game;
        public Stop(StateMachinGame stateMachin)
        {

            this.game = stateMachin;
        }
        public override void Start()
        {
            if (game.IsCurrentState<Stop>())
            {
                Exit();
                return;
            }
            Time.timeScale = 0.0f;
        }

        public override void Exit()
        {

            Time.timeScale = 1.0f;
        }
    }
}