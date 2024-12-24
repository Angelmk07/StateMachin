
using StateSystem;
using UnityEngine;

namespace PlayerSystem
{
    internal class PlayerListener : MonoBehaviour
    {
        private StateMachinePlayer<State> machinePlayer;
        private StateMachineGame<State> game;
        private Player player;

        public void Construct(StateMachinePlayer<State> machinePlayer, StateMachineGame<State> game, Player player)
        {
            this.machinePlayer = machinePlayer;
            this.game = game;
            this.player = player;
        }



        private void Update()
        {
            if (game.State is StartGame)
            {
                HandlePlayerInput();
            }
            HandleGameInput();
        }

        private void HandlePlayerInput()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                machinePlayer.ChangeState<ShootState>();
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                machinePlayer.ChangeState<RangeAtack>();
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                machinePlayer.ChangeState<InvisibleState>();
            }
        }

        private void HandleGameInput()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                game.ChangeState<StopState>();
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                game.ChangeState<EndState>();
            }
        }
    }
}
