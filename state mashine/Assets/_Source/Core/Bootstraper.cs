using StateSystem;
using PlayerSystem;
using UnityEngine;

namespace Core
{

    public class Bootstraper : MonoBehaviour
    {
        [SerializeField] PlayerListener _listener;
        [SerializeField] Player player;
        private StartGame start = new ();

        private StateMachinePlayer<State> stateMachine ;
        private StateMachineGame<State> gameMachine;
        private RangeAtack rangeAtack;
        private ShootState shootState;
        private InvisibleState invisible;
        private StopState stop;
        private EndState end = new EndState();
        private void Awake()
        {
            gameMachine = new StateMachineGame<State>(start, stop, end);
            rangeAtack = new RangeAtack(player);
            shootState = new ShootState(player);
            invisible = new InvisibleState(player, player.renderer);
            stateMachine = new StateMachinePlayer<State>(invisible, shootState, rangeAtack);
            rangeAtack.GetStateMachine(stateMachine);
            invisible.GetStateMachine(stateMachine);
            stop = new StopState(gameMachine);
            gameMachine.ChangeState<StartGame>();
            _listener.Construct(stateMachine, gameMachine, player);
        }
    }
}