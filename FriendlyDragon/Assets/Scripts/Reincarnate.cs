using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{


    public class Reincarnate : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
           
                if (GameMango.instance.spawnPosition.magnitude > 0)
                {
                    transform.position = GameMango.instance.spawnPosition;
                }
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}