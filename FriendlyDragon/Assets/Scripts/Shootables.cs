using System.Collections;
using System.Collections.Generic;
using Bananagodzilla;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Bananagodzilla
{


    public class Shootables : MonoBehaviour
    {

        public Item[] elements;
        public Item currentItem;
        public KeyCode[] shootKey;
        public int Counter;
        public ListOfElements list;
        public TMP_Text resourceAmount;
        public int itemAmount;
        public GameObject selectedItem;

        // Start is called before the first frame update
        void Start()
        {
            list = FindObjectOfType(typeof(ListOfElements)) as ListOfElements;

        }
        public void Shot()
        {
            list.countOfElements[Counter]--;
            currentItem.ItemAmount = list.countOfElements[Counter];
        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetKeyDown(shootKey[0]) || Input.GetKeyDown(shootKey[1]))
            {
                Counter++;
                if (Counter == elements.Length)
                {
                    Counter = 0;
                }
            }

            currentItem = elements[Counter];
            currentItem.ItemAmount = list.countOfElements[Counter];
            gameObject.GetComponent<Shooting>().projectile = currentItem.projectile;
            selectedItem.GetComponent<Image>().sprite = currentItem.GetComponent<Image>().sprite;
            resourceAmount.text = currentItem.ItemAmount.ToString();
        }

        
     
       
    }
    
}