using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Bananagodzilla
{


    public class HealthNpc : MonoBehaviour
    {
        public string Interactable;
        public TMP_Text Text;
        public GameObject Talk;
        public float Health;
        public GameObject[] dropping;

    

        private void Update()
        {
            if (Health <= 0)
            {
                foreach (var drop in dropping)
                {
                    Instantiate(drop, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                }
            }
        }

        public void Hurt()
        {
            Health--;
        }

        public void Interact()
        {
            if (Talk != null)
            {
                Talk.SetActive(true);
            }

            if (Text != null)
            {
                Text.text = Interactable;
            }
        }
    }
}