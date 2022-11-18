using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{


    public class Droppables : MonoBehaviour
    {
        public GameObject looted;

        public int elementNum;

        public ListOfElements list;
        // Start is called before the first frame update
        void Start()
        {
           
            list = FindObjectOfType(typeof(ListOfElements)) as ListOfElements;
            
           
        }

        void Update()
        {
            if (looted == null)
            {
                looted = list.listOfElemets[elementNum];
              
            }

           
        }
     

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                StartCoroutine(Loot());
                // Debug.Log("Looted");
            }
        }


        IEnumerator Loot()
        {
            
                if (looted != null)
                {
                    if (looted.GetComponent<Item>() != null)
                    {
                        
                        looted.GetComponent<Item>().earned();
                        Debug.Log("Achieved");
                    }
                }
                yield return new WaitForSeconds(.1f);
                
                Destroy(gameObject); 
        
        }
    }
}

