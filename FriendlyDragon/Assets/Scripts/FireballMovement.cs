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

       
        // Start is called before the first frame update
        void Start()
        {
            rigidbody = GetComponent<Rigidbody2D>();
            if (Right)
            {
                rigidbody.velocity = transform.right * projectileSpeed;
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