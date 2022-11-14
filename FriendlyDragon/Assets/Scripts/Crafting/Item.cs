using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Bananagodzilla
{
    public class Item : MonoBehaviour
    {
        public TMP_Text text;
        public string ItemName;

        public int ItemAmount = 100;
        public GameObject projectile;


        public void Start()
        {
            if (text == null)
            {
                text = GetComponentInChildren<TMP_Text>();
            }
        }

        private void Update()
        {
            if (text != null)
            {
                text.text = ItemAmount.ToString();
            }
        }

        public void spent()
        {
            ItemAmount--;
        }

        public void earned()
        {
            ItemAmount++;
        }
    }
}