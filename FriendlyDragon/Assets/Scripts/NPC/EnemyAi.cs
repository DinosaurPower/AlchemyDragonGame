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

        private void Start()
        {
            patrol = GetComponentInChildren<Patrol>();
            chase = GetComponentInChildren<Chase>();

            patrol.enemy = gameObject;
            chase.enemy = gameObject;
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