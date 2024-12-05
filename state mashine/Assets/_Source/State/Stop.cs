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
            if (Time.timeScale == 0.0f)
            {
                Time.timeScale = 1f;
                return;
            }
            Time.timeScale = 0.0f;
        }


    }
}