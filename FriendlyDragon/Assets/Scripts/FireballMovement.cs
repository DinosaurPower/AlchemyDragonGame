using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UIElements;


namespace Bananagodzilla
{

    public class FireballMovement : MonoBehaviour
    {
        // Start is called before the first frame update

        public float projectileSpeed;
        public Rigidbody2D rigidbody;
        private float timer;
       public float limit = 1f;
        public Flip direction;
        public float DragonDir;
        public string BallType;
        public GameObject Wall;
        public float attackRange = 1f;
        public LayerMask enemyLayer;
        // Start is called before the first frame update
        void Start()
        {
           
            
            
            
            direction = FindObjectOfType(typeof(Flip)) as Flip;

            DragonDir = direction.Direction;
            rigidbody = GetComponent<Rigidbody2D>();
            if (DragonDir <0){  rigidbody.velocity = transform.right * projectileSpeed;} 
            if (DragonDir >0) {rigidbody.velocity = transform.right * projectileSpeed*-1;} 
            
            




        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;


            if (timer >= limit)
            {
                if (BallType == "build"|| BallType == "clone")
                {
                    Instantiate(Wall, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                }
                
                if (BallType == "telep")
                {
                    Wall.transform.Translate(gameObject.GetComponent<Transform>().position);
                }
                Destroy(gameObject);
              
            }
            
            
        }


        private void OnTriggerEnter2D(Collider2D col)
        {
            
                if (BallType == "dest")
                {
                    if (col.CompareTag("Enemy"))
                    {
                       
                        Debug.Log("shot");
                        
                        Destroy(gameObject);
                    }
                }
                
                if (BallType == "inter")
                {
                    if (col.CompareTag("Enemy"))
                    {
                       
                        Debug.Log("interacted");
                        
                        Destroy(gameObject);
                    }
                }

                if (BallType == "telep" || BallType == "clone")
                {
                    if (col.CompareTag("Enemy"))
                    {
                        Wall = col.gameObject;
                    }
                }

             

                if (BallType == "nuclear")
                {
                    Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(gameObject.GetComponent<Transform>().position, attackRange, enemyLayer);
                    foreach(Collider2D enemy in hitEnemies)
                    {
                        Debug.Log("Hit" + enemy.name);
                       
                    }
                }
             
               
                
             
            
        }


       
    }

}