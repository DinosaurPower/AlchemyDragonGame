using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{
    public class Cage : MonoBehaviour
    {
        public GameObject[] cageLock;
        public GameObject CageDoor;
        public Sprite cageOpen;
        // Start is called before the first frame update
        public void Open()
        {
            foreach (var obj in cageLock)
            {
                obj.SetActive(false);
            }


            CageDoor.GetComponent<SpriteRenderer>().sprite = cageOpen;
        }
    }
}