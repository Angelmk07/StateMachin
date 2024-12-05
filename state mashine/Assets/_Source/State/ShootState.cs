using Assets.PlayerSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Source.State
{
    public class ShootState : State
    {
        private Player _player;
        public ShootState(Player player)
        {
            _player = player;
        }


        public override void Start()
        {
           GameObject bullet = MonoBehaviour.Instantiate(_player.bullet, _player.player.transform.position, Quaternion.identity);
           bullet.GetComponent<Rigidbody2D>().AddForce(_player.player.transform.up, ForceMode2D.Impulse);
        }


    }
}