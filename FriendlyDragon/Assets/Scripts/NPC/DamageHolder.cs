using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{
    public class DamageHolder : MonoBehaviour
    {
        public bool IsHurting = true;
        public int damage;


        private void OnCollisionStay2D(Collision2D collision)
        {
            if (collision.gameObject.GetComponent<HeroHealth>())
            {
                StartCoroutine(Hurt(collision.gameObject.GetComponent<HeroHealth>()));
            }
           
        }
        
        
        IEnumerator Hurt(HeroHealth heroHealth)
        {
            if (IsHurting == true)
            {
                heroHealth.Hurt(damage);
                Debug.Log("Waited");
                IsHurting = false;
            }
            yield return new WaitForSeconds(5);

            IsHurting = true;

        }
    }
}