using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{
    public class Cage : MonoBehaviour
    {
        public GameObject cageLock;

        public Sprite cageOpen;
        // Start is called before the first frame update
        public void Open()
        {
            cageLock.gameObject.SetActive(false);
        }
    }
}