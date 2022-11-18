using System.Collections;
using System.Collections.Generic;
using Bananagodzilla;
using UnityEngine;

namespace Bananagodzilla
{
    public class Chase : State
    {
        public GameObject dragon;
        public float speed;
        public GameObject enemy;
        public bool isViolent;
        public override State RunCurrentState()
        {
            if (dragon == null)
            {
                dragon = GameObject.FindGameObjectWithTag("Player");
            }
            if (isViolent == true)
            {
                enemy.transform.position = Vector2.MoveTowards(transform.position, dragon.GetComponent<Transform>().position, speed*Time.deltaTime);
            }
            Debug.Log("DragonDetected");
            return this;
        }

    }
}