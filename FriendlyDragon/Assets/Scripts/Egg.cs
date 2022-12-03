using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{
    public class Egg : MonoBehaviour
    {


        public Sprite closed;
        // Start is called before the first frame update
        void Start()
        {
            

        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void Close()
        {
            GameMango.instance.spawnPosition = transform.position;
            if (gameObject.GetComponent<SpriteRenderer>().sprite != closed)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = closed;
            }
          
        }
        
    }
}
