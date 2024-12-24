
using UnityEngine;

namespace PlayerSystem
{
    public class Player: MonoBehaviour
    {
        [field: SerializeField] public GameObject bullet {  get; private set; }
        [field: SerializeField] public GameObject Range {  get; private set; }
        public GameObject player {  get; private set; }
        [field: SerializeField] public SpriteRenderer renderer {  get; private set; }
        private void Awake()
        {
            player = gameObject;
            renderer = GetComponent<SpriteRenderer>();
        }
    }
}
