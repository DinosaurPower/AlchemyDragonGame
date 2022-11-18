using System.Collections;
using System.Collections.Generic;
using Bananagodzilla;
using UnityEngine;

namespace Bananagodzilla
{
    public class Chase : State
    {
        public bool isViolent;
        public override State RunCurrentState()
        {
            Debug.Log("DragonDetected");
            return this;
        }

    }
}