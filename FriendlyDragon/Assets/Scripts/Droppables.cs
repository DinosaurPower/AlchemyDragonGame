using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{


    public class Droppables : MonoBehaviour
    {
       

        public int elementNum;

        public ListOfElements list;
        // Start is called before the first frame update
        void Start()
        {
           
            list = FindObjectOfType(typeof(ListOfElements)) as ListOfElements;
            
           
        }

        void Update()
        {
            

           
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
            
                
                    
                        
                      list.Increase(elementNum);
                        Debug.Log("Achieved");
                    
                
                yield return new WaitForSeconds(.1f);
                
                Destroy(gameObject); 
        
        }
    }
}

