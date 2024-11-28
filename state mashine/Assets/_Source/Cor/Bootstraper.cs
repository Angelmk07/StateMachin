using Assets._Source.State;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Source.Cor
{

    public class Bootstraper : MonoBehaviour
    {
        private IdleState idleState = new IdleState();

        private StateMachin stateMachine;

        private void Awake()
        {
            stateMachine = new StateMachin(idleState);
        }

        private void Update()
        {
            stateMachine.Update();
        }
    }

}