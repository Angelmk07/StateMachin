using Assets._Source.State;
using Assets.PlayerSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Source.Cor
{

    public class Bootstraper : MonoBehaviour
    {
        [SerializeField] PlayerListener _listener;
        [SerializeField] Player player;
        private IdleState idleState = new IdleState();
        private StartGame start = new ();

        private StateMachinPlayer stateMachine;
        private StateMachinGame game;
        
        private void Awake()
        {
            stateMachine = new StateMachinPlayer(idleState);
            game = new StateMachinGame(start);
            _listener.Construct(stateMachine, game, player);
        }
    }
}