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
        public ItemSlot[] craftingSlots;

        public List<Item> itemList;
        public string[] recipes;
        public Item[] recipeResults;
        public ItemSlot resultSlot;
        
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonUp(0))
            {
                if (currentItem != null)
                {
                    customCursor.gameObject.SetActive(false);
                   ItemSlot nearestSlot = null;
                   float shortestDistance = float.MaxValue;
                   foreach (ItemSlot slot in craftingSlots)
                   {
                       //if (mouseposition.x >> kdlks && mouseposition << eiofiej
                       //remove middle slot
                       float dist = Vector2.Distance(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f)), slot.transform.position);
                       if (dist < shortestDistance)
                       {
                           shortestDistance = dist;
                           nearestSlot = slot;
                       }
                   }
                   nearestSlot.gameObject.SetActive(true);
                   nearestSlot.GetComponent<Image>().sprite = currentItem.GetComponent<Image>().sprite;
                   nearestSlot.item = currentItem;
                   itemList[nearestSlot.index] = currentItem;
                   currentItem = null;

                   CheckForCompletedRecipes();
                }
            }
        }
        
        
void CheckForCompletedRecipes(){
    resultSlot.gameObject.SetActive(false);
    resultSlot.item = null;
    string currentrecipestring = "";

    foreach (Item item in itemList)
    {
        if (item != null)
        {
            currentrecipestring += item.ItemName;
        }
        else
        {
            currentrecipestring += "null";
        }

        for (int i = 0; i < recipes.Length; i++)
        {
            if (recipes[i] == currentrecipestring)
            {
                resultSlot.gameObject.SetActive(true);
                resultSlot.GetComponent<Image>().sprite = recipeResults[i].GetComponent<Image>().sprite;
                resultSlot.item = recipeResults[i];
            }
        }
    }


}



public void Craft()
{
    if (craftingSlots[0].item.ItemAmount>= 0 && craftingSlots[1].item.ItemAmount>= 0)
    if (resultSlot.item != null){
    foreach (ItemSlot slot in craftingSlots)
    {
        slot.item.spent();
    }
    resultSlot.item.earned();
    }
}


public void OnClickSLot(ItemSlot slot)
{
    slot.item = null;
    itemList[slot.index] = null;
    slot.gameObject.SetActive(false);
    CheckForCompletedRecipes();
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