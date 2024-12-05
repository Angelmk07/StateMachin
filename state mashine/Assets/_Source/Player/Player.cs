using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.PlayerSystem
{
    public class Player: MonoBehaviour
    {
        [field: SerializeField] public GameObject bullet {  get; private set; }
        [field: SerializeField] public GameObject Range {  get; private set; }
        public GameObject player {  get; private set; }
        public SpriteRenderer renderer {  get; private set; }
        private void Start()
        {
            player = gameObject;
            renderer = GetComponent<SpriteRenderer>();
        }
    }
}
