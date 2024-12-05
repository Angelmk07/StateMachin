using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Source.State
{
    public abstract class State
    {
        public virtual void Start()
        { }
        public virtual void Exit() 
        { }
    }
}