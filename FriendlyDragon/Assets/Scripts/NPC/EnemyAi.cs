using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{
    public class EnemyAi : MonoBehaviour
    {

        public Patrol patrol;

        private void Start()
        {
            patrol = GetComponentInChildren<Patrol>();
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