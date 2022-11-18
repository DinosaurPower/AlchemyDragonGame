using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{


    public class Run : State
    {
        public override State RunCurrentState()
        {
            Debug.Log("DragonDetected");
            return this;
        }
    }
}