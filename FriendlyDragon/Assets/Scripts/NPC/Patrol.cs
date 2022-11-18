using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Bananagodzilla
{
    public class Patrol : State
    {

        public bool CanSeeDragon;
        public Chase chasestate;
        public override State RunCurrentState()
        {
            
            
            
            
            
            if (CanSeeDragon)
            {
                return chasestate;
            }
            else
            {
                return this;   
            }
   
        }

      

     
    }

}
