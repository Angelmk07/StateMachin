using System.Collections.Generic;
using System;
using System.Xml;
namespace StateSystem
{
    public class StateMachinePlayer<T> where T : State
    {
        private readonly Dictionary<Type, T> _states;
        public State State { get; private set; }
        private IdleState IdleState = new();

        public StateMachinePlayer( InvisibleState invisibleState,ShootState shoot, RangeAtack range)
        {
            State = IdleState;
            _states = new Dictionary<Type, T>()
            {
                {typeof(InvisibleState), invisibleState as T},
                {typeof(ShootState), shoot as T},
                {typeof(RangeAtack), range as T},

            };
        }

        public bool IsCurrentState<T>() where T : State
        {
            return State is T;
        }
        public void ChangeState<T>() where  T : State
        {
            if (_states.ContainsKey(typeof(T)))
            {
                if(State != null)
                {
                    State.Exit();
                }
                State = _states[typeof(T)];
                State.Start();
            }
        }
    }
}