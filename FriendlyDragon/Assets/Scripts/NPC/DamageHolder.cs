using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{
    public class DamageHolder : MonoBehaviour
    {

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

            heroHealth.Hurt(damage);
            Debug.Log("Waited");
            yield return new WaitForSeconds(150f);
            
            
        
        }
    }
}