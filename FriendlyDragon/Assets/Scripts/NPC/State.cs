using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Bananagodzilla{
public abstract class State : MonoBehaviour
{
    public abstract State RunCurrentState();
}
}