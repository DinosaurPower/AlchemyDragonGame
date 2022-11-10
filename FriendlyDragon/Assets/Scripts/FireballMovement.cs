using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;


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
                if (BallType == "build"|| BallType == "clone"|| BallType == "telep")
                {
                    Instantiate(Wall, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
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

                if (BallType == "telep")
                {
                    if (col.CompareTag("Enemy"))
                    {
                        Wall = col.gameObject;
                       Destroy(col.gameObject);
                    }
                }

                if (BallType == "clone")
                {
                    if (col.CompareTag("Enemy"))
                    {
                        Wall = col.gameObject;
                        
                    }
                }
             
               
                
             
            
        }


       
    }

}