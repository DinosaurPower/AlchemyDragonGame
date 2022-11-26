using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{
    public class EnemyAi : MonoBehaviour
    {
        public Animator anim;
        public Chase chase;
        public Patrol patrol;
        public HealthNpc realEnemy;
        private void Start()
        {
            anim = GetComponentInChildren<Animator>();
            realEnemy = GetComponentInParent<HealthNpc>();
            patrol = GetComponentInChildren<Patrol>();
            chase = GetComponentInChildren<Chase>();
            patrol.anim = anim;
            chase.anim = anim;
            patrol.enemy = realEnemy.gameObject;
            chase.enemy = realEnemy.gameObject;
        }


        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                patrol.CanSeeDragon = true;
               chase.CanSeeDragon = true;
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
               chase.CanSeeDragon = false;
               patrol.CanSeeDragon = false;
            }
        }
    }
}