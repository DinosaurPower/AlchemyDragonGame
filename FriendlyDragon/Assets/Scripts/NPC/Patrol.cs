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
        public float startWaitTime;
        public GameObject enemy;
        public override State RunCurrentState()
        {
           

            enemy.transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed*Time.deltaTime);

            if (Vector2.Distance(transform.position, moveSpots[randomSpot].position)< 1f)
            {
                if (waitTime <= 0)
                {
                    randomSpot = Random.Range(0, moveSpots.Length-1);
                    waitTime = startWaitTime;
                }
                else
                {
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
