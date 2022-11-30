using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Bananagodzilla
{
    public class BullsEye : MonoBehaviour
    {
        public GameObject gate;

        public Sprite sprite2;
        // Start is called before the first frame update
       

        public void Hitt()
        {
           
            Debug.Log("Hitttttttttt");
                
                gate.GetComponent<Collider2D>().enabled = false;
                gate.GetComponent<SpriteRenderer>().sprite = sprite2;
            
        }
    }
}