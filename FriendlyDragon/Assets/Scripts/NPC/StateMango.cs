using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{ public class StateMango : MonoBehaviour
    {
        
       public State currentState;

        // Update is called once per frame
        void Update()
        {
RunStateMachine();
        }

        private void RunStateMachine()
        {
            State nextState = currentState?.RunCurrentState();
            if (nextState != null)
            {
                SwitchTONextState(nextState);
            }
            
        }
        
        private void SwitchTONextState(State nextState)
        {
            currentState = nextState;
        }
        
        
        
        
    }
}