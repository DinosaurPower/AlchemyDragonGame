using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
namespace Bananagodzilla
{
    
    public class HeroHealth : MonoBehaviour
    {

        public int maxHealth;
        public TMP_Text HealthBar;

        // Update is called once per frame
        void Update()
        {

            HealthBar.text = (maxHealth.ToString() + " HP");
            if (maxHealth <= 0)
            {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);

            }
        }

        private void OnTriggerStay2D(Collider2D other)
        { Debug.Log("interacted");
            if (other.GetComponent<DamageHolder>() != null)
            {
                Debug.Log("IsAttacking");
                StartCoroutine(Hurt(other.GetComponent<DamageHolder>().damage));
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        { Debug.Log("interacted");
            if (other.GetComponent<DamageHolder>() != null)
            {Debug.Log("IsAttacking");
                StartCoroutine(Hurt(other.GetComponent<DamageHolder>().damage));
            }
        }


        IEnumerator Hurt(int Damage)
        {

Debug.Log("outch");
            maxHealth -= Damage;
            yield return new WaitForSeconds(1f);
            
        
        }
    }
}