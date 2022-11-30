using System.Collections;
using System.Collections.Generic;
using Bananagodzilla;
using UnityEngine;

namespace Bananagodzilla
{
    public class Chase : State
    {
        public Animator anim;
        public bool CanSeeDragon;
        public GameObject dragon;
        public float speed;
        public GameObject enemy;
        public Patrol patrolState;
        public override State RunCurrentState()
        {
            if (dragon == null)
                         {
                             dragon = GameObject.FindGameObjectWithTag("Player");
                         }
                         anim.SetBool("Walk", true);
                         enemy.transform.position = Vector2.MoveTowards(transform.position, dragon.GetComponent<Transform>().position, speed*Time.deltaTime);
                         if (enemy.transform.position.x < dragon.GetComponent<Transform>().position.x)
                         {
                             enemy.GetComponentInChildren<SpriteRenderer>().flipX = true;
                         }
             
                         if (enemy.transform.position.x > dragon.GetComponent<Transform>().position.x)
                         {
                             enemy.GetComponentInChildren<SpriteRenderer>().flipX = false;
                         }
            
            if (!CanSeeDragon)
            {
                return patrolState;
            }
            else
            {
                return this;   
            }
        }

    }
}