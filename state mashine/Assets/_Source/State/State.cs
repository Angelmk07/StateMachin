using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Source.State
{
    public abstract class State
    {
        public abstract void Start();
        public abstract void Update();
        public abstract void Exit();
    }
}