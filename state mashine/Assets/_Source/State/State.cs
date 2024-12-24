using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateSystem
{
    public abstract class State
    {
        public virtual void Start()
        { }
        public virtual void Exit() 
        { }
    }
}