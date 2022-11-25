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
        public int itemCode;
        public int ItemAmount;
        public GameObject projectile;
        public ListOfElements list;

        public void Start()
        {
            if (text == null)
            {
                text = GetComponentInChildren<TMP_Text>();
            }
            list = FindObjectOfType(typeof(ListOfElements)) as ListOfElements;
       
        }

        private void Update()
        {
            if (text != null)
            {
                text.text = ItemAmount.ToString();
            }

            ItemAmount = list.countOfElements[itemCode];
  
        }

        public void spent()
        {
            ItemAmount--;
            list.countOfElements[itemCode]--;
        }

        public void earned()
        {
            ItemAmount++;
          list.countOfElements[itemCode]++;
        }

      
    }
}