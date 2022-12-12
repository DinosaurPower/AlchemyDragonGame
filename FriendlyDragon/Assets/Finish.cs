using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Bananagodzilla
{


   public class Finish : MonoBehaviour
   {
      public GameObject cutscene;
      public void OnTriggerEnter2D(Collider2D col)
      {
         if (col.GetComponent<HeroHealth>() == true)
         {
            cutscene.SetActive(true);
         }
      }
   }
}