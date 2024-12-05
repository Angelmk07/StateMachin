using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.PlayerSystem;

namespace Assets._Source.State
{
    public class Invisible : State
    {
        private SpriteRenderer spriteRenderer;
        private StateMachinPlayer stateMachin;
        private Player player;
        private float time = 5;
        public Invisible(Player player,SpriteRenderer Renderer,StateMachinPlayer stateMachin)
        {
             spriteRenderer = Renderer;
            this.player = player;
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
            if (stateMachin.IsCurrentState<Invisible>()) 
            {
                Exit();
            }
        } 
    }
}