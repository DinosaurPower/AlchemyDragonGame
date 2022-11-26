using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


namespace Bananagodzilla
{
    public class Patrol : State
    {
        public float speed;
        public Transform[] moveSpots;
        public bool CanSeeDragon;
        public Chase chasestate;
        private int randomSpot;
        private float waitTime = 1;
        public Animator anim;
        public float startWaitTime;
        public GameObject enemy;
        public override State RunCurrentState()
        {
            chasestate.patrolState = this;

            enemy.transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed*Time.deltaTime);
            if (enemy.transform.position.x < moveSpots[randomSpot].position.x)
            {
                enemy.GetComponentInChildren<SpriteRenderer>().flipX = true;
            }

            if (enemy.transform.position.x > moveSpots[randomSpot].position.x)
            {
                enemy.GetComponentInChildren<SpriteRenderer>().flipX = false;
            }

            if (Vector2.Distance(transform.position, moveSpots[randomSpot].position)< 1f)
            {
                if (waitTime <= 0)
                {
                    anim.SetBool("Walk", true);
                    randomSpot = Random.Range(0, moveSpots.Length-1);
                    waitTime = startWaitTime;
                }
                else
                {
                    
                    anim.SetBool("Walk", false);
                    waitTime -= Time.deltaTime;
                }
            }
        
            if (CanSeeDragon)
            {
                return chasestate;
            }
            else
            {
                return this;   
            }
   
        }

      

     
    }

}
