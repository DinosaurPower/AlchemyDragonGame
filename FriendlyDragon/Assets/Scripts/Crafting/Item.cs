using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{
    public class Item : MonoBehaviour
    {
        public string ItemName;

        public int ItemAmount = 100;
        public GameObject projectile;

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