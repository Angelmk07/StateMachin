namespace Assets._Source.State
{
    public class StateMachinGame
    {
        public State State { get; private set; }

        public StateMachinGame(State initialState)
        {
            State = initialState;
            State.Start();
        }
        public bool IsCurrentState<T>() where T : State
        {
            return State is T;
        }
        public void ChangeState(State newState)
        {
            State.Exit();
            State = newState;
            State.Start();
        }

    }
}