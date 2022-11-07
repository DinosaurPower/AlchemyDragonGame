using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Bananagodzilla
{


    public class Flip : MonoBehaviour
    {
        public Transform transform;
        public Rigidbody2D rb;
        public float sc;
        // Start is called before the first frame update
        private void Start()
        {
            transform = gameObject.GetComponent<Transform>();
            
        }

        // Update is called once per frame
        void Update()
        {
            if (rb.velocity.x < -1)
            {
                gameObject.GetComponent<Transform>().localScale = new Vector3(sc, sc, 0);
            }
        
            if (rb.velocity.x > 1)
            {
                gameObject.GetComponent<Transform>().localScale = new Vector3(-sc, sc, 0);
            }
            
        }
    }
}