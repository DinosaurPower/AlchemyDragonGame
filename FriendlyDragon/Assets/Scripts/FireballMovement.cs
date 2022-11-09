using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Bananagodzilla
{

    public class FireballMovement : MonoBehaviour
    {
        // Start is called before the first frame update

        public float projectileSpeed;
        public Rigidbody2D rigidbody;
        public float DeathTime;
        public bool Right;
        public DragonMove move;

        public float DragonDir;
        // Start is called before the first frame update
        void Start()
        { move = FindObjectOfType(typeof(DragonMove)) as DragonMove;

            DragonDir = move.GetComponent<Rigidbody2D>().velocity.x;
            rigidbody = GetComponent<Rigidbody2D>();
              rigidbody.velocity = transform.right * projectileSpeed*DragonDir;
            if (Right)
            {
                rigidbody.velocity = transform.right * projectileSpeed*DragonDir;
            }

            if (!Right)
            {
                rigidbody.velocity = transform.right * projectileSpeed * -1;
            }




        }

        // Update is called once per frame
        void Update()
        {

        }




        //var enemyComponent = GetComponent<EnemyHealth>();
    }

}