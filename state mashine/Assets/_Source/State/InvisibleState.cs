using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerSystem;

namespace StateSystem
{
    public class InvisibleState : State
    {
        private SpriteRenderer spriteRenderer;
        private StateMachinePlayer<State> stateMachin;
        private Player player;
        private float time = 5;
        public InvisibleState(Player player,SpriteRenderer Renderer)
        {
             spriteRenderer = Renderer;
            this.player = player;
           
        }
        public void GetStateMachine(StateMachinePlayer<State> stateMachin)
        {
            this.stateMachin = stateMachin;
        }
        public override void Exit()
        {
            spriteRenderer.forceRenderingOff = false;
        }

        public override void Start()
        {
            spriteRenderer.forceRenderingOff = true;
            player.StartCoroutine(Invisibletimer());
        }

 
        IEnumerator Invisibletimer()
        {
            yield return new WaitForSeconds(time);
            if (stateMachin.IsCurrentState<InvisibleState>()) 
            {
                Exit();
            }
        } 
    }
}