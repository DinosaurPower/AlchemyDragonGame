using System;
using System.Collections;
using System.Collections.Generic;
using Bananagodzilla;
using UnityEngine;
using UnityEngine.UI;

namespace Bananagodzilla
{


    public class CraftingMango : MonoBehaviour
    {
        private Item currentItem;
        public Image customCursor;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnMouseDown(Item item)
        {
            if (currentItem == null)
            {
                currentItem = item;
                customCursor.gameObject.SetActive(true);
                customCursor.sprite = currentItem.GetComponent<Image>().sprite;
            }
        }
    }
}