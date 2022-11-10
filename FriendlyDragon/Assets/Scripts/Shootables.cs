using System.Collections;
using System.Collections.Generic;
using Bananagodzilla;
using UnityEngine;
using UnityEngine.UI;

public class Shootables : MonoBehaviour
{

    public Item[] elements;
    public Item currentItem;
    public KeyCode[] shootKey;
    public int Counter;

    public GameObject selectedItem;
    // Start is called before the first frame update
    void Start()
    {
        
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
        selectedItem.GetComponent<Image>().sprite = currentItem.GetComponent<Image>().sprite;
        
    }
}
