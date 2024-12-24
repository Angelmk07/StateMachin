using PlayerSystem;
using UnityEngine;

namespace StateSystem
{
    public class StopState : State
    {
        StateMachineGame<State> game;
        public StopState(StateMachineGame<State> stateMachin)
        {

            this.game = stateMachin;
        }
        public override void Start()
        {
            if (Time.timeScale == 0.0f)
            {
                Time.timeScale = 1f;
                return;
            }
            Time.timeScale = 0.0f;
        }


    }
}