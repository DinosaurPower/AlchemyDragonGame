using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{
    public class EnemyAi : MonoBehaviour
    {
        public Animator anim;
        public float runSpeed;
        public HealthNpc realEnemy;
        public GameObject dragon;
        public float speed;
        private float basicSpeed;
        public Transform[] moveSpots;
        private int randomSpot;
        private float waitTime = 1;
        public float startWaitTime;
        public Transform target;

        private void Start()
        {
            basicSpeed = speed;
            anim = GetComponentInParent<Animator>();
            realEnemy = GetComponentInParent<HealthNpc>();
            randomSpot =   UnityEngine.Random.Range(0, moveSpots.Length - 1);
            target = moveSpots[randomSpot];
            if (dragon == null)
            {
                dragon = GameObject.FindGameObjectWithTag("Player");
            }


        }

        private void FixedUpdate()
        {
            realEnemy.transform.position =
                Vector2.MoveTowards(transform.position, target.position, basicSpeed * Time.deltaTime);
            
            if (realEnemy.transform.position.x < target.position.x)
            {
                realEnemy.GetComponentInChildren<SpriteRenderer>().flipX = true;
            }

            if (realEnemy.transform.position.x > target.position.x)
            {
                realEnemy.GetComponentInChildren<SpriteRenderer>().flipX = false;
            }



            if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 1f)
            {
                if (waitTime <= 0)
                {
                    if (anim != false)
                    {
                        anim.SetBool("Walk", true);
                    }

                    randomSpot = UnityEngine.Random.Range(0, moveSpots.Length - 1);
                    target = moveSpots[randomSpot];
                    waitTime = startWaitTime;
                    
                }
                else
                {
                    if (anim != false)
                    {
                        anim.SetBool("Walk", false);
                    }
                   
                    waitTime -= Time.deltaTime;
                }
            }
        }

     
        
        void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                
                target = dragon.transform;
                basicSpeed = runSpeed;
            }
        }

        void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {

                target = moveSpots[randomSpot];
                basicSpeed = speed;


            }
        }
        
        
        
        
    }
}