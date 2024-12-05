using Assets._Source.State;
using System;
using UnityEngine;

namespace Assets.PlayerSystem
{
    internal class PlayerListener : MonoBehaviour
    {
        private StateMachinPlayer machinPlayer;
        private StateMachinGame game;
        private Player player;
        private RangeAtack rangeAtack;
        private ShootState shootState;
        private Invisible invisible;

        private Stop stop;
        private End end = new End();

        public void Construct(StateMachinPlayer machinPlayer, StateMachinGame game, Player player)
        {
            this.machinPlayer = machinPlayer;
            this.game = game;
            stop = new(game);
            this.player = player;
        }

        private void Start()
        {
            rangeAtack = new RangeAtack(player, machinPlayer);
            shootState = new ShootState(player);
            invisible = new Invisible(player, player.renderer, machinPlayer);
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
                machinPlayer.ChangeState(invisible);
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                machinPlayer.ChangeState(shootState);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                machinPlayer.ChangeState(rangeAtack);
            }
        }

        private void HandleGameInput()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                game.ChangeState(stop);
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                game.ChangeState(end);
            }
        }
    }
}
