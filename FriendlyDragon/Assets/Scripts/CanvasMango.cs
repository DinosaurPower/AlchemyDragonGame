using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{
    public class CanvasMango : MonoBehaviour
    {
        public KeyCode[] keycodes;
        public bool Crafting = false;

        public GameObject[] modes;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(keycodes[0]) || Input.GetKeyDown(keycodes[1]))
            {
                if (!Crafting)
                {
                    modes[1].SetActive(true);
                    modes[0].SetActive(false);
                    Crafting = true;
                    
                    
                } 
                else {
                    modes[0].SetActive(true);
                    modes[1].SetActive(false);
                    Crafting = false;
                  
                 
                }
            }
        }
    }
}