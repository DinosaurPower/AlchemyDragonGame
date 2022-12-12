using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{


    public class Unicorn : MonoBehaviour
    {
        public GameObject[] Instantiatable;
        // Start is called before the first frame update


        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.GetComponent<Unicorn>() == true)
            {
                foreach (var plant in Instantiatable)
                {
                    Instantiate(plant, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                }
            }
        }
    }
}