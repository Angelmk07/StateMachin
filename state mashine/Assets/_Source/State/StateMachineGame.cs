using System;
using System.Collections.Generic;

namespace StateSystem
{
    public class StateMachineGame<T> where T : State
    {
        IdleState idle = new();
        public State State { get; private set; }
        private readonly Dictionary<Type, T> _states;
        public StateMachineGame(StartGame startGame, StopState stopState, EndState endState)
        {
            State = idle;
            _states = new Dictionary<Type, T>()
            {
                {typeof(StartGame), startGame as T},
                {typeof(StopState), stopState as T},
                {typeof(EndState), endState as T},

            };
        }
        public bool IsCurrentState<T>() where T : State
        {
            return State is T;
        }
        public void ChangeState<T>() where T : State
        {
            if (_states.ContainsKey(typeof(T)))
            {
                State.Exit();
                State = _states[typeof(T)];
                State.Start();
            }
        }

    }
}