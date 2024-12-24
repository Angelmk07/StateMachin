using PlayerSystem;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace StateSystem
{
    public class RangeAtack : State
    {
        private float time = 2;
        private StateMachinePlayer<State> _stateMachin;
        private Player _player;
        private GameObject range;
        public RangeAtack(Player player) 
        {
            _player = player;
            
        }
        public void GetStateMachine( StateMachinePlayer<State> stateMachin)
        {
            _stateMachin = stateMachin;
        }
        public override void Exit()
        {
        }
        public override void Start()
        {
            range = MonoBehaviour.Instantiate(_player.Range, _player.player.transform.position, Quaternion.identity);
            _player.StartCoroutine(Invisibletimer());
        }
        IEnumerator Invisibletimer()
        {
            Vector3 initialScale = range.GetComponentInChildren<SpriteRenderer>().transform.localScale; 
            float elapsedTime = 0;

            while (elapsedTime < time)
            {
                elapsedTime += Time.deltaTime;
                range.GetComponentInChildren<SpriteRenderer>().transform.localScale = Vector3.Lerp(initialScale, new Vector3(1, 1, 1), elapsedTime / time);
                yield return null;
            }
            range.GetComponentInChildren<SpriteRenderer>().transform.localScale = initialScale;
            MonoBehaviour.Destroy(range);
        }
    }
}