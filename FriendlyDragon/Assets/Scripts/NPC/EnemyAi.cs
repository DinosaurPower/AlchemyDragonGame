using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{
    public class EnemyAi : MonoBehaviour
    {
        public Chase chase;
        public Patrol patrol;
        public HealthNpc realEnemy;
        private void Start()
        {
            realEnemy = GetComponentInParent<HealthNpc>();
            patrol = GetComponentInChildren<Patrol>();
            chase = GetComponentInChildren<Chase>();

            patrol.enemy = realEnemy.gameObject;
            chase.enemy = realEnemy.gameObject;
        }


        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                patrol.CanSeeDragon = true;
            }
        }
    }
}