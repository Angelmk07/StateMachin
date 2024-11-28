namespace Assets._Source.State
{
    public class StateMachin
    {
        public State State { get; private set; }

        public StateMachin(State initialState)
        {
            State = initialState;
            State.Start();
        }

        public void ChangeState(State newState)
        {
            State.Exit();
            State = newState;
            State.Start();
        }
        public void Update()
        {
            State.Update();
        }
    }
}