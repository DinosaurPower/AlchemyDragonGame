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

        private void OnTriggerStay(Collider other)
        {
            if (other.GetComponent<DamageHolder>() != null)
            {
                Hurt(other.GetComponent<DamageHolder>().damage);
            }
        }
        
        
        IEnumerator Hurt(int Damage)
        {


            maxHealth -= Damage;
            yield return new WaitForSeconds(1f);
            
        
        }
    }
}