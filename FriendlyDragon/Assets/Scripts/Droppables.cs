using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{


    public class Droppables : MonoBehaviour
    {
        public GameObject looted;

        public string lootableElement;
        // Start is called before the first frame update
        void Start()
        {
          //  looted = GameObject.Find(lootableElement);

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
               
           Destroy(gameObject); 
           Debug.Log("Looted");
            }
        }
    }
}
