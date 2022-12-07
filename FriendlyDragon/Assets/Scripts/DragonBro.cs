using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace Bananagodzilla
{


    public class DragonBro : MonoBehaviour
    {

        public Vector3 dragonScale;
        public Transform Dragon;
        // Start is called before the first frame update
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {
            gameObject.transform.position =
                Vector2.MoveTowards(transform.position, Dragon.position, 2*Time.deltaTime);
            
            if (gameObject.transform.position.x < Dragon.position.x)
            {
                transform.localScale = new Vector3(-dragonScale.x, dragonScale.y, dragonScale.z);
            }

            if (gameObject.transform.position.x > Dragon.position.x)
            {
                transform.localScale = new Vector3(dragonScale.x, dragonScale.y, dragonScale.z);
            }
        }
    }
}